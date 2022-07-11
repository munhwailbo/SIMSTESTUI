Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC206
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC206))
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
            Me.lblReaderStateCd_R = New System.Windows.Forms.Label
            Me.cboReaderStateCd = New ubiLease.CommonControls.cbo
            Me.chkState2 = New ubiLease.CommonControls.chk
            Me.chkState1 = New ubiLease.CommonControls.chk
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtAddr_2
            '
            Me.txtAddr_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddr_2.BorderColor = System.Drawing.Color.Empty
            Me.txtAddr_2.BorderStyle = 2
            Me.txtAddr_2.CaptionName = "주소"
            Me.txtAddr_2.Location = New System.Drawing.Point(526, 38)
            Me.txtAddr_2.MaxLength = 12
            Me.txtAddr_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddr_2.Multiline = False
            Me.txtAddr_2.Name = "txtAddr_2"
            Me.txtAddr_2.ReadOnlys = False
            Me.txtAddr_2.SelectedText = ""
            Me.txtAddr_2.SelectionLength = 0
            Me.txtAddr_2.SelectionStart = 0
            Me.txtAddr_2.Size = New System.Drawing.Size(273, 20)
            Me.txtAddr_2.TabIndex = 7
            Me.txtAddr_2.Tag = ""
            Me.txtAddr_2.TextAlign = 0
            Me.txtAddr_2.TextValue = ""
            Me.txtAddr_2.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(465, 41)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 15)
            Me.Label1.TabIndex = 16
            Me.Label1.Text = "토요주소"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum_2
            '
            Me.txtPhoneNum_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum_2.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum_2.BorderStyle = 2
            Me.txtPhoneNum_2.CaptionName = "전화번호1"
            Me.txtPhoneNum_2.Location = New System.Drawing.Point(350, 38)
            Me.txtPhoneNum_2.MaxLength = 14
            Me.txtPhoneNum_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum_2.Multiline = False
            Me.txtPhoneNum_2.Name = "txtPhoneNum_2"
            Me.txtPhoneNum_2.ReadOnlys = False
            Me.txtPhoneNum_2.SelectedText = ""
            Me.txtPhoneNum_2.SelectionLength = 0
            Me.txtPhoneNum_2.SelectionStart = 0
            Me.txtPhoneNum_2.Size = New System.Drawing.Size(110, 20)
            Me.txtPhoneNum_2.TabIndex = 6
            Me.txtPhoneNum_2.Tag = ""
            Me.txtPhoneNum_2.TextAlign = 0
            Me.txtPhoneNum_2.TextValue = ""
            Me.txtPhoneNum_2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(269, 41)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(78, 15)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "토요전화번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSubscriberNm_2
            '
            Me.txtSubscriberNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm_2.BorderStyle = 2
            Me.txtSubscriberNm_2.CaptionName = Nothing
            Me.txtSubscriberNm_2.Location = New System.Drawing.Point(113, 38)
            Me.txtSubscriberNm_2.MaxLength = 32767
            Me.txtSubscriberNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm_2.Multiline = False
            Me.txtSubscriberNm_2.Name = "txtSubscriberNm_2"
            Me.txtSubscriberNm_2.ReadOnlys = False
            Me.txtSubscriberNm_2.SelectedText = ""
            Me.txtSubscriberNm_2.SelectionLength = 0
            Me.txtSubscriberNm_2.SelectionStart = 0
            Me.txtSubscriberNm_2.Size = New System.Drawing.Size(150, 20)
            Me.txtSubscriberNm_2.TabIndex = 5
            Me.txtSubscriberNm_2.Tag = Nothing
            Me.txtSubscriberNm_2.TextAlign = 0
            Me.txtSubscriberNm_2.TextValue = ""
            Me.txtSubscriberNm_2.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(28, 41)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 15)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "토요독자명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReceiptCd_2
            '
            Me.txtReceiptCd_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtReceiptCd_2.BorderColor = System.Drawing.Color.Empty
            Me.txtReceiptCd_2.BorderStyle = 2
            Me.txtReceiptCd_2.CaptionName = Nothing
            Me.txtReceiptCd_2.Location = New System.Drawing.Point(350, 61)
            Me.txtReceiptCd_2.MaxLength = 32767
            Me.txtReceiptCd_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReceiptCd_2.Multiline = False
            Me.txtReceiptCd_2.Name = "txtReceiptCd_2"
            Me.txtReceiptCd_2.ReadOnlys = False
            Me.txtReceiptCd_2.SelectedText = ""
            Me.txtReceiptCd_2.SelectionLength = 0
            Me.txtReceiptCd_2.SelectionStart = 0
            Me.txtReceiptCd_2.Size = New System.Drawing.Size(110, 20)
            Me.txtReceiptCd_2.TabIndex = 9
            Me.txtReceiptCd_2.Tag = Nothing
            Me.txtReceiptCd_2.TextAlign = 0
            Me.txtReceiptCd_2.TextValue = ""
            Me.txtReceiptCd_2.ToolTipText = ""
            Me.txtReceiptCd_2.Visible = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(269, 63)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(78, 16)
            Me.Label4.TabIndex = 18
            Me.Label4.Text = "독자코드"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label4.Visible = False
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 86)
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
            Me.grd_1.Location = New System.Drawing.Point(6, 95)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 548)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 20
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
            Me.popEmployeeNumber.Location = New System.Drawing.Point(113, 61)
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
            Me.popDeliveryBranchCd_2.Location = New System.Drawing.Point(526, 61)
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
            Me.popDeliveryBranchCd_2.Size = New System.Drawing.Size(198, 20)
            Me.popDeliveryBranchCd_2.TabIndex = 10
            Me.popDeliveryBranchCd_2.Tag = "code(지국코드);"
            Me.popDeliveryBranchCd_2.TextAlign = 0
            Me.popDeliveryBranchCd_2.TextValue = ""
            Me.popDeliveryBranchCd_2.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(28, 64)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(81, 15)
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "토요영업담당"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(465, 64)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(57, 15)
            Me.lblFormDivisionCode.TabIndex = 19
            Me.lblFormDivisionCode.Text = "토요지국"
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
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(113, 16)
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
            Me.Label6.Location = New System.Drawing.Point(206, 19)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(12, 15)
            Me.Label6.TabIndex = 12
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
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(219, 16)
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
            Me.Label8.Location = New System.Drawing.Point(28, 17)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(81, 15)
            Me.Label8.TabIndex = 11
            Me.Label8.Text = "토요접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblReaderStateCd_R
            '
            Me.lblReaderStateCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderStateCd_R.Location = New System.Drawing.Point(433, 14)
            Me.lblReaderStateCd_R.Name = "lblReaderStateCd_R"
            Me.lblReaderStateCd_R.Size = New System.Drawing.Size(57, 15)
            Me.lblReaderStateCd_R.TabIndex = 13
            Me.lblReaderStateCd_R.Text = "구독상태"
            Me.lblReaderStateCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblReaderStateCd_R.Visible = False
            '
            'cboReaderStateCd
            '
            Me.cboReaderStateCd.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.cboReaderStateCd.CaptionName = "구독상태코드"
            Me.cboReaderStateCd.ListCount = 0
            Me.cboReaderStateCd.Location = New System.Drawing.Point(492, 11)
            Me.cboReaderStateCd.Name = "cboReaderStateCd"
            Me.cboReaderStateCd.ReadOnlys = False
            Me.cboReaderStateCd.Size = New System.Drawing.Size(111, 20)
            Me.cboReaderStateCd.TabIndex = 2
            Me.cboReaderStateCd.Tag = "code(구독상태코드|전체);"
            Me.cboReaderStateCd.TextValue = ""
            Me.cboReaderStateCd.Visible = False
            '
            'chkState2
            '
            Me.chkState2.AutoSize = True
            Me.chkState2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkState2.CaptionName = "중지독자"
            Me.chkState2.Enabled = False
            Me.chkState2.Location = New System.Drawing.Point(717, 13)
            Me.chkState2.Name = "chkState2"
            Me.chkState2.ReadOnlys = False
            Me.chkState2.Size = New System.Drawing.Size(72, 16)
            Me.chkState2.TabIndex = 4
            Me.chkState2.Tag = Nothing
            Me.chkState2.Text = "중지독자"
            Me.chkState2.TextValue = "0"
            Me.chkState2.UseVisualStyleBackColor = False
            Me.chkState2.Visible = False
            '
            'chkState1
            '
            Me.chkState1.AutoSize = True
            Me.chkState1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkState1.CaptionName = "구독독자"
            Me.chkState1.Enabled = False
            Me.chkState1.Location = New System.Drawing.Point(621, 13)
            Me.chkState1.Name = "chkState1"
            Me.chkState1.ReadOnlys = False
            Me.chkState1.Size = New System.Drawing.Size(72, 16)
            Me.chkState1.TabIndex = 3
            Me.chkState1.Tag = Nothing
            Me.chkState1.Text = "구독독자"
            Me.chkState1.TextValue = "0"
            Me.chkState1.UseVisualStyleBackColor = False
            Me.chkState1.Visible = False
            '
            'PNC206
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkState1)
            Me.Controls.Add(Me.chkState2)
            Me.Controls.Add(Me.cboReaderStateCd)
            Me.Controls.Add(Me.lblReaderStateCd_R)
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
            Me.Name = "PNC206"
            Me.Size = New System.Drawing.Size(811, 647)
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
            Me.Controls.SetChildIndex(Me.lblReaderStateCd_R, 0)
            Me.Controls.SetChildIndex(Me.cboReaderStateCd, 0)
            Me.Controls.SetChildIndex(Me.chkState2, 0)
            Me.Controls.SetChildIndex(Me.chkState1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

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
        Friend WithEvents lblReaderStateCd_R As System.Windows.Forms.Label
        Friend WithEvents cboReaderStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents chkState2 As ubiLease.CommonControls.chk
        Friend WithEvents chkState1 As ubiLease.CommonControls.chk


    End Class

End Namespace
