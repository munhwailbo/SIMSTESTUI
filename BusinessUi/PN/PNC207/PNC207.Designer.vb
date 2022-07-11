Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC207
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC207))
            Me.txtSubscriberNm_2 = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
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
            Me.lblReaderStateCd_R = New System.Windows.Forms.Label
            Me.cboReaderStateCd = New ubiLease.CommonControls.cbo
            Me.cboExpandDivCd = New ubiLease.CommonControls.cbo
            Me.popCompanyCd_R = New ubiLease.CommonControls.pop
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.dtpRealEdDtFrom = New ubiLease.CommonControls.dtp
            Me.Label9 = New System.Windows.Forms.Label
            Me.dtpRealEdDtTo = New ubiLease.CommonControls.dtp
            Me.Label10 = New System.Windows.Forms.Label
            Me.txtPhoneNum_2 = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtSubscriberNm_2
            '
            Me.txtSubscriberNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm_2.BorderStyle = 2
            Me.txtSubscriberNm_2.CaptionName = Nothing
            Me.txtSubscriberNm_2.Location = New System.Drawing.Point(85, 78)
            Me.txtSubscriberNm_2.MaxLength = 32767
            Me.txtSubscriberNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm_2.Multiline = False
            Me.txtSubscriberNm_2.Name = "txtSubscriberNm_2"
            Me.txtSubscriberNm_2.ReadOnlys = False
            Me.txtSubscriberNm_2.SelectedText = ""
            Me.txtSubscriberNm_2.SelectionLength = 0
            Me.txtSubscriberNm_2.SelectionStart = 0
            Me.txtSubscriberNm_2.Size = New System.Drawing.Size(134, 20)
            Me.txtSubscriberNm_2.TabIndex = 8
            Me.txtSubscriberNm_2.Tag = Nothing
            Me.txtSubscriberNm_2.TextAlign = 0
            Me.txtSubscriberNm_2.TextValue = ""
            Me.txtSubscriberNm_2.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(17, 81)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 15)
            Me.Label3.TabIndex = 22
            Me.Label3.Text = "독자명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 100)
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
            Me.grd_1.Location = New System.Drawing.Point(6, 109)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 534)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 15
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
            Me.popEmployeeNumber.Location = New System.Drawing.Point(485, 55)
            Me.popEmployeeNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeNumber.MaxLength = 6
            Me.popEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeNumber.Name = "popEmployeeNumber"
            Me.popEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeNumber.NameText = ""
            Me.popEmployeeNumber.ReadOnlys = False
            Me.popEmployeeNumber.SelectedText = ""
            Me.popEmployeeNumber.SelectionLength = 0
            Me.popEmployeeNumber.SelectionStart = 0
            Me.popEmployeeNumber.Size = New System.Drawing.Size(150, 20)
            Me.popEmployeeNumber.TabIndex = 13
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
            Me.popDeliveryBranchCd_2.Location = New System.Drawing.Point(85, 55)
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
            Me.popDeliveryBranchCd_2.Size = New System.Drawing.Size(314, 20)
            Me.popDeliveryBranchCd_2.TabIndex = 11
            Me.popDeliveryBranchCd_2.Tag = "code(지국코드);"
            Me.popDeliveryBranchCd_2.TextAlign = 0
            Me.popDeliveryBranchCd_2.TextValue = ""
            Me.popDeliveryBranchCd_2.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(414, 58)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(65, 15)
            Me.Label33.TabIndex = 27
            Me.Label33.Text = "담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(17, 58)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(61, 15)
            Me.lblFormDivisionCode.TabIndex = 25
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
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(85, 9)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(91, 20)
            Me.dtpReceiptDtFrom.TabIndex = 0
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(178, 12)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(12, 15)
            Me.Label6.TabIndex = 17
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
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(191, 9)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(91, 20)
            Me.dtpReceiptDtTo.TabIndex = 1
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(17, 12)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(61, 15)
            Me.Label8.TabIndex = 16
            Me.Label8.Text = "접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(414, 35)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(65, 15)
            Me.Label7.TabIndex = 18
            Me.Label7.Text = "확장구분"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblReaderStateCd_R
            '
            Me.lblReaderStateCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderStateCd_R.Location = New System.Drawing.Point(619, 35)
            Me.lblReaderStateCd_R.Name = "lblReaderStateCd_R"
            Me.lblReaderStateCd_R.Size = New System.Drawing.Size(57, 15)
            Me.lblReaderStateCd_R.TabIndex = 21
            Me.lblReaderStateCd_R.Text = "구독상태"
            Me.lblReaderStateCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboReaderStateCd
            '
            Me.cboReaderStateCd.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.cboReaderStateCd.CaptionName = "구독상태코드"
            Me.cboReaderStateCd.ListCount = 0
            Me.cboReaderStateCd.Location = New System.Drawing.Point(678, 32)
            Me.cboReaderStateCd.Name = "cboReaderStateCd"
            Me.cboReaderStateCd.ReadOnlys = False
            Me.cboReaderStateCd.Size = New System.Drawing.Size(111, 20)
            Me.cboReaderStateCd.TabIndex = 7
            Me.cboReaderStateCd.Tag = "code(구독상태코드|전체);"
            Me.cboReaderStateCd.TextValue = ""
            '
            'cboExpandDivCd
            '
            Me.cboExpandDivCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboExpandDivCd.CaptionName = "확장구분코드"
            Me.cboExpandDivCd.Enabled = False
            Me.cboExpandDivCd.ListCount = 0
            Me.cboExpandDivCd.Location = New System.Drawing.Point(485, 32)
            Me.cboExpandDivCd.Name = "cboExpandDivCd"
            Me.cboExpandDivCd.ReadOnlys = False
            Me.cboExpandDivCd.Size = New System.Drawing.Size(111, 20)
            Me.cboExpandDivCd.TabIndex = 2
            Me.cboExpandDivCd.Tag = "code(확장구분코드|전체)"
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
            Me.popCompanyCd_R.Location = New System.Drawing.Point(85, 32)
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
            Me.popCompanyCd_R.Size = New System.Drawing.Size(314, 20)
            Me.popCompanyCd_R.TabIndex = 5
            Me.popCompanyCd_R.Tag = "code(확장처 명);"
            Me.popCompanyCd_R.TextAlign = 0
            Me.popCompanyCd_R.TextValue = ""
            Me.popCompanyCd_R.ToolTipText = ""
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(13, 32)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(65, 20)
            Me.lblBranchNm.TabIndex = 19
            Me.lblBranchNm.Text = "확장처"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpRealEdDtFrom
            '
            Me.dtpRealEdDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRealEdDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpRealEdDtFrom.BorderStyle = 2
            Me.dtpRealEdDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRealEdDtFrom.CaptionName = "중지 일자"
            Me.dtpRealEdDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRealEdDtFrom.Location = New System.Drawing.Point(485, 9)
            Me.dtpRealEdDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRealEdDtFrom.MaxLength = 0
            Me.dtpRealEdDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRealEdDtFrom.Name = "dtpRealEdDtFrom"
            Me.dtpRealEdDtFrom.ReadOnlys = False
            Me.dtpRealEdDtFrom.SelectedText = ""
            Me.dtpRealEdDtFrom.SelectionLength = 0
            Me.dtpRealEdDtFrom.SelectionStart = 0
            Me.dtpRealEdDtFrom.Size = New System.Drawing.Size(91, 20)
            Me.dtpRealEdDtFrom.TabIndex = 1200
            Me.dtpRealEdDtFrom.Tag = "format(####-##-##);"
            Me.dtpRealEdDtFrom.TextAlign = 0
            Me.dtpRealEdDtFrom.TextValue = ""
            Me.dtpRealEdDtFrom.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(578, 12)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(12, 15)
            Me.Label9.TabIndex = 1203
            Me.Label9.Text = "~"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpRealEdDtTo
            '
            Me.dtpRealEdDtTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRealEdDtTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpRealEdDtTo.BorderStyle = 2
            Me.dtpRealEdDtTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRealEdDtTo.CaptionName = "중지 일자 2"
            Me.dtpRealEdDtTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRealEdDtTo.Location = New System.Drawing.Point(591, 9)
            Me.dtpRealEdDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRealEdDtTo.MaxLength = 0
            Me.dtpRealEdDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRealEdDtTo.Name = "dtpRealEdDtTo"
            Me.dtpRealEdDtTo.ReadOnlys = False
            Me.dtpRealEdDtTo.SelectedText = ""
            Me.dtpRealEdDtTo.SelectionLength = 0
            Me.dtpRealEdDtTo.SelectionStart = 0
            Me.dtpRealEdDtTo.Size = New System.Drawing.Size(91, 20)
            Me.dtpRealEdDtTo.TabIndex = 1201
            Me.dtpRealEdDtTo.Tag = "format(&&&&-&&-&&);"
            Me.dtpRealEdDtTo.TextAlign = 0
            Me.dtpRealEdDtTo.TextValue = ""
            Me.dtpRealEdDtTo.ToolTipText = ""
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Location = New System.Drawing.Point(417, 12)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 15)
            Me.Label10.TabIndex = 1202
            Me.Label10.Text = "중지일자"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum_2
            '
            Me.txtPhoneNum_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum_2.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum_2.BorderStyle = 2
            Me.txtPhoneNum_2.CaptionName = "전화번호1"
            Me.txtPhoneNum_2.Location = New System.Drawing.Point(289, 78)
            Me.txtPhoneNum_2.MaxLength = 14
            Me.txtPhoneNum_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum_2.Multiline = False
            Me.txtPhoneNum_2.Name = "txtPhoneNum_2"
            Me.txtPhoneNum_2.ReadOnlys = False
            Me.txtPhoneNum_2.SelectedText = ""
            Me.txtPhoneNum_2.SelectionLength = 0
            Me.txtPhoneNum_2.SelectionStart = 0
            Me.txtPhoneNum_2.Size = New System.Drawing.Size(110, 20)
            Me.txtPhoneNum_2.TabIndex = 9
            Me.txtPhoneNum_2.Tag = ""
            Me.txtPhoneNum_2.TextAlign = 0
            Me.txtPhoneNum_2.TextValue = ""
            Me.txtPhoneNum_2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(226, 81)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 15)
            Me.Label2.TabIndex = 23
            Me.Label2.Text = "전화번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNC207
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpRealEdDtFrom)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.dtpRealEdDtTo)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.popCompanyCd_R)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.cboReaderStateCd)
            Me.Controls.Add(Me.cboExpandDivCd)
            Me.Controls.Add(Me.lblReaderStateCd_R)
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
            Me.Controls.Add(Me.txtSubscriberNm_2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNC207"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.txtSubscriberNm_2, 0)
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
            Me.Controls.SetChildIndex(Me.lblReaderStateCd_R, 0)
            Me.Controls.SetChildIndex(Me.cboExpandDivCd, 0)
            Me.Controls.SetChildIndex(Me.cboReaderStateCd, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label10, 0)
            Me.Controls.SetChildIndex(Me.dtpRealEdDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.dtpRealEdDtFrom, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtSubscriberNm_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
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
        Friend WithEvents lblReaderStateCd_R As System.Windows.Forms.Label
        Friend WithEvents cboReaderStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents cboExpandDivCd As ubiLease.CommonControls.cbo
        Friend WithEvents popCompanyCd_R As ubiLease.CommonControls.pop
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents dtpRealEdDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents dtpRealEdDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label


    End Class

End Namespace
