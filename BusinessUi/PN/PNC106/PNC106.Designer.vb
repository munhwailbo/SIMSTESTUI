Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC106
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC106))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label3 = New System.Windows.Forms.Label
            Me.cboMonitoringResultCd_R = New ubiLease.CommonControls.cbo
            Me.btnApprovalAll = New System.Windows.Forms.Button
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.Label32 = New System.Windows.Forms.Label
            Me.txtAdEmployeeNm_R = New ubiLease.CommonControls.txt
            Me.Label17 = New System.Windows.Forms.Label
            Me.cboExpandDivCd_2 = New ubiLease.CommonControls.cbo
            Me.Label11 = New System.Windows.Forms.Label
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.cboRefuseReasonCd = New ubiLease.CommonControls.cbo
            Me.lblRefuseReasonCd = New System.Windows.Forms.Label
            Me.cboMonitoringResultCd = New ubiLease.CommonControls.cbo
            Me.lblMonitoringResultCd = New System.Windows.Forms.Label
            Me.lblSolicitorNotifyDt = New System.Windows.Forms.Label
            Me.dtpSolicitorNotifyDt = New ubiLease.CommonControls.dtp
            Me.chkNotifyYN = New ubiLease.CommonControls.chk
            Me.txtMonitoringRemark = New System.Windows.Forms.TextBox
            Me.dtpMonitoringProcDt = New ubiLease.CommonControls.dtp
            Me.Label24 = New System.Windows.Forms.Label
            Me.popMonitoringEmpNum = New ubiLease.CommonControls.pop
            Me.Label21 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblNote = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.picCriteria2 = New System.Windows.Forms.PictureBox
            Me.dtpApprovalDt = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.PopCompanyCd_R = New ubiLease.CommonControls.pop
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(800, 71)
            Me.picCriteria.TabIndex = 1
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
            Me.grd_1.Location = New System.Drawing.Point(6, 123)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(800, 421)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(30, 47)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 15)
            Me.Label3.TabIndex = 799
            Me.Label3.Text = "접수일자"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboMonitoringResultCd_R
            '
            Me.cboMonitoringResultCd_R.CaptionName = "모니터 처리 코드"
            Me.cboMonitoringResultCd_R.ListCount = 0
            Me.cboMonitoringResultCd_R.Location = New System.Drawing.Point(249, 19)
            Me.cboMonitoringResultCd_R.Name = "cboMonitoringResultCd_R"
            Me.cboMonitoringResultCd_R.ReadOnlys = False
            Me.cboMonitoringResultCd_R.Size = New System.Drawing.Size(81, 20)
            Me.cboMonitoringResultCd_R.TabIndex = 1
            Me.cboMonitoringResultCd_R.Tag = "code(모니터결과처리코드|전체);"
            Me.cboMonitoringResultCd_R.TextValue = ""
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(227, 87)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(90, 26)
            Me.btnApprovalAll.TabIndex = 804
            Me.btnApprovalAll.Text = "일괄 승인"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'dtpReceiptDtTo
            '
            Me.dtpReceiptDtTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtTo.BorderStyle = 2
            Me.dtpReceiptDtTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtTo.CaptionName = "접수 일자 2"
            Me.dtpReceiptDtTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(231, 44)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(100, 20)
            Me.dtpReceiptDtTo.TabIndex = 4
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(204, 47)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(20, 15)
            Me.Label2.TabIndex = 806
            Me.Label2.Text = "~"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "처리자 명"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 55
            Me.popEmployeeNumber.Location = New System.Drawing.Point(645, 44)
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
            Me.popEmployeeNumber.TabIndex = 6
            Me.popEmployeeNumber.Tag = "code(모니터담당 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'Label32
            '
            Me.Label32.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label32.Location = New System.Drawing.Point(567, 45)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(72, 17)
            Me.Label32.TabIndex = 1353
            Me.Label32.Text = "모니터 담당"
            Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAdEmployeeNm_R
            '
            Me.txtAdEmployeeNm_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtAdEmployeeNm_R.BorderColor = System.Drawing.Color.Empty
            Me.txtAdEmployeeNm_R.BorderStyle = 2
            Me.txtAdEmployeeNm_R.CaptionName = "지국 명"
            Me.txtAdEmployeeNm_R.Location = New System.Drawing.Point(417, 44)
            Me.txtAdEmployeeNm_R.MaxLength = 32767
            Me.txtAdEmployeeNm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAdEmployeeNm_R.Multiline = False
            Me.txtAdEmployeeNm_R.Name = "txtAdEmployeeNm_R"
            Me.txtAdEmployeeNm_R.ReadOnlys = False
            Me.txtAdEmployeeNm_R.SelectedText = ""
            Me.txtAdEmployeeNm_R.SelectionLength = 0
            Me.txtAdEmployeeNm_R.SelectionStart = 0
            Me.txtAdEmployeeNm_R.Size = New System.Drawing.Size(144, 20)
            Me.txtAdEmployeeNm_R.TabIndex = 5
            Me.txtAdEmployeeNm_R.Tag = Nothing
            Me.txtAdEmployeeNm_R.TextAlign = 0
            Me.txtAdEmployeeNm_R.TextValue = ""
            Me.txtAdEmployeeNm_R.ToolTipText = ""
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label17.Location = New System.Drawing.Point(350, 47)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(61, 15)
            Me.Label17.TabIndex = 1359
            Me.Label17.Text = "권유자"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboExpandDivCd_2
            '
            Me.cboExpandDivCd_2.BackColor = System.Drawing.SystemColors.Window
            Me.cboExpandDivCd_2.CaptionName = "지국 확장 구분 코드"
            Me.cboExpandDivCd_2.Enabled = False
            Me.cboExpandDivCd_2.ListCount = 0
            Me.cboExpandDivCd_2.Location = New System.Drawing.Point(99, 19)
            Me.cboExpandDivCd_2.Name = "cboExpandDivCd_2"
            Me.cboExpandDivCd_2.ReadOnlys = False
            Me.cboExpandDivCd_2.Size = New System.Drawing.Size(125, 20)
            Me.cboExpandDivCd_2.TabIndex = 0
            Me.cboExpandDivCd_2.Tag = "code(확장구분코드|전체);"
            Me.cboExpandDivCd_2.TextValue = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(32, 22)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 15)
            Me.Label11.TabIndex = 1363
            Me.Label11.Text = "확장구분"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDtFrom
            '
            Me.dtpReceiptDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtFrom.BorderStyle = 2
            Me.dtpReceiptDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtFrom.CaptionName = "접수 일자"
            Me.dtpReceiptDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(99, 44)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(100, 20)
            Me.dtpReceiptDtFrom.TabIndex = 3
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'cboRefuseReasonCd
            '
            Me.cboRefuseReasonCd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboRefuseReasonCd.CaptionName = "미 통과 사유"
            Me.cboRefuseReasonCd.ListCount = 0
            Me.cboRefuseReasonCd.Location = New System.Drawing.Point(301, 557)
            Me.cboRefuseReasonCd.Name = "cboRefuseReasonCd"
            Me.cboRefuseReasonCd.ReadOnlys = False
            Me.cboRefuseReasonCd.Size = New System.Drawing.Size(143, 20)
            Me.cboRefuseReasonCd.TabIndex = 9
            Me.cboRefuseReasonCd.Tag = "code(모니터미통과사유코드|해당 없음);"
            Me.cboRefuseReasonCd.TextValue = ""
            '
            'lblRefuseReasonCd
            '
            Me.lblRefuseReasonCd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRefuseReasonCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRefuseReasonCd.Location = New System.Drawing.Point(220, 559)
            Me.lblRefuseReasonCd.Name = "lblRefuseReasonCd"
            Me.lblRefuseReasonCd.Size = New System.Drawing.Size(75, 18)
            Me.lblRefuseReasonCd.TabIndex = 1680
            Me.lblRefuseReasonCd.Text = "미통과사유"
            Me.lblRefuseReasonCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboMonitoringResultCd
            '
            Me.cboMonitoringResultCd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboMonitoringResultCd.CaptionName = "모니터 처리 코드"
            Me.cboMonitoringResultCd.ListCount = 0
            Me.cboMonitoringResultCd.Location = New System.Drawing.Point(108, 559)
            Me.cboMonitoringResultCd.Name = "cboMonitoringResultCd"
            Me.cboMonitoringResultCd.ReadOnlys = False
            Me.cboMonitoringResultCd.Size = New System.Drawing.Size(99, 20)
            Me.cboMonitoringResultCd.TabIndex = 8
            Me.cboMonitoringResultCd.Tag = "code(모니터결과처리코드| );"
            Me.cboMonitoringResultCd.TextValue = ""
            '
            'lblMonitoringResultCd
            '
            Me.lblMonitoringResultCd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblMonitoringResultCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblMonitoringResultCd.Location = New System.Drawing.Point(67, 560)
            Me.lblMonitoringResultCd.Name = "lblMonitoringResultCd"
            Me.lblMonitoringResultCd.Size = New System.Drawing.Size(35, 18)
            Me.lblMonitoringResultCd.TabIndex = 1679
            Me.lblMonitoringResultCd.Text = "결과"
            Me.lblMonitoringResultCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSolicitorNotifyDt
            '
            Me.lblSolicitorNotifyDt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblSolicitorNotifyDt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblSolicitorNotifyDt.Location = New System.Drawing.Point(585, 559)
            Me.lblSolicitorNotifyDt.Name = "lblSolicitorNotifyDt"
            Me.lblSolicitorNotifyDt.Size = New System.Drawing.Size(80, 18)
            Me.lblSolicitorNotifyDt.TabIndex = 11
            Me.lblSolicitorNotifyDt.Text = "권유통보일자"
            Me.lblSolicitorNotifyDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpSolicitorNotifyDt
            '
            Me.dtpSolicitorNotifyDt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpSolicitorNotifyDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSolicitorNotifyDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpSolicitorNotifyDt.BorderStyle = 2
            Me.dtpSolicitorNotifyDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSolicitorNotifyDt.CaptionName = Nothing
            Me.dtpSolicitorNotifyDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSolicitorNotifyDt.Location = New System.Drawing.Point(671, 559)
            Me.dtpSolicitorNotifyDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSolicitorNotifyDt.MaxLength = 0
            Me.dtpSolicitorNotifyDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSolicitorNotifyDt.Name = "dtpSolicitorNotifyDt"
            Me.dtpSolicitorNotifyDt.ReadOnlys = False
            Me.dtpSolicitorNotifyDt.SelectedText = ""
            Me.dtpSolicitorNotifyDt.SelectionLength = 0
            Me.dtpSolicitorNotifyDt.SelectionStart = 0
            Me.dtpSolicitorNotifyDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpSolicitorNotifyDt.TabIndex = 12
            Me.dtpSolicitorNotifyDt.Tag = "format(####-##-##);"
            Me.dtpSolicitorNotifyDt.TextAlign = 0
            Me.dtpSolicitorNotifyDt.TextValue = ""
            Me.dtpSolicitorNotifyDt.ToolTipText = ""
            '
            'chkNotifyYN
            '
            Me.chkNotifyYN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkNotifyYN.BackColor = System.Drawing.SystemColors.Window
            Me.chkNotifyYN.CaptionName = Nothing
            Me.chkNotifyYN.Location = New System.Drawing.Point(477, 562)
            Me.chkNotifyYN.Name = "chkNotifyYN"
            Me.chkNotifyYN.ReadOnlys = False
            Me.chkNotifyYN.Size = New System.Drawing.Size(84, 15)
            Me.chkNotifyYN.TabIndex = 10
            Me.chkNotifyYN.Tag = ""
            Me.chkNotifyYN.Text = "권유자통보 여부"
            Me.chkNotifyYN.TextValue = "0"
            Me.chkNotifyYN.UseVisualStyleBackColor = False
            '
            'txtMonitoringRemark
            '
            Me.txtMonitoringRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtMonitoringRemark.Location = New System.Drawing.Point(301, 583)
            Me.txtMonitoringRemark.Multiline = True
            Me.txtMonitoringRemark.Name = "txtMonitoringRemark"
            Me.txtMonitoringRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtMonitoringRemark.Size = New System.Drawing.Size(467, 44)
            Me.txtMonitoringRemark.TabIndex = 15
            '
            'dtpMonitoringProcDt
            '
            Me.dtpMonitoringProcDt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpMonitoringProcDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMonitoringProcDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpMonitoringProcDt.BorderStyle = 2
            Me.dtpMonitoringProcDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMonitoringProcDt.CaptionName = "처리 일자"
            Me.dtpMonitoringProcDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpMonitoringProcDt.Location = New System.Drawing.Point(108, 607)
            Me.dtpMonitoringProcDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMonitoringProcDt.MaxLength = 0
            Me.dtpMonitoringProcDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMonitoringProcDt.Name = "dtpMonitoringProcDt"
            Me.dtpMonitoringProcDt.ReadOnlys = False
            Me.dtpMonitoringProcDt.SelectedText = ""
            Me.dtpMonitoringProcDt.SelectionLength = 0
            Me.dtpMonitoringProcDt.SelectionStart = 0
            Me.dtpMonitoringProcDt.Size = New System.Drawing.Size(137, 20)
            Me.dtpMonitoringProcDt.TabIndex = 14
            Me.dtpMonitoringProcDt.Tag = "format(####-##-##);"
            Me.dtpMonitoringProcDt.TextAlign = 0
            Me.dtpMonitoringProcDt.TextValue = ""
            Me.dtpMonitoringProcDt.ToolTipText = ""
            '
            'Label24
            '
            Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label24.BackColor = System.Drawing.Color.GhostWhite
            Me.Label24.Location = New System.Drawing.Point(37, 610)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(65, 15)
            Me.Label24.TabIndex = 1672
            Me.Label24.Text = "처리일자"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popMonitoringEmpNum
            '
            Me.popMonitoringEmpNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.popMonitoringEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popMonitoringEmpNum.BorderStyle = 2
            Me.popMonitoringEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popMonitoringEmpNum.CaptionName = "모니터담당자"
            Me.popMonitoringEmpNum.CodeText = ""
            Me.popMonitoringEmpNum.CodeWidth = 55
            Me.popMonitoringEmpNum.Location = New System.Drawing.Point(108, 583)
            Me.popMonitoringEmpNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popMonitoringEmpNum.MaxLength = 6
            Me.popMonitoringEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popMonitoringEmpNum.Name = "popMonitoringEmpNum"
            Me.popMonitoringEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popMonitoringEmpNum.NameText = ""
            Me.popMonitoringEmpNum.ReadOnlys = False
            Me.popMonitoringEmpNum.SelectedText = ""
            Me.popMonitoringEmpNum.SelectionLength = 0
            Me.popMonitoringEmpNum.SelectionStart = 0
            Me.popMonitoringEmpNum.Size = New System.Drawing.Size(137, 20)
            Me.popMonitoringEmpNum.TabIndex = 13
            Me.popMonitoringEmpNum.Tag = "code(모니터담당 명);"
            Me.popMonitoringEmpNum.TextAlign = 0
            Me.popMonitoringEmpNum.TextValue = ""
            Me.popMonitoringEmpNum.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(54, 586)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(48, 15)
            Me.Label21.TabIndex = 1671
            Me.Label21.Text = "담당자"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(10, 553)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(54, 18)
            Me.Label1.TabIndex = 1670
            Me.Label1.Text = "모니터"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblNote
            '
            Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblNote.Location = New System.Drawing.Point(251, 583)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(44, 18)
            Me.lblNote.TabIndex = 1667
            Me.lblNote.Text = "비고"
            Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label14
            '
            Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label14.BackColor = System.Drawing.Color.White
            Me.Label14.Font = New System.Drawing.Font("굴림체", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.Red
            Me.Label14.Location = New System.Drawing.Point(343, 628)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(160, 9)
            Me.Label14.TabIndex = 1668
            Me.Label14.Text = "250자 이내로 입력 합니다."
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(7, 550)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(799, 90)
            Me.picIo_2.TabIndex = 1669
            Me.picIo_2.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.Pink
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(5, 548)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(803, 94)
            Me.PictureBox2.TabIndex = 1673
            Me.PictureBox2.TabStop = False
            '
            'picCriteria2
            '
            Me.picCriteria2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria2.BackColor = System.Drawing.Color.GhostWhite
            Me.picCriteria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria2.Location = New System.Drawing.Point(5, 81)
            Me.picCriteria2.Name = "picCriteria2"
            Me.picCriteria2.Size = New System.Drawing.Size(801, 38)
            Me.picCriteria2.TabIndex = 1681
            Me.picCriteria2.TabStop = False
            '
            'dtpApprovalDt
            '
            Me.dtpApprovalDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpApprovalDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpApprovalDt.BorderStyle = 2
            Me.dtpApprovalDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpApprovalDt.CaptionName = "접수 일자"
            Me.dtpApprovalDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpApprovalDt.Location = New System.Drawing.Point(99, 90)
            Me.dtpApprovalDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpApprovalDt.MaxLength = 0
            Me.dtpApprovalDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpApprovalDt.Name = "dtpApprovalDt"
            Me.dtpApprovalDt.ReadOnlys = False
            Me.dtpApprovalDt.SelectedText = ""
            Me.dtpApprovalDt.SelectionLength = 0
            Me.dtpApprovalDt.SelectionStart = 0
            Me.dtpApprovalDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpApprovalDt.TabIndex = 7
            Me.dtpApprovalDt.Tag = "format(####-##-##);"
            Me.dtpApprovalDt.TextAlign = 0
            Me.dtpApprovalDt.TextValue = ""
            Me.dtpApprovalDt.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(30, 92)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 15)
            Me.Label4.TabIndex = 1682
            Me.Label4.Text = "승인일자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(350, 22)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(61, 15)
            Me.Label5.TabIndex = 1684
            Me.Label5.Text = "확장처"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PopCompanyCd_R
            '
            Me.PopCompanyCd_R.BorderColor = System.Drawing.Color.Empty
            Me.PopCompanyCd_R.BorderStyle = 2
            Me.PopCompanyCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopCompanyCd_R.CaptionName = "처리자 명"
            Me.PopCompanyCd_R.CodeText = ""
            Me.PopCompanyCd_R.CodeWidth = 80
            Me.PopCompanyCd_R.Location = New System.Drawing.Point(417, 19)
            Me.PopCompanyCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopCompanyCd_R.MaxLength = 6
            Me.PopCompanyCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopCompanyCd_R.Name = "PopCompanyCd_R"
            Me.PopCompanyCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopCompanyCd_R.NameText = ""
            Me.PopCompanyCd_R.ReadOnlys = False
            Me.PopCompanyCd_R.SelectedText = ""
            Me.PopCompanyCd_R.SelectionLength = 0
            Me.PopCompanyCd_R.SelectionStart = 0
            Me.PopCompanyCd_R.Size = New System.Drawing.Size(378, 20)
            Me.PopCompanyCd_R.TabIndex = 2
            Me.PopCompanyCd_R.Tag = "code(확장처 명);"
            Me.PopCompanyCd_R.TextAlign = 0
            Me.PopCompanyCd_R.TextValue = ""
            Me.PopCompanyCd_R.ToolTipText = ""
            '
            'PNC106
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.PopCompanyCd_R)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dtpApprovalDt)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.cboRefuseReasonCd)
            Me.Controls.Add(Me.lblRefuseReasonCd)
            Me.Controls.Add(Me.cboMonitoringResultCd)
            Me.Controls.Add(Me.lblMonitoringResultCd)
            Me.Controls.Add(Me.lblSolicitorNotifyDt)
            Me.Controls.Add(Me.dtpSolicitorNotifyDt)
            Me.Controls.Add(Me.chkNotifyYN)
            Me.Controls.Add(Me.txtMonitoringRemark)
            Me.Controls.Add(Me.dtpMonitoringProcDt)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.popMonitoringEmpNum)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.dtpReceiptDtFrom)
            Me.Controls.Add(Me.cboExpandDivCd_2)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.txtAdEmployeeNm_R)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.Label32)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpReceiptDtTo)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.cboMonitoringResultCd_R)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.picCriteria2)
            Me.Name = "PNC106"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboMonitoringResultCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents txtAdEmployeeNm_R As ubiLease.CommonControls.txt
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents cboExpandDivCd_2 As ubiLease.CommonControls.cbo
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents cboRefuseReasonCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblRefuseReasonCd As System.Windows.Forms.Label
        Friend WithEvents cboMonitoringResultCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblMonitoringResultCd As System.Windows.Forms.Label
        Friend WithEvents lblSolicitorNotifyDt As System.Windows.Forms.Label
        Friend WithEvents dtpSolicitorNotifyDt As ubiLease.CommonControls.dtp
        Friend WithEvents chkNotifyYN As ubiLease.CommonControls.chk
        Friend WithEvents txtMonitoringRemark As System.Windows.Forms.TextBox
        Friend WithEvents dtpMonitoringProcDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents popMonitoringEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblNote As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents picCriteria2 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpApprovalDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents PopCompanyCd_R As ubiLease.CommonControls.pop

    End Class

End Namespace
