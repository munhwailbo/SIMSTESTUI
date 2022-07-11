Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC205
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC205))
            Me.txtAddr_2 = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtPhoneNum_2 = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtSubscriberNm_2 = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtReceiptCd_2 = New ubiLease.CommonControls.txt
            Me.Label4 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.popDeliveryBranchCd_2 = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.cboReaderStateCd = New ubiLease.CommonControls.cbo
            Me.cboExpandDivCd = New ubiLease.CommonControls.cbo
            Me.popCompanyCd_R = New ubiLease.CommonControls.pop
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.btnApprovalAll = New System.Windows.Forms.Button
            Me.picCriteria2 = New System.Windows.Forms.PictureBox
            Me.cboReaderStateCd_E = New ubiLease.CommonControls.cbo
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpRealEdDt = New ubiLease.CommonControls.dtp
            Me.Label10 = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtAddr_2
            '
            Me.txtAddr_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddr_2.BorderColor = System.Drawing.Color.Empty
            Me.txtAddr_2.BorderStyle = 2
            Me.txtAddr_2.CaptionName = "주소"
            Me.txtAddr_2.Location = New System.Drawing.Point(639, 102)
            Me.txtAddr_2.MaxLength = 12
            Me.txtAddr_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddr_2.Multiline = False
            Me.txtAddr_2.Name = "txtAddr_2"
            Me.txtAddr_2.ReadOnlys = False
            Me.txtAddr_2.SelectedText = ""
            Me.txtAddr_2.SelectionLength = 0
            Me.txtAddr_2.SelectionStart = 0
            Me.txtAddr_2.Size = New System.Drawing.Size(26, 20)
            Me.txtAddr_2.TabIndex = 23
            Me.txtAddr_2.Tag = ""
            Me.txtAddr_2.TextAlign = 0
            Me.txtAddr_2.TextValue = ""
            Me.txtAddr_2.ToolTipText = ""
            Me.txtAddr_2.Visible = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(571, 105)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(61, 15)
            Me.Label1.TabIndex = 24
            Me.Label1.Text = "주소"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label1.Visible = False
            '
            'txtPhoneNum_2
            '
            Me.txtPhoneNum_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum_2.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum_2.BorderStyle = 2
            Me.txtPhoneNum_2.CaptionName = "전화번호1"
            Me.txtPhoneNum_2.Location = New System.Drawing.Point(741, 102)
            Me.txtPhoneNum_2.MaxLength = 14
            Me.txtPhoneNum_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum_2.Multiline = False
            Me.txtPhoneNum_2.Name = "txtPhoneNum_2"
            Me.txtPhoneNum_2.ReadOnlys = False
            Me.txtPhoneNum_2.SelectedText = ""
            Me.txtPhoneNum_2.SelectionLength = 0
            Me.txtPhoneNum_2.SelectionStart = 0
            Me.txtPhoneNum_2.Size = New System.Drawing.Size(26, 20)
            Me.txtPhoneNum_2.TabIndex = 21
            Me.txtPhoneNum_2.Tag = ""
            Me.txtPhoneNum_2.TextAlign = 0
            Me.txtPhoneNum_2.TextValue = ""
            Me.txtPhoneNum_2.ToolTipText = ""
            Me.txtPhoneNum_2.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(670, 105)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 15)
            Me.Label2.TabIndex = 22
            Me.Label2.Text = "전화번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Visible = False
            '
            'txtSubscriberNm_2
            '
            Me.txtSubscriberNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm_2.BorderStyle = 2
            Me.txtSubscriberNm_2.CaptionName = Nothing
            Me.txtSubscriberNm_2.Location = New System.Drawing.Point(482, 34)
            Me.txtSubscriberNm_2.MaxLength = 32767
            Me.txtSubscriberNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm_2.Multiline = False
            Me.txtSubscriberNm_2.Name = "txtSubscriberNm_2"
            Me.txtSubscriberNm_2.ReadOnlys = False
            Me.txtSubscriberNm_2.SelectedText = ""
            Me.txtSubscriberNm_2.SelectionLength = 0
            Me.txtSubscriberNm_2.SelectionStart = 0
            Me.txtSubscriberNm_2.Size = New System.Drawing.Size(307, 20)
            Me.txtSubscriberNm_2.TabIndex = 6
            Me.txtSubscriberNm_2.Tag = Nothing
            Me.txtSubscriberNm_2.TextAlign = 0
            Me.txtSubscriberNm_2.TextValue = ""
            Me.txtSubscriberNm_2.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(423, 37)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(57, 15)
            Me.Label3.TabIndex = 17
            Me.Label3.Text = "독자명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReceiptCd_2
            '
            Me.txtReceiptCd_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtReceiptCd_2.BorderColor = System.Drawing.Color.Empty
            Me.txtReceiptCd_2.BorderStyle = 2
            Me.txtReceiptCd_2.CaptionName = Nothing
            Me.txtReceiptCd_2.Location = New System.Drawing.Point(706, 57)
            Me.txtReceiptCd_2.MaxLength = 32767
            Me.txtReceiptCd_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReceiptCd_2.Multiline = False
            Me.txtReceiptCd_2.Name = "txtReceiptCd_2"
            Me.txtReceiptCd_2.ReadOnlys = False
            Me.txtReceiptCd_2.SelectedText = ""
            Me.txtReceiptCd_2.SelectionLength = 0
            Me.txtReceiptCd_2.SelectionStart = 0
            Me.txtReceiptCd_2.Size = New System.Drawing.Size(83, 20)
            Me.txtReceiptCd_2.TabIndex = 9
            Me.txtReceiptCd_2.Tag = Nothing
            Me.txtReceiptCd_2.TextAlign = 0
            Me.txtReceiptCd_2.TextValue = ""
            Me.txtReceiptCd_2.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(647, 59)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(57, 16)
            Me.Label4.TabIndex = 20
            Me.Label4.Text = "독자코드"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 82)
            Me.picCriteria.TabIndex = 1198
            Me.picCriteria.TabStop = False
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
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 134)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 509)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 0
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "담당자"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(482, 57)
            Me.popEmployeeNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeNumber.MaxLength = 32767
            Me.popEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeNumber.Name = "popEmployeeNumber"
            Me.popEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeNumber.NameText = ""
            Me.popEmployeeNumber.ReadOnlys = False
            Me.popEmployeeNumber.SelectedText = ""
            Me.popEmployeeNumber.SelectionLength = 0
            Me.popEmployeeNumber.SelectionStart = 0
            Me.popEmployeeNumber.Size = New System.Drawing.Size(150, 20)
            Me.popEmployeeNumber.TabIndex = 8
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'popDeliveryBranchCd_2
            '
            Me.popDeliveryBranchCd_2.BorderColor = System.Drawing.Color.Empty
            Me.popDeliveryBranchCd_2.BorderStyle = 2
            Me.popDeliveryBranchCd_2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeliveryBranchCd_2.CaptionName = "지사지국 코드"
            Me.popDeliveryBranchCd_2.CodeText = ""
            Me.popDeliveryBranchCd_2.CodeWidth = 60
            Me.popDeliveryBranchCd_2.Location = New System.Drawing.Point(85, 57)
            Me.popDeliveryBranchCd_2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popDeliveryBranchCd_2.MaxLength = 32767
            Me.popDeliveryBranchCd_2.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popDeliveryBranchCd_2.Name = "popDeliveryBranchCd_2"
            Me.popDeliveryBranchCd_2.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popDeliveryBranchCd_2.NameText = ""
            Me.popDeliveryBranchCd_2.ReadOnlys = False
            Me.popDeliveryBranchCd_2.SelectedText = ""
            Me.popDeliveryBranchCd_2.SelectionLength = 0
            Me.popDeliveryBranchCd_2.SelectionStart = 0
            Me.popDeliveryBranchCd_2.Size = New System.Drawing.Size(323, 20)
            Me.popDeliveryBranchCd_2.TabIndex = 7
            Me.popDeliveryBranchCd_2.Tag = "code(지국코드);"
            Me.popDeliveryBranchCd_2.TextAlign = 0
            Me.popDeliveryBranchCd_2.TextValue = ""
            Me.popDeliveryBranchCd_2.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(423, 60)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(57, 15)
            Me.Label33.TabIndex = 19
            Me.Label33.Text = "담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(17, 60)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(61, 15)
            Me.lblFormDivisionCode.TabIndex = 13
            Me.lblFormDivisionCode.Text = "지사지국"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDtFrom
            '
            Me.dtpReceiptDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtFrom.BorderStyle = 2
            Me.dtpReceiptDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtFrom.CaptionName = "접수 일자"
            Me.dtpReceiptDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(85, 11)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtFrom.TabIndex = 1
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(175, 14)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 14
            Me.Label6.Text = "~"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDtTo
            '
            Me.dtpReceiptDtTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtTo.BorderStyle = 2
            Me.dtpReceiptDtTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtTo.CaptionName = "접수 일자 2"
            Me.dtpReceiptDtTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(196, 11)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtTo.TabIndex = 2
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(17, 14)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(61, 15)
            Me.Label8.TabIndex = 11
            Me.Label8.Text = "접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(423, 14)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(57, 15)
            Me.Label7.TabIndex = 15
            Me.Label7.Text = "확장구분"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(607, 14)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(65, 15)
            Me.Label9.TabIndex = 18
            Me.Label9.Text = "구독상태"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboReaderStateCd
            '
            Me.cboReaderStateCd.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.cboReaderStateCd.CaptionName = "구독상태코드"
            Me.cboReaderStateCd.ListCount = 0
            Me.cboReaderStateCd.Location = New System.Drawing.Point(678, 11)
            Me.cboReaderStateCd.Name = "cboReaderStateCd"
            Me.cboReaderStateCd.ReadOnlys = False
            Me.cboReaderStateCd.Size = New System.Drawing.Size(111, 20)
            Me.cboReaderStateCd.TabIndex = 4
            Me.cboReaderStateCd.Tag = "code(구독상태코드|전체);"
            Me.cboReaderStateCd.TextValue = ""
            '
            'cboExpandDivCd
            '
            Me.cboExpandDivCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboExpandDivCd.CaptionName = "확장구분코드"
            Me.cboExpandDivCd.Enabled = False
            Me.cboExpandDivCd.ListCount = 0
            Me.cboExpandDivCd.Location = New System.Drawing.Point(482, 11)
            Me.cboExpandDivCd.Name = "cboExpandDivCd"
            Me.cboExpandDivCd.ReadOnlys = False
            Me.cboExpandDivCd.Size = New System.Drawing.Size(111, 20)
            Me.cboExpandDivCd.TabIndex = 3
            Me.cboExpandDivCd.Tag = "read();init(1);code(확장구분코드|전체)"
            Me.cboExpandDivCd.TextValue = ""
            '
            'popCompanyCd_R
            '
            Me.popCompanyCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd_R.BorderStyle = 2
            Me.popCompanyCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd_R.CaptionName = "확장처 코드"
            Me.popCompanyCd_R.CodeText = ""
            Me.popCompanyCd_R.CodeWidth = 90
            Me.popCompanyCd_R.Location = New System.Drawing.Point(85, 34)
            Me.popCompanyCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCompanyCd_R.MaxLength = 32767
            Me.popCompanyCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd_R.Name = "popCompanyCd_R"
            Me.popCompanyCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd_R.NameText = ""
            Me.popCompanyCd_R.ReadOnlys = False
            Me.popCompanyCd_R.SelectedText = ""
            Me.popCompanyCd_R.SelectionLength = 0
            Me.popCompanyCd_R.SelectionStart = 0
            Me.popCompanyCd_R.Size = New System.Drawing.Size(323, 20)
            Me.popCompanyCd_R.TabIndex = 5
            Me.popCompanyCd_R.Tag = "code(확장처 명);"
            Me.popCompanyCd_R.TextAlign = 0
            Me.popCompanyCd_R.TextValue = ""
            Me.popCompanyCd_R.ToolTipText = ""
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(17, 34)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(61, 20)
            Me.lblBranchNm.TabIndex = 12
            Me.lblBranchNm.Text = "확장처"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(410, 96)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(90, 26)
            Me.btnApprovalAll.TabIndex = 12
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'picCriteria2
            '
            Me.picCriteria2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria2.Location = New System.Drawing.Point(6, 90)
            Me.picCriteria2.Name = "picCriteria2"
            Me.picCriteria2.Size = New System.Drawing.Size(801, 38)
            Me.picCriteria2.TabIndex = 1691
            Me.picCriteria2.TabStop = False
            '
            'cboReaderStateCd_E
            '
            Me.cboReaderStateCd_E.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.cboReaderStateCd_E.CaptionName = "구독상태코드"
            Me.cboReaderStateCd_E.ListCount = 0
            Me.cboReaderStateCd_E.Location = New System.Drawing.Point(94, 99)
            Me.cboReaderStateCd_E.Name = "cboReaderStateCd_E"
            Me.cboReaderStateCd_E.ReadOnlys = False
            Me.cboReaderStateCd_E.Size = New System.Drawing.Size(114, 20)
            Me.cboReaderStateCd_E.TabIndex = 10
            Me.cboReaderStateCd_E.Tag = "code(구독상태코드);"
            Me.cboReaderStateCd_E.TextValue = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(23, 102)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 15)
            Me.Label5.TabIndex = 25
            Me.Label5.Text = "구독상태"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpRealEdDt
            '
            Me.dtpRealEdDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRealEdDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpRealEdDt.BorderStyle = 2
            Me.dtpRealEdDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRealEdDt.CaptionName = "접수 일자 2"
            Me.dtpRealEdDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRealEdDt.Location = New System.Drawing.Point(298, 99)
            Me.dtpRealEdDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRealEdDt.MaxLength = 0
            Me.dtpRealEdDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRealEdDt.Name = "dtpRealEdDt"
            Me.dtpRealEdDt.ReadOnlys = False
            Me.dtpRealEdDt.SelectedText = ""
            Me.dtpRealEdDt.SelectionLength = 0
            Me.dtpRealEdDt.SelectionStart = 0
            Me.dtpRealEdDt.Size = New System.Drawing.Size(93, 20)
            Me.dtpRealEdDt.TabIndex = 11
            Me.dtpRealEdDt.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpRealEdDt.TextAlign = 0
            Me.dtpRealEdDt.TextValue = ""
            Me.dtpRealEdDt.ToolTipText = ""
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Location = New System.Drawing.Point(227, 102)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(65, 15)
            Me.Label10.TabIndex = 1693
            Me.Label10.Text = "중지일자"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNC205
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.dtpRealEdDt)
            Me.Controls.Add(Me.cboReaderStateCd_E)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.popCompanyCd_R)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.cboReaderStateCd)
            Me.Controls.Add(Me.cboExpandDivCd)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpReceiptDtFrom)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpReceiptDtTo)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.Label33)
            Me.Controls.Add(Me.txtPhoneNum_2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.popDeliveryBranchCd_2)
            Me.Controls.Add(Me.lblFormDivisionCode)
            Me.Controls.Add(Me.txtAddr_2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtSubscriberNm_2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtReceiptCd_2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria2)
            Me.Name = "PNC205"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria2, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.txtReceiptCd_2, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.txtSubscriberNm_2, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.txtAddr_2, 0)
            Me.Controls.SetChildIndex(Me.lblFormDivisionCode, 0)
            Me.Controls.SetChildIndex(Me.popDeliveryBranchCd_2, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.txtPhoneNum_2, 0)
            Me.Controls.SetChildIndex(Me.Label33, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtFrom, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.cboExpandDivCd, 0)
            Me.Controls.SetChildIndex(Me.cboReaderStateCd, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.cboReaderStateCd_E, 0)
            Me.Controls.SetChildIndex(Me.dtpRealEdDt, 0)
            Me.Controls.SetChildIndex(Me.Label10, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtAddr_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtSubscriberNm_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtReceiptCd_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents popDeliveryBranchCd_2 As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cboReaderStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents cboExpandDivCd As ubiLease.CommonControls.cbo
        Friend WithEvents popCompanyCd_R As ubiLease.CommonControls.pop
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button
        Friend WithEvents picCriteria2 As System.Windows.Forms.PictureBox
        Friend WithEvents cboReaderStateCd_E As ubiLease.CommonControls.cbo
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpRealEdDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label10 As System.Windows.Forms.Label


    End Class

End Namespace
