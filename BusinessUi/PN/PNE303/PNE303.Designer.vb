Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE303
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE303))
            Me.btnExcelExport = New ubiLease.CommonControls.btn
            Me.optBranchDelivery = New System.Windows.Forms.RadioButton
            Me.optHeadOfficeDelivery = New System.Windows.Forms.RadioButton
            Me.optstop = New System.Windows.Forms.RadioButton
            Me.popBizChargeCd = New ubiLease.CommonControls.pop
            Me.optReceipt = New System.Windows.Forms.RadioButton
            Me.optMonitor = New System.Windows.Forms.RadioButton
            Me.Grd_3 = New ubiLease.GridControl.grd
            Me.Label15 = New System.Windows.Forms.Label
            Me.cboReaderInCd_r = New ubiLease.CommonControls.cbo
            Me.Label3 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.Label14 = New System.Windows.Forms.Label
            Me.dtpFixedEdDt = New ubiLease.CommonControls.dtp
            Me.txtSubscriberNm = New ubiLease.CommonControls.txt
            Me.PopDeliveryChnlNm = New ubiLease.CommonControls.pop
            Me.Label13 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.txtAdEmployeeNm = New ubiLease.CommonControls.txt
            Me.Label11 = New System.Windows.Forms.Label
            Me.CboMonitoringResultCd = New ubiLease.CommonControls.cbo
            Me.Label5 = New System.Windows.Forms.Label
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.popDeliveryBranchNm = New ubiLease.CommonControls.pop
            Me.txtDeptNm = New ubiLease.CommonControls.txt
            Me.cboCollectionTypeCd = New ubiLease.CommonControls.cbo
            Me.cboReaderStateCd = New ubiLease.CommonControls.cbo
            Me.cboBillTypeCd = New ubiLease.CommonControls.cbo
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.lbl확장처 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.Grd_1 = New ubiLease.GridControl.grd
            Me.Grd_2 = New ubiLease.GridControl.grd
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.grd_5 = New ubiLease.GridControl.grd
            Me.grd_4 = New ubiLease.GridControl.grd
            CType(Me.Grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnExcelExport
            '
            Me.btnExcelExport.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExcelExport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnExcelExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExcelExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnExcelExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnExcelExport.Location = New System.Drawing.Point(663, 167)
            Me.btnExcelExport.Name = "btnExcelExport"
            Me.btnExcelExport.Size = New System.Drawing.Size(92, 22)
            Me.btnExcelExport.TabIndex = 1722
            Me.btnExcelExport.Text = "엑셀 출력"
            Me.btnExcelExport.UseVisualStyleBackColor = True
            '
            'optBranchDelivery
            '
            Me.optBranchDelivery.AutoSize = True
            Me.optBranchDelivery.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optBranchDelivery.Location = New System.Drawing.Point(627, 136)
            Me.optBranchDelivery.Name = "optBranchDelivery"
            Me.optBranchDelivery.Size = New System.Drawing.Size(147, 16)
            Me.optBranchDelivery.TabIndex = 1698
            Me.optBranchDelivery.Text = "지국수금독자 배달확인"
            Me.optBranchDelivery.UseVisualStyleBackColor = False
            '
            'optHeadOfficeDelivery
            '
            Me.optHeadOfficeDelivery.AutoSize = True
            Me.optHeadOfficeDelivery.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optHeadOfficeDelivery.Location = New System.Drawing.Point(474, 136)
            Me.optHeadOfficeDelivery.Name = "optHeadOfficeDelivery"
            Me.optHeadOfficeDelivery.Size = New System.Drawing.Size(147, 16)
            Me.optHeadOfficeDelivery.TabIndex = 1697
            Me.optHeadOfficeDelivery.Text = "본사수금독자 배달확인"
            Me.optHeadOfficeDelivery.UseVisualStyleBackColor = False
            '
            'optstop
            '
            Me.optstop.AutoSize = True
            Me.optstop.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optstop.Location = New System.Drawing.Point(293, 136)
            Me.optstop.Name = "optstop"
            Me.optstop.Size = New System.Drawing.Size(175, 16)
            Me.optstop.TabIndex = 1696
            Me.optstop.Text = "본사 사원확장독자 배달통보"
            Me.optstop.UseVisualStyleBackColor = False
            '
            'popBizChargeCd
            '
            Me.popBizChargeCd.BorderColor = System.Drawing.Color.Empty
            Me.popBizChargeCd.BorderStyle = 2
            Me.popBizChargeCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBizChargeCd.CaptionName = "지국코드"
            Me.popBizChargeCd.CodeText = ""
            Me.popBizChargeCd.CodeWidth = 60
            Me.popBizChargeCd.Location = New System.Drawing.Point(571, 35)
            Me.popBizChargeCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBizChargeCd.MaxLength = 6
            Me.popBizChargeCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBizChargeCd.Name = "popBizChargeCd"
            Me.popBizChargeCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBizChargeCd.NameText = ""
            Me.popBizChargeCd.ReadOnlys = False
            Me.popBizChargeCd.SelectedText = ""
            Me.popBizChargeCd.SelectionLength = 0
            Me.popBizChargeCd.SelectionStart = 0
            Me.popBizChargeCd.Size = New System.Drawing.Size(226, 20)
            Me.popBizChargeCd.TabIndex = 1690
            Me.popBizChargeCd.Tag = "code(영업사원 명);"
            Me.popBizChargeCd.TextAlign = 0
            Me.popBizChargeCd.TextValue = ""
            Me.popBizChargeCd.ToolTipText = ""
            '
            'optReceipt
            '
            Me.optReceipt.AutoSize = True
            Me.optReceipt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optReceipt.Checked = True
            Me.optReceipt.Location = New System.Drawing.Point(19, 136)
            Me.optReceipt.Name = "optReceipt"
            Me.optReceipt.Size = New System.Drawing.Size(135, 16)
            Me.optReceipt.TabIndex = 1694
            Me.optReceipt.TabStop = True
            Me.optReceipt.Text = "사원확장독자 리스트"
            Me.optReceipt.UseVisualStyleBackColor = False
            '
            'optMonitor
            '
            Me.optMonitor.AutoSize = True
            Me.optMonitor.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMonitor.Location = New System.Drawing.Point(160, 136)
            Me.optMonitor.Name = "optMonitor"
            Me.optMonitor.Size = New System.Drawing.Size(127, 16)
            Me.optMonitor.TabIndex = 1695
            Me.optMonitor.Text = "타깃 사원확장 접수"
            Me.optMonitor.UseVisualStyleBackColor = False
            '
            'Grd_3
            '
            Me.Grd_3.AllowBigSelection = False
            Me.Grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.Grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.Grd_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.Grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.Grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.Grd_3.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.Grd_3.ExplorerBar = 0
            Me.Grd_3.ExtendLastCol = True
            Me.Grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.Grd_3.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.Grd_3.FrozenCols = 1
            Me.Grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.Grd_3.Location = New System.Drawing.Point(4, 199)
            Me.Grd_3.Name = "Grd_3"
            Me.Grd_3.NodeClosedPicture = Nothing
            Me.Grd_3.NodeOpenPicture = Nothing
            Me.Grd_3.OutlineCol = -1
            Me.Grd_3.RowHeightMax = 18
            Me.Grd_3.RowHeightMin = 15
            Me.Grd_3.Rows = 2
            Me.Grd_3.Size = New System.Drawing.Size(801, 443)
            Me.Grd_3.StyleInfo = resources.GetString("Grd_3.StyleInfo")
            Me.Grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.Grd_3.TabIndex = 1718
            Me.Grd_3.TreeColor = System.Drawing.Color.DarkGray
            Me.Grd_3.Visible = False
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(513, 14)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(54, 15)
            Me.Label15.TabIndex = 1717
            Me.Label15.Text = "독자상태"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboReaderInCd_r
            '
            Me.cboReaderInCd_r.CaptionName = "독자상태"
            Me.cboReaderInCd_r.ListCount = 0
            Me.cboReaderInCd_r.Location = New System.Drawing.Point(571, 12)
            Me.cboReaderInCd_r.Name = "cboReaderInCd_r"
            Me.cboReaderInCd_r.ReadOnlys = False
            Me.cboReaderInCd_r.Size = New System.Drawing.Size(118, 20)
            Me.cboReaderInCd_r.TabIndex = 1689
            Me.cboReaderInCd_r.Tag = "code(독자진행코드2|전체);"
            Me.cboReaderInCd_r.TextValue = ""
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label3.Location = New System.Drawing.Point(15, 166)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(782, 24)
            Me.Label3.TabIndex = 1715
            Me.Label3.Tag = "left"
            Me.Label3.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 163)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(800, 30)
            Me.PictureBox1.TabIndex = 1716
            Me.PictureBox1.TabStop = False
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label14.Location = New System.Drawing.Point(201, 103)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(77, 15)
            Me.Label14.TabIndex = 1714
            Me.Label14.Text = "구독종료일자"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpFixedEdDt
            '
            Me.dtpFixedEdDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFixedEdDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpFixedEdDt.BorderStyle = 2
            Me.dtpFixedEdDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFixedEdDt.CaptionName = "구독종료일자"
            Me.dtpFixedEdDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFixedEdDt.Location = New System.Drawing.Point(282, 100)
            Me.dtpFixedEdDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFixedEdDt.MaxLength = 0
            Me.dtpFixedEdDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFixedEdDt.Name = "dtpFixedEdDt"
            Me.dtpFixedEdDt.ReadOnlys = False
            Me.dtpFixedEdDt.SelectedText = ""
            Me.dtpFixedEdDt.SelectionLength = 0
            Me.dtpFixedEdDt.SelectionStart = 0
            Me.dtpFixedEdDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpFixedEdDt.TabIndex = 1688
            Me.dtpFixedEdDt.Tag = ""
            Me.dtpFixedEdDt.TextAlign = 0
            Me.dtpFixedEdDt.TextValue = ""
            Me.dtpFixedEdDt.ToolTipText = ""
            '
            'txtSubscriberNm
            '
            Me.txtSubscriberNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm.BorderStyle = 2
            Me.txtSubscriberNm.CaptionName = Nothing
            Me.txtSubscriberNm.Location = New System.Drawing.Point(571, 57)
            Me.txtSubscriberNm.MaxLength = 32767
            Me.txtSubscriberNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm.Multiline = False
            Me.txtSubscriberNm.Name = "txtSubscriberNm"
            Me.txtSubscriberNm.ReadOnlys = False
            Me.txtSubscriberNm.SelectedText = ""
            Me.txtSubscriberNm.SelectionLength = 0
            Me.txtSubscriberNm.SelectionStart = 0
            Me.txtSubscriberNm.Size = New System.Drawing.Size(226, 20)
            Me.txtSubscriberNm.TabIndex = 1691
            Me.txtSubscriberNm.Tag = Nothing
            Me.txtSubscriberNm.TextAlign = 0
            Me.txtSubscriberNm.TextValue = ""
            Me.txtSubscriberNm.ToolTipText = ""
            '
            'PopDeliveryChnlNm
            '
            Me.PopDeliveryChnlNm.BorderColor = System.Drawing.Color.Empty
            Me.PopDeliveryChnlNm.BorderStyle = 2
            Me.PopDeliveryChnlNm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopDeliveryChnlNm.CaptionName = "투입처코드"
            Me.PopDeliveryChnlNm.CodeText = ""
            Me.PopDeliveryChnlNm.CodeWidth = 60
            Me.PopDeliveryChnlNm.Location = New System.Drawing.Point(571, 100)
            Me.PopDeliveryChnlNm.MaximumSize = New System.Drawing.Size(800, 20)
            Me.PopDeliveryChnlNm.MaxLength = 7
            Me.PopDeliveryChnlNm.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopDeliveryChnlNm.Name = "PopDeliveryChnlNm"
            Me.PopDeliveryChnlNm.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopDeliveryChnlNm.NameText = ""
            Me.PopDeliveryChnlNm.ReadOnlys = False
            Me.PopDeliveryChnlNm.SelectedText = ""
            Me.PopDeliveryChnlNm.SelectionLength = 0
            Me.PopDeliveryChnlNm.SelectionStart = 0
            Me.PopDeliveryChnlNm.Size = New System.Drawing.Size(226, 20)
            Me.PopDeliveryChnlNm.TabIndex = 1693
            Me.PopDeliveryChnlNm.Tag = "code(투입처 명);"
            Me.PopDeliveryChnlNm.TextAlign = 0
            Me.PopDeliveryChnlNm.TextValue = ""
            Me.PopDeliveryChnlNm.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label13.Location = New System.Drawing.Point(514, 103)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(53, 15)
            Me.Label13.TabIndex = 1713
            Me.Label13.Text = "투입처"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.Location = New System.Drawing.Point(514, 60)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(53, 15)
            Me.Label12.TabIndex = 1712
            Me.Label12.Text = "독자명"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAdEmployeeNm
            '
            Me.txtAdEmployeeNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtAdEmployeeNm.BorderColor = System.Drawing.Color.Empty
            Me.txtAdEmployeeNm.BorderStyle = 2
            Me.txtAdEmployeeNm.CaptionName = Nothing
            Me.txtAdEmployeeNm.Location = New System.Drawing.Point(282, 57)
            Me.txtAdEmployeeNm.MaxLength = 32767
            Me.txtAdEmployeeNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAdEmployeeNm.Multiline = False
            Me.txtAdEmployeeNm.Name = "txtAdEmployeeNm"
            Me.txtAdEmployeeNm.ReadOnlys = False
            Me.txtAdEmployeeNm.SelectedText = ""
            Me.txtAdEmployeeNm.SelectionLength = 0
            Me.txtAdEmployeeNm.SelectionStart = 0
            Me.txtAdEmployeeNm.Size = New System.Drawing.Size(226, 20)
            Me.txtAdEmployeeNm.TabIndex = 1684
            Me.txtAdEmployeeNm.Tag = Nothing
            Me.txtAdEmployeeNm.TextAlign = 0
            Me.txtAdEmployeeNm.TextValue = ""
            Me.txtAdEmployeeNm.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(201, 58)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(77, 19)
            Me.Label11.TabIndex = 1711
            Me.Label11.Text = "보조권유자"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'CboMonitoringResultCd
            '
            Me.CboMonitoringResultCd.CaptionName = "모니터결과처리코드"
            Me.CboMonitoringResultCd.ListCount = 0
            Me.CboMonitoringResultCd.Location = New System.Drawing.Point(92, 57)
            Me.CboMonitoringResultCd.Name = "CboMonitoringResultCd"
            Me.CboMonitoringResultCd.ReadOnlys = False
            Me.CboMonitoringResultCd.Size = New System.Drawing.Size(100, 20)
            Me.CboMonitoringResultCd.TabIndex = 1683
            Me.CboMonitoringResultCd.Tag = "code(모니터결과처리코드,독자상태|전체);"
            Me.CboMonitoringResultCd.TextValue = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(17, 58)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(68, 18)
            Me.Label5.TabIndex = 1710
            Me.Label5.Text = "모니터통과"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "지국코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 60
            Me.popCompanyCd.Location = New System.Drawing.Point(571, 79)
            Me.popCompanyCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popCompanyCd.MaxLength = 7
            Me.popCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd.Name = "popCompanyCd"
            Me.popCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd.NameText = ""
            Me.popCompanyCd.ReadOnlys = False
            Me.popCompanyCd.SelectedText = ""
            Me.popCompanyCd.SelectionLength = 0
            Me.popCompanyCd.SelectionStart = 0
            Me.popCompanyCd.Size = New System.Drawing.Size(226, 20)
            Me.popCompanyCd.TabIndex = 1692
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'popDeliveryBranchNm
            '
            Me.popDeliveryBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.popDeliveryBranchNm.BorderStyle = 2
            Me.popDeliveryBranchNm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeliveryBranchNm.CaptionName = "지국코드"
            Me.popDeliveryBranchNm.CodeText = ""
            Me.popDeliveryBranchNm.CodeWidth = 60
            Me.popDeliveryBranchNm.Location = New System.Drawing.Point(282, 79)
            Me.popDeliveryBranchNm.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popDeliveryBranchNm.MaxLength = 7
            Me.popDeliveryBranchNm.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popDeliveryBranchNm.Name = "popDeliveryBranchNm"
            Me.popDeliveryBranchNm.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popDeliveryBranchNm.NameText = ""
            Me.popDeliveryBranchNm.ReadOnlys = False
            Me.popDeliveryBranchNm.SelectedText = ""
            Me.popDeliveryBranchNm.SelectionLength = 0
            Me.popDeliveryBranchNm.SelectionStart = 0
            Me.popDeliveryBranchNm.Size = New System.Drawing.Size(226, 20)
            Me.popDeliveryBranchNm.TabIndex = 1686
            Me.popDeliveryBranchNm.Tag = "code(지국코드);"
            Me.popDeliveryBranchNm.TextAlign = 0
            Me.popDeliveryBranchNm.TextValue = ""
            Me.popDeliveryBranchNm.ToolTipText = ""
            '
            'txtDeptNm
            '
            Me.txtDeptNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeptNm.BorderColor = System.Drawing.Color.Empty
            Me.txtDeptNm.BorderStyle = 2
            Me.txtDeptNm.CaptionName = Nothing
            Me.txtDeptNm.Location = New System.Drawing.Point(282, 35)
            Me.txtDeptNm.MaxLength = 32767
            Me.txtDeptNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDeptNm.Multiline = False
            Me.txtDeptNm.Name = "txtDeptNm"
            Me.txtDeptNm.ReadOnlys = False
            Me.txtDeptNm.SelectedText = ""
            Me.txtDeptNm.SelectionLength = 0
            Me.txtDeptNm.SelectionStart = 0
            Me.txtDeptNm.Size = New System.Drawing.Size(226, 20)
            Me.txtDeptNm.TabIndex = 1682
            Me.txtDeptNm.Tag = Nothing
            Me.txtDeptNm.TextAlign = 0
            Me.txtDeptNm.TextValue = ""
            Me.txtDeptNm.ToolTipText = ""
            '
            'cboCollectionTypeCd
            '
            Me.cboCollectionTypeCd.CaptionName = "수금형태 코드"
            Me.cboCollectionTypeCd.ListCount = 0
            Me.cboCollectionTypeCd.Location = New System.Drawing.Point(92, 35)
            Me.cboCollectionTypeCd.Name = "cboCollectionTypeCd"
            Me.cboCollectionTypeCd.ReadOnlys = False
            Me.cboCollectionTypeCd.Size = New System.Drawing.Size(100, 20)
            Me.cboCollectionTypeCd.TabIndex = 1680
            Me.cboCollectionTypeCd.Tag = "code(수금형태코드|전체);"
            Me.cboCollectionTypeCd.TextValue = ""
            '
            'cboReaderStateCd
            '
            Me.cboReaderStateCd.CaptionName = "독자상태 코드"
            Me.cboReaderStateCd.ListCount = 0
            Me.cboReaderStateCd.Location = New System.Drawing.Point(92, 100)
            Me.cboReaderStateCd.Name = "cboReaderStateCd"
            Me.cboReaderStateCd.ReadOnlys = False
            Me.cboReaderStateCd.Size = New System.Drawing.Size(100, 20)
            Me.cboReaderStateCd.TabIndex = 1687
            Me.cboReaderStateCd.Tag = "code(독자상태코드|전체);"
            Me.cboReaderStateCd.TextValue = ""
            '
            'cboBillTypeCd
            '
            Me.cboBillTypeCd.CaptionName = "청구방법코드"
            Me.cboBillTypeCd.ListCount = 0
            Me.cboBillTypeCd.Location = New System.Drawing.Point(92, 79)
            Me.cboBillTypeCd.Name = "cboBillTypeCd"
            Me.cboBillTypeCd.ReadOnlys = False
            Me.cboBillTypeCd.Size = New System.Drawing.Size(100, 20)
            Me.cboBillTypeCd.TabIndex = 1685
            Me.cboBillTypeCd.Tag = "code(청구방법코드|전체);"
            Me.cboBillTypeCd.TextValue = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(17, 82)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(68, 15)
            Me.Label7.TabIndex = 1709
            Me.Label7.Text = "청구 방법"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(17, 103)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(68, 15)
            Me.Label9.TabIndex = 1708
            Me.Label9.Text = "독자상태"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Location = New System.Drawing.Point(514, 38)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(53, 15)
            Me.Label10.TabIndex = 1707
            Me.Label10.Text = "영업담당"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lbl확장처
            '
            Me.lbl확장처.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbl확장처.Location = New System.Drawing.Point(514, 82)
            Me.lbl확장처.Name = "lbl확장처"
            Me.lbl확장처.Size = New System.Drawing.Size(53, 15)
            Me.lbl확장처.TabIndex = 1706
            Me.lbl확장처.Text = "확장처"
            Me.lbl확장처.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(201, 82)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(77, 15)
            Me.Label4.TabIndex = 1705
            Me.Label4.Text = "지국"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(201, 38)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 15)
            Me.Label2.TabIndex = 1704
            Me.Label2.Text = "권유자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(17, 38)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(68, 15)
            Me.Label1.TabIndex = 1703
            Me.Label1.Text = "수금 형태"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Grd_1
            '
            Me.Grd_1.AllowBigSelection = False
            Me.Grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.Grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.Grd_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Grd_1.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.Grd_1.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.Grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.Grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.Grd_1.ExplorerBar = 0
            Me.Grd_1.ExtendLastCol = True
            Me.Grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.Grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.Grd_1.FrozenCols = 1
            Me.Grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.Grd_1.Location = New System.Drawing.Point(4, 199)
            Me.Grd_1.Name = "Grd_1"
            Me.Grd_1.NodeClosedPicture = Nothing
            Me.Grd_1.NodeOpenPicture = Nothing
            Me.Grd_1.OutlineCol = -1
            Me.Grd_1.RowHeightMax = 18
            Me.Grd_1.RowHeightMin = 15
            Me.Grd_1.Rows = 2
            Me.Grd_1.Size = New System.Drawing.Size(801, 443)
            Me.Grd_1.StyleInfo = resources.GetString("Grd_1.StyleInfo")
            Me.Grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.Grd_1.TabIndex = 1699
            Me.Grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Grd_2
            '
            Me.Grd_2.AllowBigSelection = False
            Me.Grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.Grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.Grd_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.Grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.Grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.Grd_2.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.Grd_2.ExplorerBar = 0
            Me.Grd_2.ExtendLastCol = True
            Me.Grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.Grd_2.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.Grd_2.FrozenCols = 1
            Me.Grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.Grd_2.Location = New System.Drawing.Point(4, 199)
            Me.Grd_2.Name = "Grd_2"
            Me.Grd_2.NodeClosedPicture = Nothing
            Me.Grd_2.NodeOpenPicture = Nothing
            Me.Grd_2.OutlineCol = -1
            Me.Grd_2.RowHeightMax = 18
            Me.Grd_2.RowHeightMin = 15
            Me.Grd_2.Rows = 2
            Me.Grd_2.Size = New System.Drawing.Size(801, 443)
            Me.Grd_2.StyleInfo = resources.GetString("Grd_2.StyleInfo")
            Me.Grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.Grd_2.TabIndex = 1702
            Me.Grd_2.TreeColor = System.Drawing.Color.DarkGray
            Me.Grd_2.Visible = False
            '
            'dtpReceiptDtFrom
            '
            Me.dtpReceiptDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtFrom.BorderStyle = 2
            Me.dtpReceiptDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtFrom.CaptionName = "접수 일자"
            Me.dtpReceiptDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(92, 12)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtFrom.TabIndex = 1678
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(182, 15)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 1681
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
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(203, 12)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtTo.TabIndex = 1679
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(17, 15)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(68, 15)
            Me.Label8.TabIndex = 1701
            Me.Label8.Text = "접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(4, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 122)
            Me.picCriteria.TabIndex = 1700
            Me.picCriteria.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(5, 129)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(800, 30)
            Me.PictureBox2.TabIndex = 1719
            Me.PictureBox2.TabStop = False
            '
            'grd_5
            '
            Me.grd_5.AllowBigSelection = False
            Me.grd_5.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_5.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_5.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_5.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_5.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_5.ExplorerBar = 0
            Me.grd_5.ExtendLastCol = True
            Me.grd_5.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_5.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_5.FrozenCols = 1
            Me.grd_5.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_5.Location = New System.Drawing.Point(4, 199)
            Me.grd_5.Name = "grd_5"
            Me.grd_5.NodeClosedPicture = Nothing
            Me.grd_5.NodeOpenPicture = Nothing
            Me.grd_5.OutlineCol = -1
            Me.grd_5.RowHeightMax = 18
            Me.grd_5.RowHeightMin = 15
            Me.grd_5.Rows = 2
            Me.grd_5.Size = New System.Drawing.Size(801, 443)
            Me.grd_5.StyleInfo = resources.GetString("grd_5.StyleInfo")
            Me.grd_5.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_5.TabIndex = 1720
            Me.grd_5.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_5.Visible = False
            '
            'grd_4
            '
            Me.grd_4.AllowBigSelection = False
            Me.grd_4.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_4.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_4.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_4.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_4.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExtendLastCol = True
            Me.grd_4.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_4.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_4.FrozenCols = 1
            Me.grd_4.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_4.Location = New System.Drawing.Point(5, 199)
            Me.grd_4.Name = "grd_4"
            Me.grd_4.NodeClosedPicture = Nothing
            Me.grd_4.NodeOpenPicture = Nothing
            Me.grd_4.OutlineCol = -1
            Me.grd_4.RowHeightMax = 18
            Me.grd_4.RowHeightMin = 15
            Me.grd_4.Rows = 2
            Me.grd_4.Size = New System.Drawing.Size(801, 443)
            Me.grd_4.StyleInfo = resources.GetString("grd_4.StyleInfo")
            Me.grd_4.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_4.TabIndex = 1721
            Me.grd_4.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_4.Visible = False
            '
            'PNE303
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnExcelExport)
            Me.Controls.Add(Me.optBranchDelivery)
            Me.Controls.Add(Me.optHeadOfficeDelivery)
            Me.Controls.Add(Me.optstop)
            Me.Controls.Add(Me.popBizChargeCd)
            Me.Controls.Add(Me.optReceipt)
            Me.Controls.Add(Me.optMonitor)
            Me.Controls.Add(Me.Grd_3)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.cboReaderInCd_r)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.dtpFixedEdDt)
            Me.Controls.Add(Me.txtSubscriberNm)
            Me.Controls.Add(Me.PopDeliveryChnlNm)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.txtAdEmployeeNm)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.CboMonitoringResultCd)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.popDeliveryBranchNm)
            Me.Controls.Add(Me.txtDeptNm)
            Me.Controls.Add(Me.cboCollectionTypeCd)
            Me.Controls.Add(Me.cboReaderStateCd)
            Me.Controls.Add(Me.cboBillTypeCd)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.lbl확장처)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Grd_1)
            Me.Controls.Add(Me.Grd_2)
            Me.Controls.Add(Me.dtpReceiptDtFrom)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpReceiptDtTo)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.grd_5)
            Me.Controls.Add(Me.grd_4)
            Me.Name = "PNE303"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_4, 0)
            Me.Controls.SetChildIndex(Me.grd_5, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtFrom, 0)
            Me.Controls.SetChildIndex(Me.Grd_2, 0)
            Me.Controls.SetChildIndex(Me.Grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.lbl확장처, 0)
            Me.Controls.SetChildIndex(Me.Label10, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.cboBillTypeCd, 0)
            Me.Controls.SetChildIndex(Me.cboReaderStateCd, 0)
            Me.Controls.SetChildIndex(Me.cboCollectionTypeCd, 0)
            Me.Controls.SetChildIndex(Me.txtDeptNm, 0)
            Me.Controls.SetChildIndex(Me.popDeliveryBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.CboMonitoringResultCd, 0)
            Me.Controls.SetChildIndex(Me.Label11, 0)
            Me.Controls.SetChildIndex(Me.txtAdEmployeeNm, 0)
            Me.Controls.SetChildIndex(Me.Label12, 0)
            Me.Controls.SetChildIndex(Me.Label13, 0)
            Me.Controls.SetChildIndex(Me.PopDeliveryChnlNm, 0)
            Me.Controls.SetChildIndex(Me.txtSubscriberNm, 0)
            Me.Controls.SetChildIndex(Me.dtpFixedEdDt, 0)
            Me.Controls.SetChildIndex(Me.Label14, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.cboReaderInCd_r, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.Grd_3, 0)
            Me.Controls.SetChildIndex(Me.optMonitor, 0)
            Me.Controls.SetChildIndex(Me.optReceipt, 0)
            Me.Controls.SetChildIndex(Me.popBizChargeCd, 0)
            Me.Controls.SetChildIndex(Me.optstop, 0)
            Me.Controls.SetChildIndex(Me.optHeadOfficeDelivery, 0)
            Me.Controls.SetChildIndex(Me.optBranchDelivery, 0)
            Me.Controls.SetChildIndex(Me.btnExcelExport, 0)
            CType(Me.Grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnExcelExport As ubiLease.CommonControls.btn
        Friend WithEvents optBranchDelivery As System.Windows.Forms.RadioButton
        Friend WithEvents optHeadOfficeDelivery As System.Windows.Forms.RadioButton
        Friend WithEvents optstop As System.Windows.Forms.RadioButton
        Friend WithEvents popBizChargeCd As ubiLease.CommonControls.pop
        Friend WithEvents optReceipt As System.Windows.Forms.RadioButton
        Friend WithEvents optMonitor As System.Windows.Forms.RadioButton
        Friend WithEvents Grd_3 As ubiLease.GridControl.grd
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cboReaderInCd_r As ubiLease.CommonControls.cbo
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents dtpFixedEdDt As ubiLease.CommonControls.dtp
        Friend WithEvents txtSubscriberNm As ubiLease.CommonControls.txt
        Friend WithEvents PopDeliveryChnlNm As ubiLease.CommonControls.pop
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtAdEmployeeNm As ubiLease.CommonControls.txt
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents CboMonitoringResultCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents popDeliveryBranchNm As ubiLease.CommonControls.pop
        Friend WithEvents txtDeptNm As ubiLease.CommonControls.txt
        Friend WithEvents cboCollectionTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents cboReaderStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents cboBillTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lbl확장처 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Grd_2 As ubiLease.GridControl.grd
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_5 As ubiLease.GridControl.grd
        Friend WithEvents grd_4 As ubiLease.GridControl.grd


    End Class

End Namespace
