Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC302
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC302))
            Me.txtReaderNm = New ubiLease.CommonControls.txt
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpReceiptDt = New ubiLease.CommonControls.dtp
            Me.txtReaderCd = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.cboDivCd = New ubiLease.CommonControls.cbo
            Me.Label19 = New System.Windows.Forms.Label
            Me.cboResultInformCd = New ubiLease.CommonControls.cbo
            Me.Label20 = New System.Windows.Forms.Label
            Me.txtResultNote = New ubiLease.CommonControls.txt
            Me.Label21 = New System.Windows.Forms.Label
            Me.picIo_2_2 = New System.Windows.Forms.PictureBox
            Me.Label12 = New System.Windows.Forms.Label
            Me.cboDivCd_1 = New ubiLease.CommonControls.cbo
            Me.Label8 = New System.Windows.Forms.Label
            Me.picIo_2_1 = New System.Windows.Forms.PictureBox
            Me.cboIngStateCd = New ubiLease.CommonControls.cbo
            Me.Label22 = New System.Windows.Forms.Label
            Me.dtpReceiptDt_1 = New ubiLease.CommonControls.dtp
            Me.txtOrders = New ubiLease.CommonControls.txt
            Me.dtpMonitoringProcDt = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtContent = New ubiLease.CommonControls.txt
            Me.txtPhoneNumNote = New ubiLease.CommonControls.txt
            Me.txtReaderNmNote = New ubiLease.CommonControls.txt
            Me.txtBranchNmNote = New ubiLease.CommonControls.txt
            Me.txtAddrNote = New ubiLease.CommonControls.txt
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtDeptNm = New ubiLease.CommonControls.txt
            Me.Label18 = New System.Windows.Forms.Label
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.lblNote = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtReaderNm
            '
            Me.txtReaderNm.AccessibleDescription = ""
            Me.txtReaderNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderNm.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderNm.BorderStyle = 2
            Me.txtReaderNm.CaptionName = Nothing
            Me.txtReaderNm.Location = New System.Drawing.Point(688, 16)
            Me.txtReaderNm.MaxLength = 32767
            Me.txtReaderNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderNm.Multiline = False
            Me.txtReaderNm.Name = "txtReaderNm"
            Me.txtReaderNm.ReadOnlys = False
            Me.txtReaderNm.SelectedText = ""
            Me.txtReaderNm.SelectionLength = 0
            Me.txtReaderNm.SelectionStart = 0
            Me.txtReaderNm.Size = New System.Drawing.Size(105, 20)
            Me.txtReaderNm.TabIndex = 3
            Me.txtReaderNm.Tag = Nothing
            Me.txtReaderNm.TextAlign = 0
            Me.txtReaderNm.TextValue = ""
            Me.txtReaderNm.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(622, 18)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(60, 15)
            Me.Label9.TabIndex = 977
            Me.Label9.Text = "독자명"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(224, 18)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(90, 15)
            Me.Label11.TabIndex = 975
            Me.Label11.Text = "민원 접수일자"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(799, 40)
            Me.picCriteria.TabIndex = 974
            Me.picCriteria.TabStop = False
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
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 51)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 248)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpReceiptDt
            '
            Me.dtpReceiptDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDt.BorderStyle = 2
            Me.dtpReceiptDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDt.CaptionName = Nothing
            Me.dtpReceiptDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDt.Location = New System.Drawing.Point(320, 16)
            Me.dtpReceiptDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDt.MaxLength = 0
            Me.dtpReceiptDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDt.Name = "dtpReceiptDt"
            Me.dtpReceiptDt.ReadOnlys = False
            Me.dtpReceiptDt.SelectedText = ""
            Me.dtpReceiptDt.SelectionLength = 0
            Me.dtpReceiptDt.SelectionStart = 0
            Me.dtpReceiptDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpReceiptDt.TabIndex = 1
            Me.dtpReceiptDt.Tag = "format(####-##-##);"
            Me.dtpReceiptDt.TextAlign = 0
            Me.dtpReceiptDt.TextValue = ""
            Me.dtpReceiptDt.ToolTipText = ""
            '
            'txtReaderCd
            '
            Me.txtReaderCd.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderCd.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderCd.BorderStyle = 2
            Me.txtReaderCd.CaptionName = Nothing
            Me.txtReaderCd.Location = New System.Drawing.Point(516, 16)
            Me.txtReaderCd.MaxLength = 32767
            Me.txtReaderCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderCd.Multiline = False
            Me.txtReaderCd.Name = "txtReaderCd"
            Me.txtReaderCd.ReadOnlys = False
            Me.txtReaderCd.SelectedText = ""
            Me.txtReaderCd.SelectionLength = 0
            Me.txtReaderCd.SelectionStart = 0
            Me.txtReaderCd.Size = New System.Drawing.Size(100, 20)
            Me.txtReaderCd.TabIndex = 2
            Me.txtReaderCd.Tag = Nothing
            Me.txtReaderCd.TextAlign = 0
            Me.txtReaderCd.TextValue = ""
            Me.txtReaderCd.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(450, 18)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 15)
            Me.Label3.TabIndex = 984
            Me.Label3.Text = "독자코드"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboDivCd
            '
            Me.cboDivCd.CaptionName = ""
            Me.cboDivCd.ListCount = 0
            Me.cboDivCd.Location = New System.Drawing.Point(96, 16)
            Me.cboDivCd.Name = "cboDivCd"
            Me.cboDivCd.ReadOnlys = False
            Me.cboDivCd.Size = New System.Drawing.Size(122, 20)
            Me.cboDivCd.TabIndex = 0
            Me.cboDivCd.Tag = "code(민원구분코드);"
            Me.cboDivCd.TextValue = ""
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label19.Location = New System.Drawing.Point(30, 18)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(60, 15)
            Me.Label19.TabIndex = 986
            Me.Label19.Text = "민원 구분"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboResultInformCd
            '
            Me.cboResultInformCd.CaptionName = "지국통보 코드"
            Me.cboResultInformCd.ListCount = 0
            Me.cboResultInformCd.Location = New System.Drawing.Point(110, 544)
            Me.cboResultInformCd.Name = "cboResultInformCd"
            Me.cboResultInformCd.ReadOnlys = False
            Me.cboResultInformCd.Size = New System.Drawing.Size(130, 20)
            Me.cboResultInformCd.TabIndex = 13
            Me.cboResultInformCd.Tag = "code(민원지국통보코드|전체);"
            Me.cboResultInformCd.TextValue = ""
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.GhostWhite
            Me.Label20.Location = New System.Drawing.Point(21, 546)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(84, 18)
            Me.Label20.TabIndex = 998
            Me.Label20.Text = "지국통보"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtResultNote
            '
            Me.txtResultNote.AutoScroll = True
            Me.txtResultNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtResultNote.BorderColor = System.Drawing.Color.Empty
            Me.txtResultNote.BorderStyle = 2
            Me.txtResultNote.CaptionName = "내용"
            Me.txtResultNote.Location = New System.Drawing.Point(110, 572)
            Me.txtResultNote.MaxLength = 99999999
            Me.txtResultNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtResultNote.Multiline = False
            Me.txtResultNote.Name = "txtResultNote"
            Me.txtResultNote.ReadOnlys = False
            Me.txtResultNote.SelectedText = ""
            Me.txtResultNote.SelectionLength = 0
            Me.txtResultNote.SelectionStart = 0
            Me.txtResultNote.Size = New System.Drawing.Size(683, 20)
            Me.txtResultNote.TabIndex = 16
            Me.txtResultNote.Tag = ""
            Me.txtResultNote.TextAlign = 0
            Me.txtResultNote.TextValue = ""
            Me.txtResultNote.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(21, 572)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(84, 18)
            Me.Label21.TabIndex = 1003
            Me.Label21.Text = "처리결과"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_2_2
            '
            Me.picIo_2_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_2.Location = New System.Drawing.Point(6, 536)
            Me.picIo_2_2.Name = "picIo_2_2"
            Me.picIo_2_2.Size = New System.Drawing.Size(799, 105)
            Me.picIo_2_2.TabIndex = 988
            Me.picIo_2_2.TabStop = False
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(21, 341)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(84, 18)
            Me.Label12.TabIndex = 1057
            Me.Label12.Text = "민원 접수일"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboDivCd_1
            '
            Me.cboDivCd_1.CaptionName = "민원구분 코드"
            Me.cboDivCd_1.ListCount = 0
            Me.cboDivCd_1.Location = New System.Drawing.Point(111, 313)
            Me.cboDivCd_1.Name = "cboDivCd_1"
            Me.cboDivCd_1.ReadOnlys = False
            Me.cboDivCd_1.Size = New System.Drawing.Size(130, 20)
            Me.cboDivCd_1.TabIndex = 5
            Me.cboDivCd_1.Tag = "code(민원구분코드);"
            Me.cboDivCd_1.TextValue = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.GhostWhite
            Me.Label8.Location = New System.Drawing.Point(21, 315)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(84, 18)
            Me.Label8.TabIndex = 1054
            Me.Label8.Text = "민원 구분"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_2_1
            '
            Me.picIo_2_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_1.Location = New System.Drawing.Point(6, 305)
            Me.picIo_2_1.Name = "picIo_2_1"
            Me.picIo_2_1.Size = New System.Drawing.Size(799, 225)
            Me.picIo_2_1.TabIndex = 1050
            Me.picIo_2_1.TabStop = False
            '
            'cboIngStateCd
            '
            Me.cboIngStateCd.CaptionName = "처리 진행 코드"
            Me.cboIngStateCd.ListCount = 0
            Me.cboIngStateCd.Location = New System.Drawing.Point(406, 546)
            Me.cboIngStateCd.Name = "cboIngStateCd"
            Me.cboIngStateCd.ReadOnlys = False
            Me.cboIngStateCd.Size = New System.Drawing.Size(130, 20)
            Me.cboIngStateCd.TabIndex = 14
            Me.cboIngStateCd.Tag = "code(진행상태코드|전체);"
            Me.cboIngStateCd.TextValue = ""
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.GhostWhite
            Me.Label22.Location = New System.Drawing.Point(316, 546)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(84, 18)
            Me.Label22.TabIndex = 1099
            Me.Label22.Text = "진행상태"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDt_1
            '
            Me.dtpReceiptDt_1.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDt_1.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDt_1.BorderStyle = 2
            Me.dtpReceiptDt_1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDt_1.CaptionName = "민원접수일"
            Me.dtpReceiptDt_1.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDt_1.Location = New System.Drawing.Point(111, 341)
            Me.dtpReceiptDt_1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDt_1.MaxLength = 0
            Me.dtpReceiptDt_1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDt_1.Name = "dtpReceiptDt_1"
            Me.dtpReceiptDt_1.ReadOnlys = False
            Me.dtpReceiptDt_1.SelectedText = ""
            Me.dtpReceiptDt_1.SelectionLength = 0
            Me.dtpReceiptDt_1.SelectionStart = 0
            Me.dtpReceiptDt_1.Size = New System.Drawing.Size(100, 20)
            Me.dtpReceiptDt_1.TabIndex = 6
            Me.dtpReceiptDt_1.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDt_1.TextAlign = 0
            Me.dtpReceiptDt_1.TextValue = ""
            Me.dtpReceiptDt_1.ToolTipText = ""
            '
            'txtOrders
            '
            Me.txtOrders.BackColor = System.Drawing.SystemColors.Window
            Me.txtOrders.BorderColor = System.Drawing.Color.Empty
            Me.txtOrders.BorderStyle = 2
            Me.txtOrders.CaptionName = "순번"
            Me.txtOrders.Location = New System.Drawing.Point(688, 313)
            Me.txtOrders.MaxLength = 32767
            Me.txtOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOrders.Multiline = False
            Me.txtOrders.Name = "txtOrders"
            Me.txtOrders.ReadOnlys = False
            Me.txtOrders.SelectedText = ""
            Me.txtOrders.SelectionLength = 0
            Me.txtOrders.SelectionStart = 0
            Me.txtOrders.Size = New System.Drawing.Size(100, 20)
            Me.txtOrders.TabIndex = 1104
            Me.txtOrders.Tag = Nothing
            Me.txtOrders.TextAlign = 0
            Me.txtOrders.TextValue = ""
            Me.txtOrders.ToolTipText = ""
            Me.txtOrders.Visible = False
            '
            'dtpMonitoringProcDt
            '
            Me.dtpMonitoringProcDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMonitoringProcDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpMonitoringProcDt.BorderStyle = 2
            Me.dtpMonitoringProcDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMonitoringProcDt.CaptionName = "처리일자"
            Me.dtpMonitoringProcDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpMonitoringProcDt.Location = New System.Drawing.Point(693, 544)
            Me.dtpMonitoringProcDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMonitoringProcDt.MaxLength = 0
            Me.dtpMonitoringProcDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMonitoringProcDt.Name = "dtpMonitoringProcDt"
            Me.dtpMonitoringProcDt.ReadOnlys = False
            Me.dtpMonitoringProcDt.SelectedText = ""
            Me.dtpMonitoringProcDt.SelectionLength = 0
            Me.dtpMonitoringProcDt.SelectionStart = 0
            Me.dtpMonitoringProcDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpMonitoringProcDt.TabIndex = 15
            Me.dtpMonitoringProcDt.Tag = "format(####-##-##);"
            Me.dtpMonitoringProcDt.TextAlign = 0
            Me.dtpMonitoringProcDt.TextValue = ""
            Me.dtpMonitoringProcDt.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Location = New System.Drawing.Point(603, 544)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 18)
            Me.Label1.TabIndex = 1106
            Me.Label1.Text = "처리일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtContent
            '
            Me.txtContent.BackColor = System.Drawing.SystemColors.Window
            Me.txtContent.BorderColor = System.Drawing.Color.Empty
            Me.txtContent.BorderStyle = 2
            Me.txtContent.CaptionName = "민원 내용"
            Me.txtContent.Location = New System.Drawing.Point(111, 451)
            Me.txtContent.MaximumSize = New System.Drawing.Size(645, 70)
            Me.txtContent.MaxLength = 32767
            Me.txtContent.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtContent.Multiline = True
            Me.txtContent.Name = "txtContent"
            Me.txtContent.ReadOnlys = False
            Me.txtContent.SelectedText = ""
            Me.txtContent.SelectionLength = 0
            Me.txtContent.SelectionStart = 0
            Me.txtContent.Size = New System.Drawing.Size(640, 70)
            Me.txtContent.TabIndex = 12
            Me.txtContent.Tag = Nothing
            Me.txtContent.TextAlign = 0
            Me.txtContent.TextValue = ""
            Me.txtContent.ToolTipText = ""
            '
            'txtPhoneNumNote
            '
            Me.txtPhoneNumNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNumNote.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNumNote.BorderStyle = 2
            Me.txtPhoneNumNote.CaptionName = "전화번호2"
            Me.txtPhoneNumNote.Location = New System.Drawing.Point(503, 369)
            Me.txtPhoneNumNote.MaxLength = 12
            Me.txtPhoneNumNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNumNote.Multiline = False
            Me.txtPhoneNumNote.Name = "txtPhoneNumNote"
            Me.txtPhoneNumNote.ReadOnlys = False
            Me.txtPhoneNumNote.SelectedText = ""
            Me.txtPhoneNumNote.SelectionLength = 0
            Me.txtPhoneNumNote.SelectionStart = 0
            Me.txtPhoneNumNote.Size = New System.Drawing.Size(257, 20)
            Me.txtPhoneNumNote.TabIndex = 8
            Me.txtPhoneNumNote.Tag = ""
            Me.txtPhoneNumNote.TextAlign = 0
            Me.txtPhoneNumNote.TextValue = ""
            Me.txtPhoneNumNote.ToolTipText = ""
            '
            'txtReaderNmNote
            '
            Me.txtReaderNmNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderNmNote.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderNmNote.BorderStyle = 2
            Me.txtReaderNmNote.CaptionName = "독자 명"
            Me.txtReaderNmNote.Location = New System.Drawing.Point(111, 369)
            Me.txtReaderNmNote.MaxLength = 32767
            Me.txtReaderNmNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderNmNote.Multiline = False
            Me.txtReaderNmNote.Name = "txtReaderNmNote"
            Me.txtReaderNmNote.ReadOnlys = False
            Me.txtReaderNmNote.SelectedText = ""
            Me.txtReaderNmNote.SelectionLength = 0
            Me.txtReaderNmNote.SelectionStart = 0
            Me.txtReaderNmNote.Size = New System.Drawing.Size(290, 20)
            Me.txtReaderNmNote.TabIndex = 7
            Me.txtReaderNmNote.Tag = Nothing
            Me.txtReaderNmNote.TextAlign = 0
            Me.txtReaderNmNote.TextValue = ""
            Me.txtReaderNmNote.ToolTipText = ""
            '
            'txtBranchNmNote
            '
            Me.txtBranchNmNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNmNote.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNmNote.BorderStyle = 2
            Me.txtBranchNmNote.CaptionName = "지국"
            Me.txtBranchNmNote.Location = New System.Drawing.Point(503, 398)
            Me.txtBranchNmNote.MaxLength = 32767
            Me.txtBranchNmNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNmNote.Multiline = False
            Me.txtBranchNmNote.Name = "txtBranchNmNote"
            Me.txtBranchNmNote.ReadOnlys = False
            Me.txtBranchNmNote.SelectedText = ""
            Me.txtBranchNmNote.SelectionLength = 0
            Me.txtBranchNmNote.SelectionStart = 0
            Me.txtBranchNmNote.Size = New System.Drawing.Size(257, 20)
            Me.txtBranchNmNote.TabIndex = 10
            Me.txtBranchNmNote.Tag = Nothing
            Me.txtBranchNmNote.TextAlign = 0
            Me.txtBranchNmNote.TextValue = ""
            Me.txtBranchNmNote.ToolTipText = ""
            '
            'txtAddrNote
            '
            Me.txtAddrNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddrNote.BorderColor = System.Drawing.Color.Empty
            Me.txtAddrNote.BorderStyle = 2
            Me.txtAddrNote.CaptionName = "주소"
            Me.txtAddrNote.Location = New System.Drawing.Point(111, 425)
            Me.txtAddrNote.MaxLength = 32767
            Me.txtAddrNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddrNote.Multiline = False
            Me.txtAddrNote.Name = "txtAddrNote"
            Me.txtAddrNote.ReadOnlys = False
            Me.txtAddrNote.SelectedText = ""
            Me.txtAddrNote.SelectionLength = 0
            Me.txtAddrNote.SelectionStart = 0
            Me.txtAddrNote.Size = New System.Drawing.Size(649, 20)
            Me.txtAddrNote.TabIndex = 11
            Me.txtAddrNote.Tag = Nothing
            Me.txtAddrNote.TextAlign = 0
            Me.txtAddrNote.TextValue = ""
            Me.txtAddrNote.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(21, 370)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(84, 18)
            Me.Label4.TabIndex = 1195
            Me.Label4.Text = "독자명"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtDeptNm
            '
            Me.txtDeptNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeptNm.BorderColor = System.Drawing.Color.Empty
            Me.txtDeptNm.BorderStyle = 2
            Me.txtDeptNm.CaptionName = "신주소"
            Me.txtDeptNm.Location = New System.Drawing.Point(111, 398)
            Me.txtDeptNm.MaxLength = 40
            Me.txtDeptNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDeptNm.Multiline = False
            Me.txtDeptNm.Name = "txtDeptNm"
            Me.txtDeptNm.ReadOnlys = False
            Me.txtDeptNm.SelectedText = ""
            Me.txtDeptNm.SelectionLength = 0
            Me.txtDeptNm.SelectionStart = 0
            Me.txtDeptNm.Size = New System.Drawing.Size(290, 20)
            Me.txtDeptNm.TabIndex = 9
            Me.txtDeptNm.Tag = ""
            Me.txtDeptNm.TextAlign = 0
            Me.txtDeptNm.TextValue = ""
            Me.txtDeptNm.ToolTipText = ""
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.GhostWhite
            Me.Label18.Location = New System.Drawing.Point(19, 399)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(84, 18)
            Me.Label18.TabIndex = 1193
            Me.Label18.Text = "부명"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.GhostWhite
            Me.Label15.Location = New System.Drawing.Point(417, 399)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(84, 18)
            Me.Label15.TabIndex = 1192
            Me.Label15.Text = "지국 "
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.GhostWhite
            Me.Label10.Location = New System.Drawing.Point(21, 426)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(84, 18)
            Me.Label10.TabIndex = 1191
            Me.Label10.Text = "주소 비고"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.GhostWhite
            Me.Label13.Location = New System.Drawing.Point(414, 370)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(84, 18)
            Me.Label13.TabIndex = 1190
            Me.Label13.Text = "전화번호"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblNote.Location = New System.Drawing.Point(21, 459)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(84, 18)
            Me.lblNote.TabIndex = 1188
            Me.lblNote.Text = "민원 내용"
            Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNC302
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtContent)
            Me.Controls.Add(Me.txtPhoneNumNote)
            Me.Controls.Add(Me.txtReaderNmNote)
            Me.Controls.Add(Me.txtBranchNmNote)
            Me.Controls.Add(Me.txtAddrNote)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtDeptNm)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpMonitoringProcDt)
            Me.Controls.Add(Me.txtOrders)
            Me.Controls.Add(Me.dtpReceiptDt_1)
            Me.Controls.Add(Me.cboIngStateCd)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.cboDivCd_1)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.txtResultNote)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.cboResultInformCd)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.cboDivCd)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.txtReaderCd)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpReceiptDt)
            Me.Controls.Add(Me.txtReaderNm)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.picIo_2_1)
            Me.Controls.Add(Me.picIo_2_2)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNC302"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtReaderNm As ubiLease.CommonControls.txt
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpReceiptDt As ubiLease.CommonControls.dtp
        Friend WithEvents txtReaderCd As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboDivCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cboResultInformCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtResultNote As ubiLease.CommonControls.txt
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents picIo_2_2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents cboDivCd_1 As ubiLease.CommonControls.cbo
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents picIo_2_1 As System.Windows.Forms.PictureBox
        Friend WithEvents cboIngStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDt_1 As ubiLease.CommonControls.dtp
        Friend WithEvents txtOrders As ubiLease.CommonControls.txt
        Friend WithEvents dtpMonitoringProcDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtContent As ubiLease.CommonControls.txt
        Friend WithEvents txtPhoneNumNote As ubiLease.CommonControls.txt
        Friend WithEvents txtReaderNmNote As ubiLease.CommonControls.txt
        Friend WithEvents txtBranchNmNote As ubiLease.CommonControls.txt
        Friend WithEvents txtAddrNote As ubiLease.CommonControls.txt
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtDeptNm As ubiLease.CommonControls.txt
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents lblNote As System.Windows.Forms.Label


    End Class

End Namespace
