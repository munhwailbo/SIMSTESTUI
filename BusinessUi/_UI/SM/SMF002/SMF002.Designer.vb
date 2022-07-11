Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMF002
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMF002))
            Me.picIo_2_2 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.txtSubject = New ubiLease.CommonControls.txt
            Me.lblUIID = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.cboSystemDivision = New ubiLease.CommonControls.cbo
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo = New ubiLease.CommonControls.dtp
            Me.lblDongCode = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.cboWorker = New ubiLease.CommonControls.cbo
            Me.Label13 = New System.Windows.Forms.Label
            Me.txtDemandMatters = New ubiLease.CommonControls.txt
            Me.txtManagementInternalUse = New ubiLease.CommonControls.txt
            Me.txtOccurrenceCause = New ubiLease.CommonControls.txt
            Me.numbbsSeq = New ubiLease.CommonControls.num
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpReceiptDateFrom = New ubiLease.CommonControls.dtp
            Me.txtNote = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.TabControl1 = New System.Windows.Forms.TabControl
            Me.TabPage1 = New System.Windows.Forms.TabPage
            Me.txtDemandMattersDummy = New System.Windows.Forms.TextBox
            Me.TabPage2 = New System.Windows.Forms.TabPage
            Me.txtManagementInternalUseDummy = New System.Windows.Forms.TextBox
            Me.TabPage3 = New System.Windows.Forms.TabPage
            Me.txtOccurrenceCauseDummy = New System.Windows.Forms.TextBox
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'picIo_2_2
            '
            Me.picIo_2_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_2.Location = New System.Drawing.Point(5, 307)
            Me.picIo_2_2.Name = "picIo_2_2"
            Me.picIo_2_2.Size = New System.Drawing.Size(800, 337)
            Me.picIo_2_2.TabIndex = 8
            Me.picIo_2_2.TabStop = False
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_1.Location = New System.Drawing.Point(5, 58)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(800, 243)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 9
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtSubject
            '
            Me.txtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSubject.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubject.BorderColor = System.Drawing.Color.Empty
            Me.txtSubject.BorderStyle = 2
            Me.txtSubject.CaptionName = "화면 ID"
            Me.txtSubject.Location = New System.Drawing.Point(57, 321)
            Me.txtSubject.MaxLength = 255
            Me.txtSubject.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubject.Multiline = False
            Me.txtSubject.Name = "txtSubject"
            Me.txtSubject.ReadOnlys = False
            Me.txtSubject.SelectedText = ""
            Me.txtSubject.SelectionLength = 0
            Me.txtSubject.SelectionStart = 0
            Me.txtSubject.Size = New System.Drawing.Size(737, 20)
            Me.txtSubject.TabIndex = 5
            Me.txtSubject.Tag = ""
            Me.txtSubject.TextAlign = 0
            Me.txtSubject.TextValue = ""
            Me.txtSubject.ToolTipText = ""
            '
            'lblUIID
            '
            Me.lblUIID.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUIID.Location = New System.Drawing.Point(16, 323)
            Me.lblUIID.Name = "lblUIID"
            Me.lblUIID.Size = New System.Drawing.Size(35, 16)
            Me.lblUIID.TabIndex = 12
            Me.lblUIID.Text = "제목"
            Me.lblUIID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(800, 47)
            Me.picCriteria.TabIndex = 70
            Me.picCriteria.TabStop = False
            '
            'cboSystemDivision
            '
            Me.cboSystemDivision.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision.ListCount = 0
            Me.cboSystemDivision.Location = New System.Drawing.Point(109, 18)
            Me.cboSystemDivision.Name = "cboSystemDivision"
            Me.cboSystemDivision.ReadOnlys = False
            Me.cboSystemDivision.Size = New System.Drawing.Size(94, 20)
            Me.cboSystemDivision.TabIndex = 1
            Me.cboSystemDivision.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision.TextValue = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(29, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(72, 18)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "시스템 구분"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpReceiptDateTo
            '
            Me.dtpReceiptDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateTo.BorderStyle = 2
            Me.dtpReceiptDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateTo.CaptionName = "배부 년 월"
            Me.dtpReceiptDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateTo.Location = New System.Drawing.Point(281, 18)
            Me.dtpReceiptDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo.MaxLength = 0
            Me.dtpReceiptDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo.Name = "dtpReceiptDateTo"
            Me.dtpReceiptDateTo.ReadOnlys = False
            Me.dtpReceiptDateTo.SelectedText = ""
            Me.dtpReceiptDateTo.SelectionLength = 0
            Me.dtpReceiptDateTo.SelectionStart = 0
            Me.dtpReceiptDateTo.Size = New System.Drawing.Size(94, 20)
            Me.dtpReceiptDateTo.TabIndex = 2
            Me.dtpReceiptDateTo.TabStop = False
            Me.dtpReceiptDateTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo.TextAlign = 0
            Me.dtpReceiptDateTo.TextValue = Nothing
            Me.dtpReceiptDateTo.ToolTipText = ""
            '
            'lblDongCode
            '
            Me.lblDongCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDongCode.Location = New System.Drawing.Point(221, 23)
            Me.lblDongCode.Name = "lblDongCode"
            Me.lblDongCode.Size = New System.Drawing.Size(54, 12)
            Me.lblDongCode.TabIndex = 469
            Me.lblDongCode.Text = "접수일자"
            Me.lblDongCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(526, 22)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(52, 16)
            Me.Label8.TabIndex = 481
            Me.Label8.Text = "작업자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label8.Visible = False
            '
            'cboWorker
            '
            Me.cboWorker.CaptionName = "시스템 구분 명"
            Me.cboWorker.ListCount = 0
            Me.cboWorker.Location = New System.Drawing.Point(579, 19)
            Me.cboWorker.Name = "cboWorker"
            Me.cboWorker.ReadOnlys = False
            Me.cboWorker.Size = New System.Drawing.Size(67, 20)
            Me.cboWorker.TabIndex = 4
            Me.cboWorker.Tag = "code(개발자 코드|전체);"
            Me.cboWorker.TextValue = ""
            Me.cboWorker.Visible = False
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.GhostWhite
            Me.Label13.Location = New System.Drawing.Point(655, 24)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(70, 11)
            Me.Label13.TabIndex = 478
            Me.Label13.Text = "게시판 순번"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label13.Visible = False
            '
            'txtDemandMatters
            '
            Me.txtDemandMatters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDemandMatters.AutoScroll = True
            Me.txtDemandMatters.BackColor = System.Drawing.SystemColors.Window
            Me.txtDemandMatters.BorderColor = System.Drawing.Color.Empty
            Me.txtDemandMatters.BorderStyle = 1
            Me.txtDemandMatters.CaptionName = "내용"
            Me.txtDemandMatters.Location = New System.Drawing.Point(18, 120)
            Me.txtDemandMatters.MaximumSize = New System.Drawing.Size(776, 70)
            Me.txtDemandMatters.MaxLength = 99999999
            Me.txtDemandMatters.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDemandMatters.Multiline = True
            Me.txtDemandMatters.Name = "txtDemandMatters"
            Me.txtDemandMatters.ReadOnlys = False
            Me.txtDemandMatters.SelectedText = ""
            Me.txtDemandMatters.SelectionLength = 0
            Me.txtDemandMatters.SelectionStart = 0
            Me.txtDemandMatters.Size = New System.Drawing.Size(83, 34)
            Me.txtDemandMatters.TabIndex = 10
            Me.txtDemandMatters.Tag = ""
            Me.txtDemandMatters.TextAlign = 0
            Me.txtDemandMatters.TextValue = ""
            Me.txtDemandMatters.ToolTipText = ""
            Me.txtDemandMatters.Visible = False
            '
            'txtManagementInternalUse
            '
            Me.txtManagementInternalUse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtManagementInternalUse.AutoScroll = True
            Me.txtManagementInternalUse.BackColor = System.Drawing.SystemColors.Window
            Me.txtManagementInternalUse.BorderColor = System.Drawing.Color.Empty
            Me.txtManagementInternalUse.BorderStyle = 1
            Me.txtManagementInternalUse.CaptionName = "내용"
            Me.txtManagementInternalUse.Location = New System.Drawing.Point(103, 120)
            Me.txtManagementInternalUse.MaximumSize = New System.Drawing.Size(776, 70)
            Me.txtManagementInternalUse.MaxLength = 99999999
            Me.txtManagementInternalUse.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtManagementInternalUse.Multiline = True
            Me.txtManagementInternalUse.Name = "txtManagementInternalUse"
            Me.txtManagementInternalUse.ReadOnlys = False
            Me.txtManagementInternalUse.SelectedText = ""
            Me.txtManagementInternalUse.SelectionLength = 0
            Me.txtManagementInternalUse.SelectionStart = 0
            Me.txtManagementInternalUse.Size = New System.Drawing.Size(78, 34)
            Me.txtManagementInternalUse.TabIndex = 11
            Me.txtManagementInternalUse.Tag = ""
            Me.txtManagementInternalUse.TextAlign = 0
            Me.txtManagementInternalUse.TextValue = ""
            Me.txtManagementInternalUse.ToolTipText = ""
            Me.txtManagementInternalUse.Visible = False
            '
            'txtOccurrenceCause
            '
            Me.txtOccurrenceCause.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOccurrenceCause.AutoScroll = True
            Me.txtOccurrenceCause.BackColor = System.Drawing.SystemColors.Window
            Me.txtOccurrenceCause.BorderColor = System.Drawing.Color.Empty
            Me.txtOccurrenceCause.BorderStyle = 1
            Me.txtOccurrenceCause.CaptionName = "내용"
            Me.txtOccurrenceCause.Location = New System.Drawing.Point(187, 120)
            Me.txtOccurrenceCause.MaximumSize = New System.Drawing.Size(776, 70)
            Me.txtOccurrenceCause.MaxLength = 99999999
            Me.txtOccurrenceCause.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOccurrenceCause.Multiline = True
            Me.txtOccurrenceCause.Name = "txtOccurrenceCause"
            Me.txtOccurrenceCause.ReadOnlys = False
            Me.txtOccurrenceCause.SelectedText = ""
            Me.txtOccurrenceCause.SelectionLength = 0
            Me.txtOccurrenceCause.SelectionStart = 0
            Me.txtOccurrenceCause.Size = New System.Drawing.Size(77, 34)
            Me.txtOccurrenceCause.TabIndex = 12
            Me.txtOccurrenceCause.Tag = ""
            Me.txtOccurrenceCause.TextAlign = 0
            Me.txtOccurrenceCause.TextValue = ""
            Me.txtOccurrenceCause.ToolTipText = ""
            Me.txtOccurrenceCause.Visible = False
            '
            'numbbsSeq
            '
            Me.numbbsSeq.BackColor = System.Drawing.SystemColors.Window
            Me.numbbsSeq.BorderColor = System.Drawing.Color.Empty
            Me.numbbsSeq.BorderStyle = 2
            Me.numbbsSeq.CaptionName = "총 지급액"
            Me.numbbsSeq.LengthPrecision = 15
            Me.numbbsSeq.LengthScale = 0
            Me.numbbsSeq.Location = New System.Drawing.Point(731, 20)
            Me.numbbsSeq.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numbbsSeq.MaxLength = 0
            Me.numbbsSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numbbsSeq.Name = "numbbsSeq"
            Me.numbbsSeq.ReadOnlys = False
            Me.numbbsSeq.SelectedText = ""
            Me.numbbsSeq.SelectionLength = 0
            Me.numbbsSeq.SelectionStart = 1
            Me.numbbsSeq.Size = New System.Drawing.Size(47, 20)
            Me.numbbsSeq.TabIndex = 6
            Me.numbbsSeq.Tag = ""
            Me.numbbsSeq.TextValue = "0"
            Me.numbbsSeq.ToolTipText = ""
            Me.numbbsSeq.Visible = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(377, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 15)
            Me.Label1.TabIndex = 481
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label1.Visible = False
            '
            'dtpReceiptDateFrom
            '
            Me.dtpReceiptDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateFrom.BorderStyle = 2
            Me.dtpReceiptDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateFrom.CaptionName = "배부 년 월"
            Me.dtpReceiptDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateFrom.Location = New System.Drawing.Point(394, 18)
            Me.dtpReceiptDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFrom.MaxLength = 0
            Me.dtpReceiptDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFrom.Name = "dtpReceiptDateFrom"
            Me.dtpReceiptDateFrom.ReadOnlys = False
            Me.dtpReceiptDateFrom.SelectedText = ""
            Me.dtpReceiptDateFrom.SelectionLength = 0
            Me.dtpReceiptDateFrom.SelectionStart = 0
            Me.dtpReceiptDateFrom.Size = New System.Drawing.Size(94, 20)
            Me.dtpReceiptDateFrom.TabIndex = 3
            Me.dtpReceiptDateFrom.TabStop = False
            Me.dtpReceiptDateFrom.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDateFrom.TextAlign = 0
            Me.dtpReceiptDateFrom.TextValue = Nothing
            Me.dtpReceiptDateFrom.ToolTipText = ""
            '
            'txtNote
            '
            Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtNote.BorderColor = System.Drawing.Color.Empty
            Me.txtNote.BorderStyle = 2
            Me.txtNote.CaptionName = "화면 ID"
            Me.txtNote.Location = New System.Drawing.Point(57, 347)
            Me.txtNote.MaxLength = 255
            Me.txtNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNote.Multiline = False
            Me.txtNote.Name = "txtNote"
            Me.txtNote.ReadOnlys = False
            Me.txtNote.SelectedText = ""
            Me.txtNote.SelectionLength = 0
            Me.txtNote.SelectionStart = 0
            Me.txtNote.Size = New System.Drawing.Size(737, 20)
            Me.txtNote.TabIndex = 6
            Me.txtNote.Tag = ""
            Me.txtNote.TextAlign = 0
            Me.txtNote.TextValue = ""
            Me.txtNote.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(16, 349)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(35, 16)
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "비고"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Location = New System.Drawing.Point(13, 378)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(785, 258)
            Me.TabControl1.TabIndex = 533
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.txtDemandMattersDummy)
            Me.TabPage1.Location = New System.Drawing.Point(4, 21)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(777, 233)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "요청사항"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'txtDemandMattersDummy
            '
            Me.txtDemandMattersDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDemandMattersDummy.Location = New System.Drawing.Point(-1, 0)
            Me.txtDemandMattersDummy.Multiline = True
            Me.txtDemandMattersDummy.Name = "txtDemandMattersDummy"
            Me.txtDemandMattersDummy.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtDemandMattersDummy.Size = New System.Drawing.Size(777, 237)
            Me.txtDemandMattersDummy.TabIndex = 17
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.txtManagementInternalUseDummy)
            Me.TabPage2.Location = New System.Drawing.Point(4, 21)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(777, 233)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "처리내용"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'txtManagementInternalUseDummy
            '
            Me.txtManagementInternalUseDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtManagementInternalUseDummy.Location = New System.Drawing.Point(0, 0)
            Me.txtManagementInternalUseDummy.Multiline = True
            Me.txtManagementInternalUseDummy.Name = "txtManagementInternalUseDummy"
            Me.txtManagementInternalUseDummy.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtManagementInternalUseDummy.Size = New System.Drawing.Size(781, 237)
            Me.txtManagementInternalUseDummy.TabIndex = 18
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.txtOccurrenceCauseDummy)
            Me.TabPage3.Location = New System.Drawing.Point(4, 21)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(777, 233)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "발생요인"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'txtOccurrenceCauseDummy
            '
            Me.txtOccurrenceCauseDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtOccurrenceCauseDummy.Location = New System.Drawing.Point(0, 0)
            Me.txtOccurrenceCauseDummy.Multiline = True
            Me.txtOccurrenceCauseDummy.Name = "txtOccurrenceCauseDummy"
            Me.txtOccurrenceCauseDummy.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtOccurrenceCauseDummy.Size = New System.Drawing.Size(781, 237)
            Me.txtOccurrenceCauseDummy.TabIndex = 19
            '
            'SMF002
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.numbbsSeq)
            Me.Controls.Add(Me.txtOccurrenceCause)
            Me.Controls.Add(Me.txtManagementInternalUse)
            Me.Controls.Add(Me.txtDemandMatters)
            Me.Controls.Add(Me.cboWorker)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.dtpReceiptDateFrom)
            Me.Controls.Add(Me.dtpReceiptDateTo)
            Me.Controls.Add(Me.lblDongCode)
            Me.Controls.Add(Me.cboSystemDivision)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblUIID)
            Me.Controls.Add(Me.txtNote)
            Me.Controls.Add(Me.txtSubject)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picIo_2_2)
            Me.Name = "SMF002"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picIo_2_2 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents txtSubject As ubiLease.CommonControls.txt
        Friend WithEvents lblUIID As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents cboSystemDivision As ubiLease.CommonControls.cbo
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents lblDongCode As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cboWorker As ubiLease.CommonControls.cbo
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtDemandMatters As ubiLease.CommonControls.txt
        Friend WithEvents txtManagementInternalUse As ubiLease.CommonControls.txt
        Friend WithEvents txtOccurrenceCause As ubiLease.CommonControls.txt
        Friend WithEvents numbbsSeq As ubiLease.CommonControls.num
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents txtNote As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents txtDemandMattersDummy As System.Windows.Forms.TextBox
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents txtManagementInternalUseDummy As System.Windows.Forms.TextBox
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents txtOccurrenceCauseDummy As System.Windows.Forms.TextBox

    End Class

End Namespace
