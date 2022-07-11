Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC301))
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label21 = New System.Windows.Forms.Label
            Me.btnPRB002 = New ubiLease.CommonControls.btn
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtDeptNm = New ubiLease.CommonControls.txt
            Me.Label18 = New System.Windows.Forms.Label
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.dtpReceiptDt = New ubiLease.CommonControls.dtp
            Me.cboDivCd = New ubiLease.CommonControls.cbo
            Me.Label19 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblNote = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.Label11 = New System.Windows.Forms.Label
            Me.txtReaderCd = New ubiLease.CommonControls.txt
            Me.Label9 = New System.Windows.Forms.Label
            Me.txtReaderNm = New ubiLease.CommonControls.txt
            Me.Label8 = New System.Windows.Forms.Label
            Me.txtPhoneNum = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtNewAddr = New ubiLease.CommonControls.txt
            Me.picCriteria_2 = New System.Windows.Forms.PictureBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpToReceiptDt = New ubiLease.CommonControls.dtp
            Me.Label28 = New System.Windows.Forms.Label
            Me.dtpFromReceiptDt = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.Dtp1 = New ubiLease.CommonControls.dtp
            Me.txtAddrNote = New ubiLease.CommonControls.txt
            Me.txtBranchNmNote = New ubiLease.CommonControls.txt
            Me.txtReaderNmNote = New ubiLease.CommonControls.txt
            Me.txtPhoneNumNote = New ubiLease.CommonControls.txt
            Me.txtContent = New ubiLease.CommonControls.txt
            Me.txtDateTime = New System.Windows.Forms.TextBox
            Me.txtSubscribeCd = New System.Windows.Forms.TextBox
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_2.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(7, 229)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 15
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(799, 121)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 8
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label21.Location = New System.Drawing.Point(6, 167)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(62, 12)
            Me.Label21.TabIndex = 1122
            Me.Label21.Text = "민원 정보"
            '
            'btnPRB002
            '
            Me.btnPRB002.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnPRB002.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnPRB002.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnPRB002.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnPRB002.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnPRB002.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnPRB002.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnPRB002.Location = New System.Drawing.Point(631, 371)
            Me.btnPRB002.Name = "btnPRB002"
            Me.btnPRB002.Size = New System.Drawing.Size(120, 32)
            Me.btnPRB002.TabIndex = 17
            Me.btnPRB002.TabStop = False
            Me.btnPRB002.Text = "민원 결과 등록"
            Me.btnPRB002.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(21, 431)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(84, 18)
            Me.Label4.TabIndex = 1120
            Me.Label4.Text = "독자명"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtDeptNm
            '
            Me.txtDeptNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeptNm.BorderColor = System.Drawing.Color.Empty
            Me.txtDeptNm.BorderStyle = 2
            Me.txtDeptNm.CaptionName = "신주소"
            Me.txtDeptNm.Location = New System.Drawing.Point(111, 459)
            Me.txtDeptNm.MaxLength = 40
            Me.txtDeptNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDeptNm.Multiline = False
            Me.txtDeptNm.Name = "txtDeptNm"
            Me.txtDeptNm.ReadOnlys = False
            Me.txtDeptNm.SelectedText = ""
            Me.txtDeptNm.SelectionLength = 0
            Me.txtDeptNm.SelectionStart = 0
            Me.txtDeptNm.Size = New System.Drawing.Size(290, 20)
            Me.txtDeptNm.TabIndex = 6
            Me.txtDeptNm.Tag = ""
            Me.txtDeptNm.TextAlign = 0
            Me.txtDeptNm.TextValue = ""
            Me.txtDeptNm.ToolTipText = ""
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.GhostWhite
            Me.Label18.Location = New System.Drawing.Point(19, 460)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(84, 18)
            Me.Label18.TabIndex = 1114
            Me.Label18.Text = "부명"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.GhostWhite
            Me.Label15.Location = New System.Drawing.Point(417, 460)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(84, 18)
            Me.Label15.TabIndex = 1113
            Me.Label15.Text = "지국 "
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.GhostWhite
            Me.Label10.Location = New System.Drawing.Point(21, 487)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(84, 18)
            Me.Label10.TabIndex = 1112
            Me.Label10.Text = "주소 비고"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.GhostWhite
            Me.Label13.Location = New System.Drawing.Point(414, 431)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(84, 18)
            Me.Label13.TabIndex = 1111
            Me.Label13.Text = "전화번호"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(22, 405)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(84, 18)
            Me.Label12.TabIndex = 1110
            Me.Label12.Text = "접수일시"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDt
            '
            Me.dtpReceiptDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDt.BorderStyle = 2
            Me.dtpReceiptDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDt.CaptionName = Nothing
            Me.dtpReceiptDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDt.Enabled = False
            Me.dtpReceiptDt.Location = New System.Drawing.Point(111, 404)
            Me.dtpReceiptDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDt.MaxLength = 0
            Me.dtpReceiptDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDt.Name = "dtpReceiptDt"
            Me.dtpReceiptDt.ReadOnlys = True
            Me.dtpReceiptDt.SelectedText = ""
            Me.dtpReceiptDt.SelectionLength = 0
            Me.dtpReceiptDt.SelectionStart = 0
            Me.dtpReceiptDt.Size = New System.Drawing.Size(130, 20)
            Me.dtpReceiptDt.TabIndex = 2
            Me.dtpReceiptDt.Tag = "read;format(&&&&-&&-&&);"
            Me.dtpReceiptDt.TextAlign = 0
            Me.dtpReceiptDt.TextValue = ""
            Me.dtpReceiptDt.ToolTipText = ""
            '
            'cboDivCd
            '
            Me.cboDivCd.CaptionName = "민원구분 코드"
            Me.cboDivCd.ListCount = 0
            Me.cboDivCd.Location = New System.Drawing.Point(111, 377)
            Me.cboDivCd.Name = "cboDivCd"
            Me.cboDivCd.ReadOnlys = False
            Me.cboDivCd.Size = New System.Drawing.Size(130, 20)
            Me.cboDivCd.TabIndex = 1
            Me.cboDivCd.Tag = "code(민원구분코드);"
            Me.cboDivCd.TextValue = ""
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.GhostWhite
            Me.Label19.Location = New System.Drawing.Point(21, 378)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(84, 18)
            Me.Label19.TabIndex = 1107
            Me.Label19.Text = "민원 구분"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_1.Location = New System.Drawing.Point(7, 50)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 109)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblNote.Location = New System.Drawing.Point(21, 520)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(84, 18)
            Me.lblNote.TabIndex = 1084
            Me.lblNote.Text = "민원 내용"
            Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.MistyRose
            Me.Label14.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label14.Location = New System.Drawing.Point(111, 585)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(649, 23)
            Me.Label14.TabIndex = 1085
            Me.Label14.Text = "비고란은 100자 이내로 입력 가능합니다."
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(9, 356)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(799, 275)
            Me.picIo_2.TabIndex = 1083
            Me.picIo_2.TabStop = False
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(7, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 40)
            Me.picCriteria_1.TabIndex = 1098
            Me.picCriteria_1.TabStop = False
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(21, 20)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(65, 15)
            Me.Label11.TabIndex = 1099
            Me.Label11.Text = "독자코드"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReaderCd
            '
            Me.txtReaderCd.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderCd.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderCd.BorderStyle = 2
            Me.txtReaderCd.CaptionName = Nothing
            Me.txtReaderCd.Location = New System.Drawing.Point(92, 15)
            Me.txtReaderCd.MaxLength = 32767
            Me.txtReaderCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderCd.Multiline = False
            Me.txtReaderCd.Name = "txtReaderCd"
            Me.txtReaderCd.ReadOnlys = False
            Me.txtReaderCd.SelectedText = ""
            Me.txtReaderCd.SelectionLength = 0
            Me.txtReaderCd.SelectionStart = 0
            Me.txtReaderCd.Size = New System.Drawing.Size(115, 20)
            Me.txtReaderCd.TabIndex = 0
            Me.txtReaderCd.Tag = Nothing
            Me.txtReaderCd.TextAlign = 0
            Me.txtReaderCd.TextValue = ""
            Me.txtReaderCd.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(213, 20)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(65, 15)
            Me.Label9.TabIndex = 1101
            Me.Label9.Text = "독자명"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReaderNm
            '
            Me.txtReaderNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderNm.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderNm.BorderStyle = 2
            Me.txtReaderNm.CaptionName = Nothing
            Me.txtReaderNm.Location = New System.Drawing.Point(284, 15)
            Me.txtReaderNm.MaxLength = 32767
            Me.txtReaderNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderNm.Multiline = False
            Me.txtReaderNm.Name = "txtReaderNm"
            Me.txtReaderNm.ReadOnlys = False
            Me.txtReaderNm.SelectedText = ""
            Me.txtReaderNm.SelectionLength = 0
            Me.txtReaderNm.SelectionStart = 0
            Me.txtReaderNm.Size = New System.Drawing.Size(115, 20)
            Me.txtReaderNm.TabIndex = 1
            Me.txtReaderNm.Tag = Nothing
            Me.txtReaderNm.TextAlign = 0
            Me.txtReaderNm.TextValue = ""
            Me.txtReaderNm.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(405, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(65, 15)
            Me.Label8.TabIndex = 1103
            Me.Label8.Text = "전화번호"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum
            '
            Me.txtPhoneNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum.BorderStyle = 2
            Me.txtPhoneNum.CaptionName = "전화번호1"
            Me.txtPhoneNum.Location = New System.Drawing.Point(476, 15)
            Me.txtPhoneNum.MaxLength = 12
            Me.txtPhoneNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum.Multiline = False
            Me.txtPhoneNum.Name = "txtPhoneNum"
            Me.txtPhoneNum.ReadOnlys = False
            Me.txtPhoneNum.SelectedText = ""
            Me.txtPhoneNum.SelectionLength = 0
            Me.txtPhoneNum.SelectionStart = 0
            Me.txtPhoneNum.Size = New System.Drawing.Size(115, 20)
            Me.txtPhoneNum.TabIndex = 2
            Me.txtPhoneNum.Tag = ""
            Me.txtPhoneNum.TextAlign = 0
            Me.txtPhoneNum.TextValue = ""
            Me.txtPhoneNum.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(597, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(65, 15)
            Me.Label3.TabIndex = 1105
            Me.Label3.Text = "주소"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNewAddr
            '
            Me.txtNewAddr.BackColor = System.Drawing.SystemColors.Window
            Me.txtNewAddr.BorderColor = System.Drawing.Color.Empty
            Me.txtNewAddr.BorderStyle = 2
            Me.txtNewAddr.CaptionName = "전화번호1"
            Me.txtNewAddr.Location = New System.Drawing.Point(668, 15)
            Me.txtNewAddr.MaxLength = 12
            Me.txtNewAddr.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNewAddr.Multiline = False
            Me.txtNewAddr.Name = "txtNewAddr"
            Me.txtNewAddr.ReadOnlys = False
            Me.txtNewAddr.SelectedText = ""
            Me.txtNewAddr.SelectionLength = 0
            Me.txtNewAddr.SelectionStart = 0
            Me.txtNewAddr.Size = New System.Drawing.Size(115, 20)
            Me.txtNewAddr.TabIndex = 3
            Me.txtNewAddr.Tag = ""
            Me.txtNewAddr.TextAlign = 0
            Me.txtNewAddr.TextValue = ""
            Me.txtNewAddr.ToolTipText = ""
            '
            'picCriteria_2
            '
            Me.picCriteria_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_2.Location = New System.Drawing.Point(7, 183)
            Me.picCriteria_2.Name = "picCriteria_2"
            Me.picCriteria_2.Size = New System.Drawing.Size(799, 40)
            Me.picCriteria_2.TabIndex = 1142
            Me.picCriteria_2.TabStop = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(206, 192)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(15, 20)
            Me.Label1.TabIndex = 1180
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpToReceiptDt
            '
            Me.dtpToReceiptDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToReceiptDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpToReceiptDt.BorderStyle = 2
            Me.dtpToReceiptDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToReceiptDt.CaptionName = Nothing
            Me.dtpToReceiptDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToReceiptDt.Location = New System.Drawing.Point(221, 192)
            Me.dtpToReceiptDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToReceiptDt.MaxLength = 0
            Me.dtpToReceiptDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToReceiptDt.Name = "dtpToReceiptDt"
            Me.dtpToReceiptDt.ReadOnlys = False
            Me.dtpToReceiptDt.SelectedText = ""
            Me.dtpToReceiptDt.SelectionLength = 0
            Me.dtpToReceiptDt.SelectionStart = 0
            Me.dtpToReceiptDt.Size = New System.Drawing.Size(115, 20)
            Me.dtpToReceiptDt.TabIndex = 6
            Me.dtpToReceiptDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpToReceiptDt.TextAlign = 0
            Me.dtpToReceiptDt.TextValue = ""
            Me.dtpToReceiptDt.ToolTipText = ""
            '
            'Label28
            '
            Me.Label28.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label28.Location = New System.Drawing.Point(11, 196)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(75, 15)
            Me.Label28.TabIndex = 1178
            Me.Label28.Text = "접수기간"
            Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpFromReceiptDt
            '
            Me.dtpFromReceiptDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromReceiptDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromReceiptDt.BorderStyle = 2
            Me.dtpFromReceiptDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromReceiptDt.CaptionName = Nothing
            Me.dtpFromReceiptDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromReceiptDt.Location = New System.Drawing.Point(92, 192)
            Me.dtpFromReceiptDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromReceiptDt.MaxLength = 0
            Me.dtpFromReceiptDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromReceiptDt.Name = "dtpFromReceiptDt"
            Me.dtpFromReceiptDt.ReadOnlys = False
            Me.dtpFromReceiptDt.SelectedText = ""
            Me.dtpFromReceiptDt.SelectionLength = 0
            Me.dtpFromReceiptDt.SelectionStart = 0
            Me.dtpFromReceiptDt.Size = New System.Drawing.Size(115, 20)
            Me.dtpFromReceiptDt.TabIndex = 5
            Me.dtpFromReceiptDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpFromReceiptDt.TextAlign = 0
            Me.dtpFromReceiptDt.TextValue = ""
            Me.dtpFromReceiptDt.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(556, 195)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 15)
            Me.Label2.TabIndex = 1182
            Me.Label2.Text = "접수일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Visible = False
            '
            'Dtp1
            '
            Me.Dtp1.BackColor = System.Drawing.SystemColors.Window
            Me.Dtp1.BorderColor = System.Drawing.Color.Empty
            Me.Dtp1.BorderStyle = 2
            Me.Dtp1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Dtp1.CaptionName = Nothing
            Me.Dtp1.DateTimeFormatText = ""
            Me.Dtp1.Location = New System.Drawing.Point(622, 192)
            Me.Dtp1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Dtp1.MaxLength = 0
            Me.Dtp1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Dtp1.Name = "Dtp1"
            Me.Dtp1.ReadOnlys = False
            Me.Dtp1.SelectedText = ""
            Me.Dtp1.SelectionLength = 0
            Me.Dtp1.SelectionStart = 0
            Me.Dtp1.Size = New System.Drawing.Size(115, 20)
            Me.Dtp1.TabIndex = 7
            Me.Dtp1.Tag = resources.GetString("Dtp1.Tag")
            Me.Dtp1.TextAlign = 0
            Me.Dtp1.TextValue = ""
            Me.Dtp1.ToolTipText = ""
            Me.Dtp1.Visible = False
            '
            'txtAddrNote
            '
            Me.txtAddrNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddrNote.BorderColor = System.Drawing.Color.Empty
            Me.txtAddrNote.BorderStyle = 2
            Me.txtAddrNote.CaptionName = "주소"
            Me.txtAddrNote.Location = New System.Drawing.Point(111, 486)
            Me.txtAddrNote.MaxLength = 32767
            Me.txtAddrNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddrNote.Multiline = False
            Me.txtAddrNote.Name = "txtAddrNote"
            Me.txtAddrNote.ReadOnlys = False
            Me.txtAddrNote.SelectedText = ""
            Me.txtAddrNote.SelectionLength = 0
            Me.txtAddrNote.SelectionStart = 0
            Me.txtAddrNote.Size = New System.Drawing.Size(649, 20)
            Me.txtAddrNote.TabIndex = 8
            Me.txtAddrNote.Tag = Nothing
            Me.txtAddrNote.TextAlign = 0
            Me.txtAddrNote.TextValue = ""
            Me.txtAddrNote.ToolTipText = ""
            '
            'txtBranchNmNote
            '
            Me.txtBranchNmNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNmNote.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNmNote.BorderStyle = 2
            Me.txtBranchNmNote.CaptionName = "지국"
            Me.txtBranchNmNote.Location = New System.Drawing.Point(503, 459)
            Me.txtBranchNmNote.MaxLength = 32767
            Me.txtBranchNmNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNmNote.Multiline = False
            Me.txtBranchNmNote.Name = "txtBranchNmNote"
            Me.txtBranchNmNote.ReadOnlys = False
            Me.txtBranchNmNote.SelectedText = ""
            Me.txtBranchNmNote.SelectionLength = 0
            Me.txtBranchNmNote.SelectionStart = 0
            Me.txtBranchNmNote.Size = New System.Drawing.Size(257, 20)
            Me.txtBranchNmNote.TabIndex = 7
            Me.txtBranchNmNote.Tag = Nothing
            Me.txtBranchNmNote.TextAlign = 0
            Me.txtBranchNmNote.TextValue = ""
            Me.txtBranchNmNote.ToolTipText = ""
            '
            'txtReaderNmNote
            '
            Me.txtReaderNmNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderNmNote.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderNmNote.BorderStyle = 2
            Me.txtReaderNmNote.CaptionName = "독자 명"
            Me.txtReaderNmNote.Location = New System.Drawing.Point(111, 430)
            Me.txtReaderNmNote.MaxLength = 32767
            Me.txtReaderNmNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderNmNote.Multiline = False
            Me.txtReaderNmNote.Name = "txtReaderNmNote"
            Me.txtReaderNmNote.ReadOnlys = False
            Me.txtReaderNmNote.SelectedText = ""
            Me.txtReaderNmNote.SelectionLength = 0
            Me.txtReaderNmNote.SelectionStart = 0
            Me.txtReaderNmNote.Size = New System.Drawing.Size(290, 20)
            Me.txtReaderNmNote.TabIndex = 4
            Me.txtReaderNmNote.Tag = Nothing
            Me.txtReaderNmNote.TextAlign = 0
            Me.txtReaderNmNote.TextValue = ""
            Me.txtReaderNmNote.ToolTipText = ""
            '
            'txtPhoneNumNote
            '
            Me.txtPhoneNumNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNumNote.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNumNote.BorderStyle = 2
            Me.txtPhoneNumNote.CaptionName = "전화번호2"
            Me.txtPhoneNumNote.Location = New System.Drawing.Point(503, 430)
            Me.txtPhoneNumNote.MaxLength = 12
            Me.txtPhoneNumNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNumNote.Multiline = False
            Me.txtPhoneNumNote.Name = "txtPhoneNumNote"
            Me.txtPhoneNumNote.ReadOnlys = False
            Me.txtPhoneNumNote.SelectedText = ""
            Me.txtPhoneNumNote.SelectionLength = 0
            Me.txtPhoneNumNote.SelectionStart = 0
            Me.txtPhoneNumNote.Size = New System.Drawing.Size(257, 20)
            Me.txtPhoneNumNote.TabIndex = 5
            Me.txtPhoneNumNote.Tag = ""
            Me.txtPhoneNumNote.TextAlign = 0
            Me.txtPhoneNumNote.TextValue = ""
            Me.txtPhoneNumNote.ToolTipText = ""
            '
            'txtContent
            '
            Me.txtContent.BackColor = System.Drawing.SystemColors.Window
            Me.txtContent.BorderColor = System.Drawing.Color.Empty
            Me.txtContent.BorderStyle = 2
            Me.txtContent.CaptionName = "민원 내용"
            Me.txtContent.Location = New System.Drawing.Point(111, 512)
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
            Me.txtContent.TabIndex = 9
            Me.txtContent.Tag = Nothing
            Me.txtContent.TextAlign = 0
            Me.txtContent.TextValue = ""
            Me.txtContent.ToolTipText = ""
            '
            'txtDateTime
            '
            Me.txtDateTime.Location = New System.Drawing.Point(247, 403)
            Me.txtDateTime.Name = "txtDateTime"
            Me.txtDateTime.ReadOnly = True
            Me.txtDateTime.Size = New System.Drawing.Size(130, 21)
            Me.txtDateTime.TabIndex = 3
            Me.txtDateTime.Tag = "read;"
            '
            'txtSubscribeCd
            '
            Me.txtSubscribeCd.Location = New System.Drawing.Point(383, 403)
            Me.txtSubscribeCd.Name = "txtSubscribeCd"
            Me.txtSubscribeCd.Size = New System.Drawing.Size(130, 21)
            Me.txtSubscribeCd.TabIndex = 1183
            Me.txtSubscribeCd.Tag = ""
            Me.txtSubscribeCd.Visible = False
            '
            'PNC301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtSubscribeCd)
            Me.Controls.Add(Me.txtDateTime)
            Me.Controls.Add(Me.txtContent)
            Me.Controls.Add(Me.txtPhoneNumNote)
            Me.Controls.Add(Me.txtReaderNmNote)
            Me.Controls.Add(Me.txtBranchNmNote)
            Me.Controls.Add(Me.txtAddrNote)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Dtp1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpToReceiptDt)
            Me.Controls.Add(Me.Label28)
            Me.Controls.Add(Me.dtpFromReceiptDt)
            Me.Controls.Add(Me.picCriteria_2)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.btnPRB002)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtDeptNm)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.dtpReceiptDt)
            Me.Controls.Add(Me.cboDivCd)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.txtNewAddr)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtPhoneNum)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.txtReaderNm)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.txtReaderCd)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.picIo_2)
            Me.Name = "PNC301"
            Me.Size = New System.Drawing.Size(811, 634)
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents btnPRB002 As ubiLease.CommonControls.btn
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtDeptNm As ubiLease.CommonControls.txt
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDt As ubiLease.CommonControls.dtp
        Friend WithEvents cboDivCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblNote As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtReaderCd As ubiLease.CommonControls.txt
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtReaderNm As ubiLease.CommonControls.txt
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNewAddr As ubiLease.CommonControls.txt
        Friend WithEvents picCriteria_2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpToReceiptDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents dtpFromReceiptDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Dtp1 As ubiLease.CommonControls.dtp
        Friend WithEvents txtAddrNote As ubiLease.CommonControls.txt
        Friend WithEvents txtBranchNmNote As ubiLease.CommonControls.txt
        Friend WithEvents txtReaderNmNote As ubiLease.CommonControls.txt
        Friend WithEvents txtPhoneNumNote As ubiLease.CommonControls.txt
        Friend WithEvents txtContent As ubiLease.CommonControls.txt
        Friend WithEvents txtDateTime As System.Windows.Forms.TextBox
        Friend WithEvents txtSubscribeCd As System.Windows.Forms.TextBox


    End Class

End Namespace
