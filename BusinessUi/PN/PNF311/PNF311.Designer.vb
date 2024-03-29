Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNF311
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNF311))
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.txtPhoneNum_2 = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.popDeliveryBranchCd_2 = New ubiLease.CommonControls.pop
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            Me.txtAddr_2 = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtSubscriberNm_2 = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtReceiptCd_2 = New ubiLease.CommonControls.txt
            Me.Label4 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label25 = New System.Windows.Forms.Label
            Me.cboMonitoringResultCd_r = New ubiLease.CommonControls.cbo
            Me.btnPRB002 = New ubiLease.CommonControls.btn
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpReceiptDtFrom
            '
            Me.dtpReceiptDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtFrom.BorderStyle = 2
            Me.dtpReceiptDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtFrom.CaptionName = "접수 일자"
            Me.dtpReceiptDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(84, 11)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtFrom.TabIndex = 1568
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(174, 13)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 1571
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
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(195, 11)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtTo.TabIndex = 1569
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(16, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(61, 15)
            Me.Label8.TabIndex = 1570
            Me.Label8.Text = "접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "담당자"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(638, 56)
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
            Me.popEmployeeNumber.TabIndex = 1559
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(568, 59)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(65, 15)
            Me.Label33.TabIndex = 1567
            Me.Label33.Text = "담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum_2
            '
            Me.txtPhoneNum_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum_2.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum_2.BorderStyle = 2
            Me.txtPhoneNum_2.CaptionName = "전화번호1"
            Me.txtPhoneNum_2.Location = New System.Drawing.Point(291, 33)
            Me.txtPhoneNum_2.MaxLength = 14
            Me.txtPhoneNum_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum_2.Multiline = False
            Me.txtPhoneNum_2.Name = "txtPhoneNum_2"
            Me.txtPhoneNum_2.ReadOnlys = False
            Me.txtPhoneNum_2.SelectedText = ""
            Me.txtPhoneNum_2.SelectionLength = 0
            Me.txtPhoneNum_2.SelectionStart = 0
            Me.txtPhoneNum_2.Size = New System.Drawing.Size(115, 20)
            Me.txtPhoneNum_2.TabIndex = 1555
            Me.txtPhoneNum_2.Tag = ""
            Me.txtPhoneNum_2.TextAlign = 0
            Me.txtPhoneNum_2.TextValue = ""
            Me.txtPhoneNum_2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(220, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 15)
            Me.Label2.TabIndex = 1564
            Me.Label2.Text = "전화번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popDeliveryBranchCd_2
            '
            Me.popDeliveryBranchCd_2.BorderColor = System.Drawing.Color.Empty
            Me.popDeliveryBranchCd_2.BorderStyle = 2
            Me.popDeliveryBranchCd_2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeliveryBranchCd_2.CaptionName = "지사지국 코드"
            Me.popDeliveryBranchCd_2.CodeText = ""
            Me.popDeliveryBranchCd_2.CodeWidth = 60
            Me.popDeliveryBranchCd_2.Location = New System.Drawing.Point(84, 56)
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
            Me.popDeliveryBranchCd_2.Size = New System.Drawing.Size(322, 20)
            Me.popDeliveryBranchCd_2.TabIndex = 1557
            Me.popDeliveryBranchCd_2.Tag = "code(지국코드);"
            Me.popDeliveryBranchCd_2.TextAlign = 0
            Me.popDeliveryBranchCd_2.TextValue = ""
            Me.popDeliveryBranchCd_2.ToolTipText = ""
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(16, 59)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(61, 15)
            Me.lblFormDivisionCode.TabIndex = 1566
            Me.lblFormDivisionCode.Text = "지사지국"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAddr_2
            '
            Me.txtAddr_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddr_2.BorderColor = System.Drawing.Color.Empty
            Me.txtAddr_2.BorderStyle = 2
            Me.txtAddr_2.CaptionName = "주소"
            Me.txtAddr_2.Location = New System.Drawing.Point(481, 33)
            Me.txtAddr_2.MaxLength = 12
            Me.txtAddr_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddr_2.Multiline = False
            Me.txtAddr_2.Name = "txtAddr_2"
            Me.txtAddr_2.ReadOnlys = False
            Me.txtAddr_2.SelectedText = ""
            Me.txtAddr_2.SelectionLength = 0
            Me.txtAddr_2.SelectionStart = 0
            Me.txtAddr_2.Size = New System.Drawing.Size(307, 20)
            Me.txtAddr_2.TabIndex = 1556
            Me.txtAddr_2.Tag = ""
            Me.txtAddr_2.TextAlign = 0
            Me.txtAddr_2.TextValue = ""
            Me.txtAddr_2.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(421, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 15)
            Me.Label1.TabIndex = 1565
            Me.Label1.Text = "주소"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSubscriberNm_2
            '
            Me.txtSubscriberNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm_2.BorderStyle = 2
            Me.txtSubscriberNm_2.CaptionName = Nothing
            Me.txtSubscriberNm_2.Location = New System.Drawing.Point(84, 33)
            Me.txtSubscriberNm_2.MaxLength = 32767
            Me.txtSubscriberNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm_2.Multiline = False
            Me.txtSubscriberNm_2.Name = "txtSubscriberNm_2"
            Me.txtSubscriberNm_2.ReadOnlys = False
            Me.txtSubscriberNm_2.SelectedText = ""
            Me.txtSubscriberNm_2.SelectionLength = 0
            Me.txtSubscriberNm_2.SelectionStart = 0
            Me.txtSubscriberNm_2.Size = New System.Drawing.Size(134, 20)
            Me.txtSubscriberNm_2.TabIndex = 1554
            Me.txtSubscriberNm_2.Tag = Nothing
            Me.txtSubscriberNm_2.TextAlign = 0
            Me.txtSubscriberNm_2.TextValue = ""
            Me.txtSubscriberNm_2.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(16, 36)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 15)
            Me.Label3.TabIndex = 1563
            Me.Label3.Text = "독자명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReceiptCd_2
            '
            Me.txtReceiptCd_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtReceiptCd_2.BorderColor = System.Drawing.Color.Empty
            Me.txtReceiptCd_2.BorderStyle = 2
            Me.txtReceiptCd_2.CaptionName = Nothing
            Me.txtReceiptCd_2.Location = New System.Drawing.Point(481, 56)
            Me.txtReceiptCd_2.MaxLength = 32767
            Me.txtReceiptCd_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReceiptCd_2.Multiline = False
            Me.txtReceiptCd_2.Name = "txtReceiptCd_2"
            Me.txtReceiptCd_2.ReadOnlys = False
            Me.txtReceiptCd_2.SelectedText = ""
            Me.txtReceiptCd_2.SelectionLength = 0
            Me.txtReceiptCd_2.SelectionStart = 0
            Me.txtReceiptCd_2.Size = New System.Drawing.Size(83, 20)
            Me.txtReceiptCd_2.TabIndex = 1558
            Me.txtReceiptCd_2.Tag = Nothing
            Me.txtReceiptCd_2.TextAlign = 0
            Me.txtReceiptCd_2.TextValue = ""
            Me.txtReceiptCd_2.ToolTipText = ""
            Me.txtReceiptCd_2.Visible = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(422, 58)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(56, 16)
            Me.Label4.TabIndex = 1562
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
            Me.picCriteria.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 80)
            Me.picCriteria.TabIndex = 1561
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
            Me.grd_1.Location = New System.Drawing.Point(5, 90)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 503)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1560
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label25.Location = New System.Drawing.Point(407, 13)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(70, 15)
            Me.Label25.TabIndex = 1573
            Me.Label25.Text = "모니터상태"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label25.Visible = False
            '
            'cboMonitoringResultCd_r
            '
            Me.cboMonitoringResultCd_r.CaptionName = "모니터 결과"
            Me.cboMonitoringResultCd_r.ListCount = 0
            Me.cboMonitoringResultCd_r.Location = New System.Drawing.Point(481, 11)
            Me.cboMonitoringResultCd_r.Name = "cboMonitoringResultCd_r"
            Me.cboMonitoringResultCd_r.ReadOnlys = False
            Me.cboMonitoringResultCd_r.Size = New System.Drawing.Size(93, 20)
            Me.cboMonitoringResultCd_r.TabIndex = 1572
            Me.cboMonitoringResultCd_r.Tag = "code(모니터결과처리코드|전체);"
            Me.cboMonitoringResultCd_r.TextValue = ""
            Me.cboMonitoringResultCd_r.Visible = False
            '
            'btnPRB002
            '
            Me.btnPRB002.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnPRB002.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnPRB002.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnPRB002.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnPRB002.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnPRB002.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnPRB002.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnPRB002.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnPRB002.Location = New System.Drawing.Point(24, 601)
            Me.btnPRB002.Name = "btnPRB002"
            Me.btnPRB002.Size = New System.Drawing.Size(86, 39)
            Me.btnPRB002.TabIndex = 1574
            Me.btnPRB002.TabStop = False
            Me.btnPRB002.Text = "지국확장독자 접수 등록"
            Me.btnPRB002.UseVisualStyleBackColor = True
            '
            'picIo_1
            '
            Me.picIo_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(5, 596)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(801, 48)
            Me.picIo_1.TabIndex = 1575
            Me.picIo_1.TabStop = False
            '
            'PNF311
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnPRB002)
            Me.Controls.Add(Me.picIo_1)
            Me.Controls.Add(Me.Label25)
            Me.Controls.Add(Me.cboMonitoringResultCd_r)
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
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNF311"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popDeliveryBranchCd_2 As ubiLease.CommonControls.pop
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label
        Friend WithEvents txtAddr_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtSubscriberNm_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtReceiptCd_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents cboMonitoringResultCd_r As ubiLease.CommonControls.cbo
        Friend WithEvents btnPRB002 As ubiLease.CommonControls.btn
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox


    End Class

End Namespace
