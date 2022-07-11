Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE304
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE304))
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.lbl확장처 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.cboBillTypeCd = New ubiLease.CommonControls.cbo
            Me.cboReaderStateCd = New ubiLease.CommonControls.cbo
            Me.cboCollectionTypeCd = New ubiLease.CommonControls.cbo
            Me.txtDeptNm = New ubiLease.CommonControls.txt
            Me.popDeliveryBranchNm = New ubiLease.CommonControls.pop
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.CboMonitoringResultCd = New ubiLease.CommonControls.cbo
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtAdEmployeeNm = New ubiLease.CommonControls.txt
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.PopDeliveryChnlNm = New ubiLease.CommonControls.pop
            Me.Label13 = New System.Windows.Forms.Label
            Me.txtSubscriberNm = New ubiLease.CommonControls.txt
            Me.Label15 = New System.Windows.Forms.Label
            Me.cboReaderInCd_r = New ubiLease.CommonControls.cbo
            Me.popBizChargeCd = New ubiLease.CommonControls.pop
            Me.dtpFixedEdDtFr = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpFixedEdDtTo = New ubiLease.CommonControls.dtp
            Me.Label16 = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(93, 12)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtFrom.TabIndex = 0
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(183, 15)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 2
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
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(204, 12)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtTo.TabIndex = 1
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(18, 15)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(68, 15)
            Me.Label8.TabIndex = 1552
            Me.Label8.Text = "접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 122)
            Me.picCriteria.TabIndex = 1543
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
            Me.grd_1.Location = New System.Drawing.Point(5, 132)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 510)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 16
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(18, 38)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(68, 15)
            Me.Label1.TabIndex = 1627
            Me.Label1.Text = "수금 형태"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(202, 38)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 15)
            Me.Label2.TabIndex = 1628
            Me.Label2.Text = "권유자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lbl확장처
            '
            Me.lbl확장처.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbl확장처.Location = New System.Drawing.Point(515, 82)
            Me.lbl확장처.Name = "lbl확장처"
            Me.lbl확장처.Size = New System.Drawing.Size(53, 15)
            Me.lbl확장처.TabIndex = 1632
            Me.lbl확장처.Text = "확장처"
            Me.lbl확장처.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(202, 82)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(77, 15)
            Me.Label4.TabIndex = 1631
            Me.Label4.Text = "지국"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(18, 82)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(68, 15)
            Me.Label7.TabIndex = 1639
            Me.Label7.Text = "청구 방법"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(18, 103)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(68, 15)
            Me.Label9.TabIndex = 1636
            Me.Label9.Text = "독자상태"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Location = New System.Drawing.Point(515, 38)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(53, 15)
            Me.Label10.TabIndex = 1635
            Me.Label10.Text = "영업담당"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBillTypeCd
            '
            Me.cboBillTypeCd.CaptionName = "청구방법코드"
            Me.cboBillTypeCd.ListCount = 0
            Me.cboBillTypeCd.Location = New System.Drawing.Point(93, 79)
            Me.cboBillTypeCd.Name = "cboBillTypeCd"
            Me.cboBillTypeCd.ReadOnlys = False
            Me.cboBillTypeCd.Size = New System.Drawing.Size(100, 20)
            Me.cboBillTypeCd.TabIndex = 9
            Me.cboBillTypeCd.Tag = "code(청구방법코드|전체);"
            Me.cboBillTypeCd.TextValue = ""
            '
            'cboReaderStateCd
            '
            Me.cboReaderStateCd.CaptionName = "독자상태 코드"
            Me.cboReaderStateCd.ListCount = 0
            Me.cboReaderStateCd.Location = New System.Drawing.Point(93, 100)
            Me.cboReaderStateCd.Name = "cboReaderStateCd"
            Me.cboReaderStateCd.ReadOnlys = False
            Me.cboReaderStateCd.Size = New System.Drawing.Size(100, 20)
            Me.cboReaderStateCd.TabIndex = 12
            Me.cboReaderStateCd.Tag = "code(독자상태코드|전체);"
            Me.cboReaderStateCd.TextValue = ""
            '
            'cboCollectionTypeCd
            '
            Me.cboCollectionTypeCd.CaptionName = "수금형태 코드"
            Me.cboCollectionTypeCd.ListCount = 0
            Me.cboCollectionTypeCd.Location = New System.Drawing.Point(93, 35)
            Me.cboCollectionTypeCd.Name = "cboCollectionTypeCd"
            Me.cboCollectionTypeCd.ReadOnlys = False
            Me.cboCollectionTypeCd.Size = New System.Drawing.Size(100, 20)
            Me.cboCollectionTypeCd.TabIndex = 3
            Me.cboCollectionTypeCd.Tag = "code(수금형태코드|전체);"
            Me.cboCollectionTypeCd.TextValue = ""
            '
            'txtDeptNm
            '
            Me.txtDeptNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeptNm.BorderColor = System.Drawing.Color.Empty
            Me.txtDeptNm.BorderStyle = 2
            Me.txtDeptNm.CaptionName = Nothing
            Me.txtDeptNm.Location = New System.Drawing.Point(283, 35)
            Me.txtDeptNm.MaxLength = 32767
            Me.txtDeptNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDeptNm.Multiline = False
            Me.txtDeptNm.Name = "txtDeptNm"
            Me.txtDeptNm.ReadOnlys = False
            Me.txtDeptNm.SelectedText = ""
            Me.txtDeptNm.SelectionLength = 0
            Me.txtDeptNm.SelectionStart = 0
            Me.txtDeptNm.Size = New System.Drawing.Size(226, 20)
            Me.txtDeptNm.TabIndex = 4
            Me.txtDeptNm.Tag = Nothing
            Me.txtDeptNm.TextAlign = 0
            Me.txtDeptNm.TextValue = ""
            Me.txtDeptNm.ToolTipText = ""
            '
            'popDeliveryBranchNm
            '
            Me.popDeliveryBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.popDeliveryBranchNm.BorderStyle = 2
            Me.popDeliveryBranchNm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeliveryBranchNm.CaptionName = "지국코드"
            Me.popDeliveryBranchNm.CodeText = ""
            Me.popDeliveryBranchNm.CodeWidth = 60
            Me.popDeliveryBranchNm.Location = New System.Drawing.Point(283, 79)
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
            Me.popDeliveryBranchNm.TabIndex = 10
            Me.popDeliveryBranchNm.Tag = "code(지국코드);"
            Me.popDeliveryBranchNm.TextAlign = 0
            Me.popDeliveryBranchNm.TextValue = ""
            Me.popDeliveryBranchNm.ToolTipText = ""
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "지국코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 60
            Me.popCompanyCd.Location = New System.Drawing.Point(572, 79)
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
            Me.popCompanyCd.TabIndex = 11
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'CboMonitoringResultCd
            '
            Me.CboMonitoringResultCd.CaptionName = "모니터결과처리코드"
            Me.CboMonitoringResultCd.ListCount = 0
            Me.CboMonitoringResultCd.Location = New System.Drawing.Point(93, 57)
            Me.CboMonitoringResultCd.Name = "CboMonitoringResultCd"
            Me.CboMonitoringResultCd.ReadOnlys = False
            Me.CboMonitoringResultCd.Size = New System.Drawing.Size(100, 20)
            Me.CboMonitoringResultCd.TabIndex = 6
            Me.CboMonitoringResultCd.Tag = "code(모니터결과처리코드|전체);"
            Me.CboMonitoringResultCd.TextValue = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(18, 58)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(68, 18)
            Me.Label5.TabIndex = 1657
            Me.Label5.Text = "모니터통과"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAdEmployeeNm
            '
            Me.txtAdEmployeeNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtAdEmployeeNm.BorderColor = System.Drawing.Color.Empty
            Me.txtAdEmployeeNm.BorderStyle = 2
            Me.txtAdEmployeeNm.CaptionName = Nothing
            Me.txtAdEmployeeNm.Location = New System.Drawing.Point(283, 57)
            Me.txtAdEmployeeNm.MaxLength = 32767
            Me.txtAdEmployeeNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAdEmployeeNm.Multiline = False
            Me.txtAdEmployeeNm.Name = "txtAdEmployeeNm"
            Me.txtAdEmployeeNm.ReadOnlys = False
            Me.txtAdEmployeeNm.SelectedText = ""
            Me.txtAdEmployeeNm.SelectionLength = 0
            Me.txtAdEmployeeNm.SelectionStart = 0
            Me.txtAdEmployeeNm.Size = New System.Drawing.Size(226, 20)
            Me.txtAdEmployeeNm.TabIndex = 7
            Me.txtAdEmployeeNm.Tag = Nothing
            Me.txtAdEmployeeNm.TextAlign = 0
            Me.txtAdEmployeeNm.TextValue = ""
            Me.txtAdEmployeeNm.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(202, 58)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(77, 19)
            Me.Label11.TabIndex = 1659
            Me.Label11.Text = "보조권유자"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.Location = New System.Drawing.Point(515, 60)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(53, 15)
            Me.Label12.TabIndex = 1661
            Me.Label12.Text = "독자명"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PopDeliveryChnlNm
            '
            Me.PopDeliveryChnlNm.BorderColor = System.Drawing.Color.Empty
            Me.PopDeliveryChnlNm.BorderStyle = 2
            Me.PopDeliveryChnlNm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopDeliveryChnlNm.CaptionName = "투입처코드"
            Me.PopDeliveryChnlNm.CodeText = ""
            Me.PopDeliveryChnlNm.CodeWidth = 60
            Me.PopDeliveryChnlNm.Location = New System.Drawing.Point(572, 100)
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
            Me.PopDeliveryChnlNm.TabIndex = 15
            Me.PopDeliveryChnlNm.Tag = "code(투입처 명);"
            Me.PopDeliveryChnlNm.TextAlign = 0
            Me.PopDeliveryChnlNm.TextValue = ""
            Me.PopDeliveryChnlNm.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label13.Location = New System.Drawing.Point(515, 103)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(53, 15)
            Me.Label13.TabIndex = 1663
            Me.Label13.Text = "투입처"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSubscriberNm
            '
            Me.txtSubscriberNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm.BorderStyle = 2
            Me.txtSubscriberNm.CaptionName = Nothing
            Me.txtSubscriberNm.Location = New System.Drawing.Point(572, 57)
            Me.txtSubscriberNm.MaxLength = 32767
            Me.txtSubscriberNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm.Multiline = False
            Me.txtSubscriberNm.Name = "txtSubscriberNm"
            Me.txtSubscriberNm.ReadOnlys = False
            Me.txtSubscriberNm.SelectedText = ""
            Me.txtSubscriberNm.SelectionLength = 0
            Me.txtSubscriberNm.SelectionStart = 0
            Me.txtSubscriberNm.Size = New System.Drawing.Size(226, 20)
            Me.txtSubscriberNm.TabIndex = 8
            Me.txtSubscriberNm.Tag = Nothing
            Me.txtSubscriberNm.TextAlign = 0
            Me.txtSubscriberNm.TextValue = ""
            Me.txtSubscriberNm.ToolTipText = ""
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(514, 15)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(54, 15)
            Me.Label15.TabIndex = 1671
            Me.Label15.Text = "독자상태"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboReaderInCd_r
            '
            Me.cboReaderInCd_r.CaptionName = "모니터 결과"
            Me.cboReaderInCd_r.ListCount = 0
            Me.cboReaderInCd_r.Location = New System.Drawing.Point(572, 12)
            Me.cboReaderInCd_r.Name = "cboReaderInCd_r"
            Me.cboReaderInCd_r.ReadOnlys = False
            Me.cboReaderInCd_r.Size = New System.Drawing.Size(93, 20)
            Me.cboReaderInCd_r.TabIndex = 2
            Me.cboReaderInCd_r.Tag = "code(독자진행코드|전체);"
            Me.cboReaderInCd_r.TextValue = ""
            '
            'popBizChargeCd
            '
            Me.popBizChargeCd.BorderColor = System.Drawing.Color.Empty
            Me.popBizChargeCd.BorderStyle = 2
            Me.popBizChargeCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBizChargeCd.CaptionName = "지국코드"
            Me.popBizChargeCd.CodeText = ""
            Me.popBizChargeCd.CodeWidth = 60
            Me.popBizChargeCd.Location = New System.Drawing.Point(572, 35)
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
            Me.popBizChargeCd.TabIndex = 5
            Me.popBizChargeCd.Tag = "code(영업사원 명);"
            Me.popBizChargeCd.TextAlign = 0
            Me.popBizChargeCd.TextValue = ""
            Me.popBizChargeCd.ToolTipText = ""
            '
            'dtpFixedEdDtFr
            '
            Me.dtpFixedEdDtFr.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFixedEdDtFr.BorderColor = System.Drawing.Color.Empty
            Me.dtpFixedEdDtFr.BorderStyle = 2
            Me.dtpFixedEdDtFr.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFixedEdDtFr.CaptionName = "접수 일자"
            Me.dtpFixedEdDtFr.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFixedEdDtFr.Location = New System.Drawing.Point(283, 100)
            Me.dtpFixedEdDtFr.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFixedEdDtFr.MaxLength = 0
            Me.dtpFixedEdDtFr.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFixedEdDtFr.Name = "dtpFixedEdDtFr"
            Me.dtpFixedEdDtFr.ReadOnlys = False
            Me.dtpFixedEdDtFr.SelectedText = ""
            Me.dtpFixedEdDtFr.SelectionLength = 0
            Me.dtpFixedEdDtFr.SelectionStart = 0
            Me.dtpFixedEdDtFr.Size = New System.Drawing.Size(93, 20)
            Me.dtpFixedEdDtFr.TabIndex = 13
            Me.dtpFixedEdDtFr.Tag = "need;format(####-##-##);"
            Me.dtpFixedEdDtFr.TextAlign = 0
            Me.dtpFixedEdDtFr.TextValue = ""
            Me.dtpFixedEdDtFr.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(373, 103)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(20, 15)
            Me.Label3.TabIndex = 1676
            Me.Label3.Text = "~"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpFixedEdDtTo
            '
            Me.dtpFixedEdDtTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFixedEdDtTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpFixedEdDtTo.BorderStyle = 2
            Me.dtpFixedEdDtTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFixedEdDtTo.CaptionName = "접수 일자 2"
            Me.dtpFixedEdDtTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFixedEdDtTo.Location = New System.Drawing.Point(394, 100)
            Me.dtpFixedEdDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFixedEdDtTo.MaxLength = 0
            Me.dtpFixedEdDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFixedEdDtTo.Name = "dtpFixedEdDtTo"
            Me.dtpFixedEdDtTo.ReadOnlys = False
            Me.dtpFixedEdDtTo.SelectedText = ""
            Me.dtpFixedEdDtTo.SelectionLength = 0
            Me.dtpFixedEdDtTo.SelectionStart = 0
            Me.dtpFixedEdDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpFixedEdDtTo.TabIndex = 14
            Me.dtpFixedEdDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpFixedEdDtTo.TextAlign = 0
            Me.dtpFixedEdDtTo.TextValue = ""
            Me.dtpFixedEdDtTo.ToolTipText = ""
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label16.Location = New System.Drawing.Point(208, 103)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(68, 15)
            Me.Label16.TabIndex = 1677
            Me.Label16.Text = "만료일자"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNE304
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpFixedEdDtFr)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpFixedEdDtTo)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.popBizChargeCd)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.cboReaderInCd_r)
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
            Me.Controls.Add(Me.dtpReceiptDtFrom)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpReceiptDtTo)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNE304"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtFrom, 0)
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
            Me.Controls.SetChildIndex(Me.cboReaderInCd_r, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.popBizChargeCd, 0)
            Me.Controls.SetChildIndex(Me.Label16, 0)
            Me.Controls.SetChildIndex(Me.dtpFixedEdDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.dtpFixedEdDtFr, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lbl확장처 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cboBillTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents cboReaderStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents cboCollectionTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents txtDeptNm As ubiLease.CommonControls.txt
        Friend WithEvents popDeliveryBranchNm As ubiLease.CommonControls.pop
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents CboMonitoringResultCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtAdEmployeeNm As ubiLease.CommonControls.txt
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents PopDeliveryChnlNm As ubiLease.CommonControls.pop
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtSubscriberNm As ubiLease.CommonControls.txt
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cboReaderInCd_r As ubiLease.CommonControls.cbo
        Friend WithEvents popBizChargeCd As ubiLease.CommonControls.pop
        Friend WithEvents dtpFixedEdDtFr As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpFixedEdDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label16 As System.Windows.Forms.Label


    End Class

End Namespace
