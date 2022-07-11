Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI205
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI205))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.dtpTaxAccPublishDt_R1 = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.txtConsumerAddr = New ubiLease.CommonControls.txt
            Me.popConsumerPostNum = New ubiLease.CommonControls.pop
            Me.txtConsumerAddr2 = New ubiLease.CommonControls.txt
            Me.lblOldPostNum = New System.Windows.Forms.Label
            Me.lblOldAddr2 = New System.Windows.Forms.Label
            Me.Label39 = New System.Windows.Forms.Label
            Me.dtpTaxAccPublishDt = New ubiLease.CommonControls.dtp
            Me.popSalesCd = New ubiLease.CommonControls.pop
            Me.Label12 = New System.Windows.Forms.Label
            Me.lblSubscriberNm = New System.Windows.Forms.Label
            Me.txtConsumerCorpNm = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtConsumerPresidentNm = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtConsumerBusinessNum = New ubiLease.CommonControls.txt
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtConsumerBusiStatusCd = New ubiLease.CommonControls.txt
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtConsumerBusiTypeCd = New ubiLease.CommonControls.txt
            Me.Label6 = New System.Windows.Forms.Label
            Me.cboSalesDiviCd = New ubiLease.CommonControls.cbo
            Me.Label29 = New System.Windows.Forms.Label
            Me.dtpTaxAccPublishDt_R2 = New ubiLease.CommonControls.dtp
            Me.Label7 = New System.Windows.Forms.Label
            Me.lblSeriesNum = New System.Windows.Forms.Label
            Me.txtSeriesNum = New ubiLease.CommonControls.txt
            Me.btnBusiDt = New System.Windows.Forms.Button
            Me.cboSalesDivCd_R = New ubiLease.CommonControls.cbo
            Me.Label8 = New System.Windows.Forms.Label
            Me.popSalesCd_R = New ubiLease.CommonControls.pop
            Me.numSupplyTotalAmt = New ubiLease.CommonControls.num
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.Label9 = New System.Windows.Forms.Label
            Me.lblRecordState = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(29, 40)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(77, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "매출처코드"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 59)
            Me.picCriteria_1.TabIndex = 2
            Me.picCriteria_1.TabStop = False
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 318)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 324)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(11, 206)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(791, 80)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 3
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpTaxAccPublishDt_R1
            '
            Me.dtpTaxAccPublishDt_R1.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTaxAccPublishDt_R1.BorderColor = System.Drawing.Color.Empty
            Me.dtpTaxAccPublishDt_R1.BorderStyle = 2
            Me.dtpTaxAccPublishDt_R1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTaxAccPublishDt_R1.CaptionName = "발행 일자"
            Me.dtpTaxAccPublishDt_R1.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTaxAccPublishDt_R1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTaxAccPublishDt_R1.Location = New System.Drawing.Point(493, 37)
            Me.dtpTaxAccPublishDt_R1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTaxAccPublishDt_R1.MaxLength = 0
            Me.dtpTaxAccPublishDt_R1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTaxAccPublishDt_R1.Name = "dtpTaxAccPublishDt_R1"
            Me.dtpTaxAccPublishDt_R1.ReadOnlys = False
            Me.dtpTaxAccPublishDt_R1.SelectedText = ""
            Me.dtpTaxAccPublishDt_R1.SelectionLength = 0
            Me.dtpTaxAccPublishDt_R1.SelectionStart = 0
            Me.dtpTaxAccPublishDt_R1.Size = New System.Drawing.Size(100, 20)
            Me.dtpTaxAccPublishDt_R1.TabIndex = 2
            Me.dtpTaxAccPublishDt_R1.Tag = "format(&&&&-&&-&&);"
            Me.dtpTaxAccPublishDt_R1.TextAlign = 0
            Me.dtpTaxAccPublishDt_R1.TextValue = ""
            Me.dtpTaxAccPublishDt_R1.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(410, 40)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(77, 15)
            Me.Label1.TabIndex = 21
            Me.Label1.Text = "발행 일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(11, 72)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(790, 130)
            Me.picIo_2.TabIndex = 1376
            Me.picIo_2.TabStop = False
            '
            'txtConsumerAddr
            '
            Me.txtConsumerAddr.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerAddr.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerAddr.BorderStyle = 2
            Me.txtConsumerAddr.CaptionName = "구주소"
            Me.txtConsumerAddr.Location = New System.Drawing.Point(194, 148)
            Me.txtConsumerAddr.MaxLength = 40
            Me.txtConsumerAddr.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerAddr.Multiline = False
            Me.txtConsumerAddr.Name = "txtConsumerAddr"
            Me.txtConsumerAddr.ReadOnlys = False
            Me.txtConsumerAddr.SelectedText = ""
            Me.txtConsumerAddr.SelectionLength = 0
            Me.txtConsumerAddr.SelectionStart = 0
            Me.txtConsumerAddr.Size = New System.Drawing.Size(237, 20)
            Me.txtConsumerAddr.TabIndex = 14
            Me.txtConsumerAddr.Tag = "read;"
            Me.txtConsumerAddr.TextAlign = 0
            Me.txtConsumerAddr.TextValue = ""
            Me.txtConsumerAddr.ToolTipText = ""
            '
            'popConsumerPostNum
            '
            Me.popConsumerPostNum.BorderColor = System.Drawing.Color.Empty
            Me.popConsumerPostNum.BorderStyle = 2
            Me.popConsumerPostNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popConsumerPostNum.CaptionName = "우편번호"
            Me.popConsumerPostNum.CodeText = ""
            Me.popConsumerPostNum.CodeWidth = 50
            Me.popConsumerPostNum.Location = New System.Drawing.Point(122, 148)
            Me.popConsumerPostNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popConsumerPostNum.MaxLength = 6
            Me.popConsumerPostNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popConsumerPostNum.Name = "popConsumerPostNum"
            Me.popConsumerPostNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popConsumerPostNum.NameText = ""
            Me.popConsumerPostNum.ReadOnlys = False
            Me.popConsumerPostNum.SelectedText = ""
            Me.popConsumerPostNum.SelectionLength = 0
            Me.popConsumerPostNum.SelectionStart = 0
            Me.popConsumerPostNum.Size = New System.Drawing.Size(72, 20)
            Me.popConsumerPostNum.TabIndex = 13
            Me.popConsumerPostNum.Tag = "need;code(우편번호);rtnvalue(txtConsumerAddr, popNewPostNum, popDeliveryBranchCd);"
            Me.popConsumerPostNum.TextAlign = 0
            Me.popConsumerPostNum.TextValue = ""
            Me.popConsumerPostNum.ToolTipText = ""
            '
            'txtConsumerAddr2
            '
            Me.txtConsumerAddr2.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerAddr2.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerAddr2.BorderStyle = 2
            Me.txtConsumerAddr2.CaptionName = "상세주소"
            Me.txtConsumerAddr2.Location = New System.Drawing.Point(509, 148)
            Me.txtConsumerAddr2.MaxLength = 40
            Me.txtConsumerAddr2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerAddr2.Multiline = False
            Me.txtConsumerAddr2.Name = "txtConsumerAddr2"
            Me.txtConsumerAddr2.ReadOnlys = False
            Me.txtConsumerAddr2.SelectedText = ""
            Me.txtConsumerAddr2.SelectionLength = 0
            Me.txtConsumerAddr2.SelectionStart = 0
            Me.txtConsumerAddr2.Size = New System.Drawing.Size(282, 20)
            Me.txtConsumerAddr2.TabIndex = 15
            Me.txtConsumerAddr2.Tag = "need;"
            Me.txtConsumerAddr2.TextAlign = 0
            Me.txtConsumerAddr2.TextValue = ""
            Me.txtConsumerAddr2.ToolTipText = ""
            '
            'lblOldPostNum
            '
            Me.lblOldPostNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblOldPostNum.Location = New System.Drawing.Point(20, 149)
            Me.lblOldPostNum.Name = "lblOldPostNum"
            Me.lblOldPostNum.Size = New System.Drawing.Size(99, 18)
            Me.lblOldPostNum.TabIndex = 1413
            Me.lblOldPostNum.Text = " 우편번호"
            Me.lblOldPostNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblOldAddr2
            '
            Me.lblOldAddr2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblOldAddr2.Location = New System.Drawing.Point(444, 149)
            Me.lblOldAddr2.Name = "lblOldAddr2"
            Me.lblOldAddr2.Size = New System.Drawing.Size(64, 18)
            Me.lblOldAddr2.TabIndex = 1412
            Me.lblOldAddr2.Text = "상세주소"
            Me.lblOldAddr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label39
            '
            Me.Label39.BackColor = System.Drawing.Color.GhostWhite
            Me.Label39.Location = New System.Drawing.Point(20, 83)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(99, 18)
            Me.Label39.TabIndex = 1431
            Me.Label39.Text = "접수일자"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpTaxAccPublishDt
            '
            Me.dtpTaxAccPublishDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTaxAccPublishDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpTaxAccPublishDt.BorderStyle = 2
            Me.dtpTaxAccPublishDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTaxAccPublishDt.CaptionName = "접수 일자"
            Me.dtpTaxAccPublishDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTaxAccPublishDt.Location = New System.Drawing.Point(122, 82)
            Me.dtpTaxAccPublishDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTaxAccPublishDt.MaxLength = 0
            Me.dtpTaxAccPublishDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTaxAccPublishDt.Name = "dtpTaxAccPublishDt"
            Me.dtpTaxAccPublishDt.ReadOnlys = False
            Me.dtpTaxAccPublishDt.SelectedText = ""
            Me.dtpTaxAccPublishDt.SelectionLength = 0
            Me.dtpTaxAccPublishDt.SelectionStart = 0
            Me.dtpTaxAccPublishDt.Size = New System.Drawing.Size(105, 20)
            Me.dtpTaxAccPublishDt.TabIndex = 5
            Me.dtpTaxAccPublishDt.Tag = "need;format(####-##-##);"
            Me.dtpTaxAccPublishDt.TextAlign = 0
            Me.dtpTaxAccPublishDt.TextValue = ""
            Me.dtpTaxAccPublishDt.ToolTipText = ""
            '
            'popSalesCd
            '
            Me.popSalesCd.BorderColor = System.Drawing.Color.Empty
            Me.popSalesCd.BorderStyle = 2
            Me.popSalesCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popSalesCd.CaptionName = "매출처 코드"
            Me.popSalesCd.CodeText = ""
            Me.popSalesCd.CodeWidth = 80
            Me.popSalesCd.Location = New System.Drawing.Point(122, 104)
            Me.popSalesCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popSalesCd.MaxLength = 12
            Me.popSalesCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popSalesCd.Name = "popSalesCd"
            Me.popSalesCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popSalesCd.NameText = ""
            Me.popSalesCd.ReadOnlys = False
            Me.popSalesCd.SelectedText = ""
            Me.popSalesCd.SelectionLength = 0
            Me.popSalesCd.SelectionStart = 0
            Me.popSalesCd.Size = New System.Drawing.Size(285, 20)
            Me.popSalesCd.TabIndex = 8
            Me.popSalesCd.Tag = "code(매출처코드 명);"
            Me.popSalesCd.TextAlign = 0
            Me.popSalesCd.TextValue = ""
            Me.popSalesCd.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(20, 106)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(99, 16)
            Me.Label12.TabIndex = 1538
            Me.Label12.Text = "매출처코드"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubscriberNm
            '
            Me.lblSubscriberNm.BackColor = System.Drawing.Color.GhostWhite
            Me.lblSubscriberNm.Location = New System.Drawing.Point(444, 105)
            Me.lblSubscriberNm.Name = "lblSubscriberNm"
            Me.lblSubscriberNm.Size = New System.Drawing.Size(64, 18)
            Me.lblSubscriberNm.TabIndex = 1540
            Me.lblSubscriberNm.Text = "상호"
            Me.lblSubscriberNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtConsumerCorpNm
            '
            Me.txtConsumerCorpNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerCorpNm.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerCorpNm.BorderStyle = 2
            Me.txtConsumerCorpNm.CaptionName = "상호"
            Me.txtConsumerCorpNm.Location = New System.Drawing.Point(509, 104)
            Me.txtConsumerCorpNm.MaxLength = 40
            Me.txtConsumerCorpNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerCorpNm.Multiline = False
            Me.txtConsumerCorpNm.Name = "txtConsumerCorpNm"
            Me.txtConsumerCorpNm.ReadOnlys = False
            Me.txtConsumerCorpNm.SelectedText = ""
            Me.txtConsumerCorpNm.SelectionLength = 0
            Me.txtConsumerCorpNm.SelectionStart = 0
            Me.txtConsumerCorpNm.Size = New System.Drawing.Size(282, 20)
            Me.txtConsumerCorpNm.TabIndex = 10
            Me.txtConsumerCorpNm.Tag = "need();"
            Me.txtConsumerCorpNm.TextAlign = 0
            Me.txtConsumerCorpNm.TextValue = ""
            Me.txtConsumerCorpNm.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(425, 127)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(83, 18)
            Me.Label2.TabIndex = 1542
            Me.Label2.Text = "대표자명/성명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtConsumerPresidentNm
            '
            Me.txtConsumerPresidentNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerPresidentNm.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerPresidentNm.BorderStyle = 2
            Me.txtConsumerPresidentNm.CaptionName = "대포자명"
            Me.txtConsumerPresidentNm.Location = New System.Drawing.Point(509, 126)
            Me.txtConsumerPresidentNm.MaxLength = 40
            Me.txtConsumerPresidentNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerPresidentNm.Multiline = False
            Me.txtConsumerPresidentNm.Name = "txtConsumerPresidentNm"
            Me.txtConsumerPresidentNm.ReadOnlys = False
            Me.txtConsumerPresidentNm.SelectedText = ""
            Me.txtConsumerPresidentNm.SelectionLength = 0
            Me.txtConsumerPresidentNm.SelectionStart = 0
            Me.txtConsumerPresidentNm.Size = New System.Drawing.Size(282, 20)
            Me.txtConsumerPresidentNm.TabIndex = 12
            Me.txtConsumerPresidentNm.Tag = "need();"
            Me.txtConsumerPresidentNm.TextAlign = 0
            Me.txtConsumerPresidentNm.TextValue = ""
            Me.txtConsumerPresidentNm.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(20, 127)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(99, 18)
            Me.Label3.TabIndex = 1544
            Me.Label3.Text = "사업자(주민)번호"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtConsumerBusinessNum
            '
            Me.txtConsumerBusinessNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerBusinessNum.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerBusinessNum.BorderStyle = 2
            Me.txtConsumerBusinessNum.CaptionName = "사업자번호"
            Me.txtConsumerBusinessNum.Location = New System.Drawing.Point(122, 126)
            Me.txtConsumerBusinessNum.MaxLength = 40
            Me.txtConsumerBusinessNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerBusinessNum.Multiline = False
            Me.txtConsumerBusinessNum.Name = "txtConsumerBusinessNum"
            Me.txtConsumerBusinessNum.ReadOnlys = False
            Me.txtConsumerBusinessNum.SelectedText = ""
            Me.txtConsumerBusinessNum.SelectionLength = 0
            Me.txtConsumerBusinessNum.SelectionStart = 0
            Me.txtConsumerBusinessNum.Size = New System.Drawing.Size(192, 20)
            Me.txtConsumerBusinessNum.TabIndex = 11
            Me.txtConsumerBusinessNum.Tag = "need();"
            Me.txtConsumerBusinessNum.TextAlign = 0
            Me.txtConsumerBusinessNum.TextValue = ""
            Me.txtConsumerBusinessNum.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(444, 171)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(64, 18)
            Me.Label4.TabIndex = 1546
            Me.Label4.Text = "업태"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtConsumerBusiStatusCd
            '
            Me.txtConsumerBusiStatusCd.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerBusiStatusCd.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerBusiStatusCd.BorderStyle = 2
            Me.txtConsumerBusiStatusCd.CaptionName = "업태"
            Me.txtConsumerBusiStatusCd.Location = New System.Drawing.Point(509, 170)
            Me.txtConsumerBusiStatusCd.MaxLength = 40
            Me.txtConsumerBusiStatusCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerBusiStatusCd.Multiline = False
            Me.txtConsumerBusiStatusCd.Name = "txtConsumerBusiStatusCd"
            Me.txtConsumerBusiStatusCd.ReadOnlys = False
            Me.txtConsumerBusiStatusCd.SelectedText = ""
            Me.txtConsumerBusiStatusCd.SelectionLength = 0
            Me.txtConsumerBusiStatusCd.SelectionStart = 0
            Me.txtConsumerBusiStatusCd.Size = New System.Drawing.Size(120, 20)
            Me.txtConsumerBusiStatusCd.TabIndex = 17
            Me.txtConsumerBusiStatusCd.Tag = "need();"
            Me.txtConsumerBusiStatusCd.TextAlign = 0
            Me.txtConsumerBusiStatusCd.TextValue = ""
            Me.txtConsumerBusiStatusCd.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(635, 171)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(33, 18)
            Me.Label5.TabIndex = 1548
            Me.Label5.Text = "종목"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtConsumerBusiTypeCd
            '
            Me.txtConsumerBusiTypeCd.BackColor = System.Drawing.SystemColors.Window
            Me.txtConsumerBusiTypeCd.BorderColor = System.Drawing.Color.Empty
            Me.txtConsumerBusiTypeCd.BorderStyle = 2
            Me.txtConsumerBusiTypeCd.CaptionName = "종목"
            Me.txtConsumerBusiTypeCd.Location = New System.Drawing.Point(674, 170)
            Me.txtConsumerBusiTypeCd.MaxLength = 40
            Me.txtConsumerBusiTypeCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtConsumerBusiTypeCd.Multiline = False
            Me.txtConsumerBusiTypeCd.Name = "txtConsumerBusiTypeCd"
            Me.txtConsumerBusiTypeCd.ReadOnlys = False
            Me.txtConsumerBusiTypeCd.SelectedText = ""
            Me.txtConsumerBusiTypeCd.SelectionLength = 0
            Me.txtConsumerBusiTypeCd.SelectionStart = 0
            Me.txtConsumerBusiTypeCd.Size = New System.Drawing.Size(117, 20)
            Me.txtConsumerBusiTypeCd.TabIndex = 18
            Me.txtConsumerBusiTypeCd.Tag = "need();"
            Me.txtConsumerBusiTypeCd.TextAlign = 0
            Me.txtConsumerBusiTypeCd.TextValue = ""
            Me.txtConsumerBusiTypeCd.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Location = New System.Drawing.Point(20, 171)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(99, 18)
            Me.Label6.TabIndex = 1550
            Me.Label6.Text = "합     계"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSalesDiviCd
            '
            Me.cboSalesDiviCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboSalesDiviCd.CaptionName = "매출처구분코드"
            Me.cboSalesDiviCd.Enabled = False
            Me.cboSalesDiviCd.ListCount = 0
            Me.cboSalesDiviCd.Location = New System.Drawing.Point(320, 82)
            Me.cboSalesDiviCd.Name = "cboSalesDiviCd"
            Me.cboSalesDiviCd.ReadOnlys = False
            Me.cboSalesDiviCd.Size = New System.Drawing.Size(111, 20)
            Me.cboSalesDiviCd.TabIndex = 6
            Me.cboSalesDiviCd.Tag = "code(매출처구분코드);"
            Me.cboSalesDiviCd.TextValue = ""
            '
            'Label29
            '
            Me.Label29.BackColor = System.Drawing.Color.GhostWhite
            Me.Label29.Location = New System.Drawing.Point(246, 83)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(68, 18)
            Me.Label29.TabIndex = 1552
            Me.Label29.Text = "매출처구분"
            Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpTaxAccPublishDt_R2
            '
            Me.dtpTaxAccPublishDt_R2.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTaxAccPublishDt_R2.BorderColor = System.Drawing.Color.Empty
            Me.dtpTaxAccPublishDt_R2.BorderStyle = 2
            Me.dtpTaxAccPublishDt_R2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTaxAccPublishDt_R2.CaptionName = "발행 일자"
            Me.dtpTaxAccPublishDt_R2.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTaxAccPublishDt_R2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTaxAccPublishDt_R2.Location = New System.Drawing.Point(617, 37)
            Me.dtpTaxAccPublishDt_R2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTaxAccPublishDt_R2.MaxLength = 0
            Me.dtpTaxAccPublishDt_R2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTaxAccPublishDt_R2.Name = "dtpTaxAccPublishDt_R2"
            Me.dtpTaxAccPublishDt_R2.ReadOnlys = False
            Me.dtpTaxAccPublishDt_R2.SelectedText = ""
            Me.dtpTaxAccPublishDt_R2.SelectionLength = 0
            Me.dtpTaxAccPublishDt_R2.SelectionStart = 0
            Me.dtpTaxAccPublishDt_R2.Size = New System.Drawing.Size(100, 20)
            Me.dtpTaxAccPublishDt_R2.TabIndex = 2
            Me.dtpTaxAccPublishDt_R2.Tag = "format(&&&&-&&-&&);"
            Me.dtpTaxAccPublishDt_R2.TextAlign = 0
            Me.dtpTaxAccPublishDt_R2.TextValue = ""
            Me.dtpTaxAccPublishDt_R2.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(594, 38)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(18, 18)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "~"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSeriesNum
            '
            Me.lblSeriesNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblSeriesNum.Location = New System.Drawing.Point(444, 83)
            Me.lblSeriesNum.Name = "lblSeriesNum"
            Me.lblSeriesNum.Size = New System.Drawing.Size(64, 18)
            Me.lblSeriesNum.TabIndex = 1556
            Me.lblSeriesNum.Text = "관리번호"
            Me.lblSeriesNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSeriesNum
            '
            Me.txtSeriesNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtSeriesNum.BorderColor = System.Drawing.Color.Empty
            Me.txtSeriesNum.BorderStyle = 2
            Me.txtSeriesNum.CaptionName = "일련번호"
            Me.txtSeriesNum.Enabled = False
            Me.txtSeriesNum.Location = New System.Drawing.Point(509, 82)
            Me.txtSeriesNum.MaxLength = 40
            Me.txtSeriesNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSeriesNum.Multiline = False
            Me.txtSeriesNum.Name = "txtSeriesNum"
            Me.txtSeriesNum.ReadOnlys = False
            Me.txtSeriesNum.SelectedText = ""
            Me.txtSeriesNum.SelectionLength = 0
            Me.txtSeriesNum.SelectionStart = 0
            Me.txtSeriesNum.Size = New System.Drawing.Size(161, 20)
            Me.txtSeriesNum.TabIndex = 7
            Me.txtSeriesNum.Tag = "read();"
            Me.txtSeriesNum.TextAlign = 0
            Me.txtSeriesNum.TextValue = ""
            Me.txtSeriesNum.ToolTipText = ""
            '
            'btnBusiDt
            '
            Me.btnBusiDt.Location = New System.Drawing.Point(406, 104)
            Me.btnBusiDt.Name = "btnBusiDt"
            Me.btnBusiDt.Size = New System.Drawing.Size(26, 21)
            Me.btnBusiDt.TabIndex = 9
            Me.btnBusiDt.Text = "..."
            Me.btnBusiDt.UseVisualStyleBackColor = True
            '
            'cboSalesDivCd_R
            '
            Me.cboSalesDivCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSalesDivCd_R.CaptionName = "매출처구분코드"
            Me.cboSalesDivCd_R.Enabled = False
            Me.cboSalesDivCd_R.ListCount = 0
            Me.cboSalesDivCd_R.Location = New System.Drawing.Point(111, 14)
            Me.cboSalesDivCd_R.Name = "cboSalesDivCd_R"
            Me.cboSalesDivCd_R.ReadOnlys = False
            Me.cboSalesDivCd_R.Size = New System.Drawing.Size(111, 20)
            Me.cboSalesDivCd_R.TabIndex = 0
            Me.cboSalesDivCd_R.Tag = "code(매출처구분코드|전체);"
            Me.cboSalesDivCd_R.TextValue = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(29, 15)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(77, 18)
            Me.Label8.TabIndex = 1559
            Me.Label8.Text = "매출처구분"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popSalesCd_R
            '
            Me.popSalesCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popSalesCd_R.BorderStyle = 2
            Me.popSalesCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popSalesCd_R.CaptionName = "매출처 코드"
            Me.popSalesCd_R.CodeText = ""
            Me.popSalesCd_R.CodeWidth = 80
            Me.popSalesCd_R.Enabled = False
            Me.popSalesCd_R.Location = New System.Drawing.Point(111, 37)
            Me.popSalesCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popSalesCd_R.MaxLength = 12
            Me.popSalesCd_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popSalesCd_R.Name = "popSalesCd_R"
            Me.popSalesCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popSalesCd_R.NameText = ""
            Me.popSalesCd_R.ReadOnlys = False
            Me.popSalesCd_R.SelectedText = ""
            Me.popSalesCd_R.SelectionLength = 0
            Me.popSalesCd_R.SelectionStart = 0
            Me.popSalesCd_R.Size = New System.Drawing.Size(270, 20)
            Me.popSalesCd_R.TabIndex = 1
            Me.popSalesCd_R.Tag = "code(매출처코드 명);"
            Me.popSalesCd_R.TextAlign = 0
            Me.popSalesCd_R.TextValue = ""
            Me.popSalesCd_R.ToolTipText = ""
            '
            'numSupplyTotalAmt
            '
            Me.numSupplyTotalAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numSupplyTotalAmt.BorderColor = System.Drawing.Color.Empty
            Me.numSupplyTotalAmt.BorderStyle = 2
            Me.numSupplyTotalAmt.CaptionName = "합계금액"
            Me.numSupplyTotalAmt.LengthPrecision = 15
            Me.numSupplyTotalAmt.LengthScale = 0
            Me.numSupplyTotalAmt.Location = New System.Drawing.Point(122, 170)
            Me.numSupplyTotalAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numSupplyTotalAmt.MaxLength = 32767
            Me.numSupplyTotalAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numSupplyTotalAmt.Name = "numSupplyTotalAmt"
            Me.numSupplyTotalAmt.ReadOnlys = False
            Me.numSupplyTotalAmt.SelectedText = ""
            Me.numSupplyTotalAmt.SelectionLength = 0
            Me.numSupplyTotalAmt.SelectionStart = 1
            Me.numSupplyTotalAmt.Size = New System.Drawing.Size(162, 20)
            Me.numSupplyTotalAmt.TabIndex = 16
            Me.numSupplyTotalAmt.Tag = "read;"
            Me.numSupplyTotalAmt.TextValue = "0"
            Me.numSupplyTotalAmt.ToolTipText = ""
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 66)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(801, 228)
            Me.PictureBox1.TabIndex = 1560
            Me.PictureBox1.TabStop = False
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.GhostWhite
            Me.Label9.Location = New System.Drawing.Point(7, 299)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(106, 18)
            Me.Label9.TabIndex = 1561
            Me.Label9.Text = "계산서 발행 현황"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblRecordState
            '
            Me.lblRecordState.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblRecordState.Location = New System.Drawing.Point(720, 82)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 1749
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI205
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.numSupplyTotalAmt)
            Me.Controls.Add(Me.popSalesCd_R)
            Me.Controls.Add(Me.cboSalesDivCd_R)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.btnBusiDt)
            Me.Controls.Add(Me.lblSeriesNum)
            Me.Controls.Add(Me.txtSeriesNum)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpTaxAccPublishDt_R2)
            Me.Controls.Add(Me.cboSalesDiviCd)
            Me.Controls.Add(Me.Label29)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtConsumerBusiTypeCd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtConsumerBusiStatusCd)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtConsumerBusinessNum)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtConsumerPresidentNm)
            Me.Controls.Add(Me.lblSubscriberNm)
            Me.Controls.Add(Me.txtConsumerCorpNm)
            Me.Controls.Add(Me.popSalesCd)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Label39)
            Me.Controls.Add(Me.dtpTaxAccPublishDt)
            Me.Controls.Add(Me.txtConsumerAddr)
            Me.Controls.Add(Me.popConsumerPostNum)
            Me.Controls.Add(Me.txtConsumerAddr2)
            Me.Controls.Add(Me.lblOldPostNum)
            Me.Controls.Add(Me.lblOldAddr2)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.dtpTaxAccPublishDt_R1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNI205"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents dtpTaxAccPublishDt_R1 As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents txtConsumerAddr As ubiLease.CommonControls.txt
        Friend WithEvents popConsumerPostNum As ubiLease.CommonControls.pop
        Friend WithEvents txtConsumerAddr2 As ubiLease.CommonControls.txt
        Friend WithEvents lblOldPostNum As System.Windows.Forms.Label
        Friend WithEvents lblOldAddr2 As System.Windows.Forms.Label
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents dtpTaxAccPublishDt As ubiLease.CommonControls.dtp
        Friend WithEvents popSalesCd As ubiLease.CommonControls.pop
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents lblSubscriberNm As System.Windows.Forms.Label
        Friend WithEvents txtConsumerCorpNm As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtConsumerPresidentNm As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtConsumerBusinessNum As ubiLease.CommonControls.txt
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtConsumerBusiStatusCd As ubiLease.CommonControls.txt
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtConsumerBusiTypeCd As ubiLease.CommonControls.txt
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboSalesDiviCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents dtpTaxAccPublishDt_R2 As ubiLease.CommonControls.dtp
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents lblSeriesNum As System.Windows.Forms.Label
        Friend WithEvents txtSeriesNum As ubiLease.CommonControls.txt
        Friend WithEvents btnBusiDt As System.Windows.Forms.Button
        Friend WithEvents cboSalesDivCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents popSalesCd_R As ubiLease.CommonControls.pop
        Friend WithEvents numSupplyTotalAmt As ubiLease.CommonControls.num
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblRecordState As System.Windows.Forms.Label

    End Class

End Namespace
