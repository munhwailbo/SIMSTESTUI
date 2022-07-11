Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC203
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC203))
            Me.txtReaderName = New ubiLease.CommonControls.txt
            Me.Label9 = New System.Windows.Forms.Label
            Me.txtReaderCode = New ubiLease.CommonControls.txt
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label15 = New System.Windows.Forms.Label
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Label20 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            Me.btnCopy = New System.Windows.Forms.Button
            Me.btnRowSave = New System.Windows.Forms.Button
            Me.btnRowDelete = New System.Windows.Forms.Button
            Me.btnRowInsert = New System.Windows.Forms.Button
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label24 = New System.Windows.Forms.Label
            Me.txtNewAddr2 = New ubiLease.CommonControls.txt
            Me.txtOldAddr2 = New ubiLease.CommonControls.txt
            Me.lblOldPostNum = New System.Windows.Forms.Label
            Me.lblOldAddr2 = New System.Windows.Forms.Label
            Me.lblNewPostNum = New System.Windows.Forms.Label
            Me.lblNewAddr2 = New System.Windows.Forms.Label
            Me.lblPhoneNum2 = New System.Windows.Forms.Label
            Me.txtPhoneNum2 = New ubiLease.CommonControls.txt
            Me.lblPhoneNumber = New System.Windows.Forms.Label
            Me.txtPhoneNum1 = New ubiLease.CommonControls.txt
            Me.lblMobileNum = New System.Windows.Forms.Label
            Me.txtMobileNum = New ubiLease.CommonControls.txt
            Me.lblReaderNm = New System.Windows.Forms.Label
            Me.txtReaderNm = New ubiLease.CommonControls.txt
            Me.lblReaderCd = New System.Windows.Forms.Label
            Me.txtReaderCd = New ubiLease.CommonControls.txt
            Me.popNewPostNum = New ubiLease.CommonControls.pop
            Me.popOldPostNum = New ubiLease.CommonControls.pop
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtReaderName
            '
            Me.txtReaderName.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderName.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderName.BorderStyle = 2
            Me.txtReaderName.CaptionName = Nothing
            Me.txtReaderName.Location = New System.Drawing.Point(283, 15)
            Me.txtReaderName.MaxLength = 32767
            Me.txtReaderName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderName.Multiline = False
            Me.txtReaderName.Name = "txtReaderName"
            Me.txtReaderName.ReadOnlys = False
            Me.txtReaderName.SelectedText = ""
            Me.txtReaderName.SelectionLength = 0
            Me.txtReaderName.SelectionStart = 0
            Me.txtReaderName.Size = New System.Drawing.Size(115, 20)
            Me.txtReaderName.TabIndex = 856
            Me.txtReaderName.Tag = Nothing
            Me.txtReaderName.TextAlign = 0
            Me.txtReaderName.TextValue = ""
            Me.txtReaderName.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(212, 20)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(65, 15)
            Me.Label9.TabIndex = 855
            Me.Label9.Text = "독자명"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReaderCode
            '
            Me.txtReaderCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderCode.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderCode.BorderStyle = 2
            Me.txtReaderCode.CaptionName = Nothing
            Me.txtReaderCode.Location = New System.Drawing.Point(91, 15)
            Me.txtReaderCode.MaxLength = 32767
            Me.txtReaderCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderCode.Multiline = False
            Me.txtReaderCode.Name = "txtReaderCode"
            Me.txtReaderCode.ReadOnlys = False
            Me.txtReaderCode.SelectedText = ""
            Me.txtReaderCode.SelectionLength = 0
            Me.txtReaderCode.SelectionStart = 0
            Me.txtReaderCode.Size = New System.Drawing.Size(115, 20)
            Me.txtReaderCode.TabIndex = 854
            Me.txtReaderCode.Tag = Nothing
            Me.txtReaderCode.TextAlign = 0
            Me.txtReaderCode.TextValue = ""
            Me.txtReaderCode.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(20, 20)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(65, 15)
            Me.Label11.TabIndex = 853
            Me.Label11.Text = "독자코드"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label15.Location = New System.Drawing.Point(5, 297)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(93, 12)
            Me.Label15.TabIndex = 1058
            Me.Label15.Text = "이사 이력 정보"
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
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_3.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(6, 312)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 15
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(799, 176)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 1059
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
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
            Me.picCriteria.TabIndex = 852
            Me.picCriteria.TabStop = False
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label20.Location = New System.Drawing.Point(388, 51)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(62, 12)
            Me.Label20.TabIndex = 1481
            Me.Label20.Text = "독자 정보"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label17.Location = New System.Drawing.Point(4, 51)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(62, 12)
            Me.Label17.TabIndex = 1480
            Me.Label17.Text = "독자 목록"
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
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
            Me.grd_1.Location = New System.Drawing.Point(6, 66)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(372, 224)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1479
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picIo_1
            '
            Me.picIo_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(390, 66)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(415, 224)
            Me.picIo_1.TabIndex = 1482
            Me.picIo_1.TabStop = False
            '
            'btnCopy
            '
            Me.btnCopy.Location = New System.Drawing.Point(283, 495)
            Me.btnCopy.Name = "btnCopy"
            Me.btnCopy.Size = New System.Drawing.Size(50, 23)
            Me.btnCopy.TabIndex = 1504
            Me.btnCopy.Text = "복사"
            Me.btnCopy.UseVisualStyleBackColor = True
            Me.btnCopy.Visible = False
            '
            'btnRowSave
            '
            Me.btnRowSave.Location = New System.Drawing.Point(227, 495)
            Me.btnRowSave.Name = "btnRowSave"
            Me.btnRowSave.Size = New System.Drawing.Size(50, 23)
            Me.btnRowSave.TabIndex = 1502
            Me.btnRowSave.Text = "저장"
            Me.btnRowSave.UseVisualStyleBackColor = True
            Me.btnRowSave.Visible = False
            '
            'btnRowDelete
            '
            Me.btnRowDelete.Location = New System.Drawing.Point(171, 495)
            Me.btnRowDelete.Name = "btnRowDelete"
            Me.btnRowDelete.Size = New System.Drawing.Size(50, 23)
            Me.btnRowDelete.TabIndex = 1503
            Me.btnRowDelete.Text = "삭제"
            Me.btnRowDelete.UseVisualStyleBackColor = True
            '
            'btnRowInsert
            '
            Me.btnRowInsert.Location = New System.Drawing.Point(115, 495)
            Me.btnRowInsert.Name = "btnRowInsert"
            Me.btnRowInsert.Size = New System.Drawing.Size(50, 23)
            Me.btnRowInsert.TabIndex = 1501
            Me.btnRowInsert.Text = "추가"
            Me.btnRowInsert.UseVisualStyleBackColor = True
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_2.Location = New System.Drawing.Point(6, 524)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 15
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(799, 162)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1500
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label24.Location = New System.Drawing.Point(5, 506)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(93, 12)
            Me.Label24.TabIndex = 1499
            Me.Label24.Text = "구독 이력 정보"
            '
            'txtNewAddr2
            '
            Me.txtNewAddr2.BackColor = System.Drawing.SystemColors.Window
            Me.txtNewAddr2.BorderColor = System.Drawing.Color.Empty
            Me.txtNewAddr2.BorderStyle = 2
            Me.txtNewAddr2.CaptionName = "신주소"
            Me.txtNewAddr2.Location = New System.Drawing.Point(497, 260)
            Me.txtNewAddr2.MaxLength = 40
            Me.txtNewAddr2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNewAddr2.Multiline = False
            Me.txtNewAddr2.Name = "txtNewAddr2"
            Me.txtNewAddr2.ReadOnlys = False
            Me.txtNewAddr2.SelectedText = ""
            Me.txtNewAddr2.SelectionLength = 0
            Me.txtNewAddr2.SelectionStart = 0
            Me.txtNewAddr2.Size = New System.Drawing.Size(296, 20)
            Me.txtNewAddr2.TabIndex = 1520
            Me.txtNewAddr2.Tag = "need;"
            Me.txtNewAddr2.TextAlign = 0
            Me.txtNewAddr2.TextValue = ""
            Me.txtNewAddr2.ToolTipText = ""
            '
            'txtOldAddr2
            '
            Me.txtOldAddr2.BackColor = System.Drawing.SystemColors.Window
            Me.txtOldAddr2.BorderColor = System.Drawing.Color.Empty
            Me.txtOldAddr2.BorderStyle = 2
            Me.txtOldAddr2.CaptionName = "구주소"
            Me.txtOldAddr2.Location = New System.Drawing.Point(497, 208)
            Me.txtOldAddr2.MaxLength = 40
            Me.txtOldAddr2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOldAddr2.Multiline = False
            Me.txtOldAddr2.Name = "txtOldAddr2"
            Me.txtOldAddr2.ReadOnlys = False
            Me.txtOldAddr2.SelectedText = ""
            Me.txtOldAddr2.SelectionLength = 0
            Me.txtOldAddr2.SelectionStart = 0
            Me.txtOldAddr2.Size = New System.Drawing.Size(296, 20)
            Me.txtOldAddr2.TabIndex = 1519
            Me.txtOldAddr2.Tag = "need;"
            Me.txtOldAddr2.TextAlign = 0
            Me.txtOldAddr2.TextValue = ""
            Me.txtOldAddr2.ToolTipText = ""
            '
            'lblOldPostNum
            '
            Me.lblOldPostNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblOldPostNum.Location = New System.Drawing.Point(407, 186)
            Me.lblOldPostNum.Name = "lblOldPostNum"
            Me.lblOldPostNum.Size = New System.Drawing.Size(84, 18)
            Me.lblOldPostNum.TabIndex = 1518
            Me.lblOldPostNum.Text = "구 우편번호"
            Me.lblOldPostNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblOldAddr2
            '
            Me.lblOldAddr2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblOldAddr2.Location = New System.Drawing.Point(407, 210)
            Me.lblOldAddr2.Name = "lblOldAddr2"
            Me.lblOldAddr2.Size = New System.Drawing.Size(84, 18)
            Me.lblOldAddr2.TabIndex = 1515
            Me.lblOldAddr2.Text = "구 상세주소"
            Me.lblOldAddr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNewPostNum
            '
            Me.lblNewPostNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNewPostNum.Location = New System.Drawing.Point(407, 237)
            Me.lblNewPostNum.Name = "lblNewPostNum"
            Me.lblNewPostNum.Size = New System.Drawing.Size(84, 18)
            Me.lblNewPostNum.TabIndex = 1516
            Me.lblNewPostNum.Text = "신 우편번호"
            Me.lblNewPostNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNewAddr2
            '
            Me.lblNewAddr2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNewAddr2.Location = New System.Drawing.Point(407, 262)
            Me.lblNewAddr2.Name = "lblNewAddr2"
            Me.lblNewAddr2.Size = New System.Drawing.Size(84, 18)
            Me.lblNewAddr2.TabIndex = 1517
            Me.lblNewAddr2.Text = "신 상세주소"
            Me.lblNewAddr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblPhoneNum2
            '
            Me.lblPhoneNum2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPhoneNum2.Location = New System.Drawing.Point(603, 132)
            Me.lblPhoneNum2.Name = "lblPhoneNum2"
            Me.lblPhoneNum2.Size = New System.Drawing.Size(84, 18)
            Me.lblPhoneNum2.TabIndex = 1514
            Me.lblPhoneNum2.Text = "전화번호2"
            Me.lblPhoneNum2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum2
            '
            Me.txtPhoneNum2.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum2.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum2.BorderStyle = 2
            Me.txtPhoneNum2.CaptionName = "전화번호2"
            Me.txtPhoneNum2.Location = New System.Drawing.Point(693, 130)
            Me.txtPhoneNum2.MaxLength = 13
            Me.txtPhoneNum2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum2.Multiline = False
            Me.txtPhoneNum2.Name = "txtPhoneNum2"
            Me.txtPhoneNum2.ReadOnlys = False
            Me.txtPhoneNum2.SelectedText = ""
            Me.txtPhoneNum2.SelectionLength = 0
            Me.txtPhoneNum2.SelectionStart = 0
            Me.txtPhoneNum2.Size = New System.Drawing.Size(100, 20)
            Me.txtPhoneNum2.TabIndex = 1513
            Me.txtPhoneNum2.Tag = ""
            Me.txtPhoneNum2.TextAlign = 0
            Me.txtPhoneNum2.TextValue = ""
            Me.txtPhoneNum2.ToolTipText = ""
            '
            'lblPhoneNumber
            '
            Me.lblPhoneNumber.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPhoneNumber.Location = New System.Drawing.Point(407, 132)
            Me.lblPhoneNumber.Name = "lblPhoneNumber"
            Me.lblPhoneNumber.Size = New System.Drawing.Size(84, 18)
            Me.lblPhoneNumber.TabIndex = 1510
            Me.lblPhoneNumber.Text = "전화번호1"
            Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum1
            '
            Me.txtPhoneNum1.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum1.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum1.BorderStyle = 2
            Me.txtPhoneNum1.CaptionName = "전화번호1"
            Me.txtPhoneNum1.Location = New System.Drawing.Point(497, 130)
            Me.txtPhoneNum1.MaxLength = 13
            Me.txtPhoneNum1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum1.Multiline = False
            Me.txtPhoneNum1.Name = "txtPhoneNum1"
            Me.txtPhoneNum1.ReadOnlys = False
            Me.txtPhoneNum1.SelectedText = ""
            Me.txtPhoneNum1.SelectionLength = 0
            Me.txtPhoneNum1.SelectionStart = 0
            Me.txtPhoneNum1.Size = New System.Drawing.Size(100, 20)
            Me.txtPhoneNum1.TabIndex = 1509
            Me.txtPhoneNum1.Tag = "need;"
            Me.txtPhoneNum1.TextAlign = 0
            Me.txtPhoneNum1.TextValue = ""
            Me.txtPhoneNum1.ToolTipText = ""
            '
            'lblMobileNum
            '
            Me.lblMobileNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblMobileNum.Location = New System.Drawing.Point(407, 158)
            Me.lblMobileNum.Name = "lblMobileNum"
            Me.lblMobileNum.Size = New System.Drawing.Size(84, 18)
            Me.lblMobileNum.TabIndex = 1512
            Me.lblMobileNum.Text = "휴대전화번호"
            Me.lblMobileNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtMobileNum
            '
            Me.txtMobileNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtMobileNum.BorderColor = System.Drawing.Color.Empty
            Me.txtMobileNum.BorderStyle = 2
            Me.txtMobileNum.CaptionName = "휴대전화번호"
            Me.txtMobileNum.Location = New System.Drawing.Point(497, 156)
            Me.txtMobileNum.MaxLength = 13
            Me.txtMobileNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtMobileNum.Multiline = False
            Me.txtMobileNum.Name = "txtMobileNum"
            Me.txtMobileNum.ReadOnlys = False
            Me.txtMobileNum.SelectedText = ""
            Me.txtMobileNum.SelectionLength = 0
            Me.txtMobileNum.SelectionStart = 0
            Me.txtMobileNum.Size = New System.Drawing.Size(100, 20)
            Me.txtMobileNum.TabIndex = 1511
            Me.txtMobileNum.Tag = ""
            Me.txtMobileNum.TextAlign = 0
            Me.txtMobileNum.TextValue = ""
            Me.txtMobileNum.ToolTipText = ""
            '
            'lblReaderNm
            '
            Me.lblReaderNm.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReaderNm.Location = New System.Drawing.Point(407, 106)
            Me.lblReaderNm.Name = "lblReaderNm"
            Me.lblReaderNm.Size = New System.Drawing.Size(84, 18)
            Me.lblReaderNm.TabIndex = 1508
            Me.lblReaderNm.Text = "독자명"
            Me.lblReaderNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReaderNm
            '
            Me.txtReaderNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtReaderNm.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderNm.BorderStyle = 2
            Me.txtReaderNm.CaptionName = "독자명"
            Me.txtReaderNm.Location = New System.Drawing.Point(497, 104)
            Me.txtReaderNm.MaxLength = 40
            Me.txtReaderNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderNm.Multiline = False
            Me.txtReaderNm.Name = "txtReaderNm"
            Me.txtReaderNm.ReadOnlys = False
            Me.txtReaderNm.SelectedText = ""
            Me.txtReaderNm.SelectionLength = 0
            Me.txtReaderNm.SelectionStart = 0
            Me.txtReaderNm.Size = New System.Drawing.Size(296, 20)
            Me.txtReaderNm.TabIndex = 1507
            Me.txtReaderNm.Tag = "need;"
            Me.txtReaderNm.TextAlign = 0
            Me.txtReaderNm.TextValue = ""
            Me.txtReaderNm.ToolTipText = ""
            '
            'lblReaderCd
            '
            Me.lblReaderCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReaderCd.Location = New System.Drawing.Point(407, 80)
            Me.lblReaderCd.Name = "lblReaderCd"
            Me.lblReaderCd.Size = New System.Drawing.Size(84, 18)
            Me.lblReaderCd.TabIndex = 1506
            Me.lblReaderCd.Text = "독자코드"
            Me.lblReaderCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReaderCd
            '
            Me.txtReaderCd.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.txtReaderCd.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderCd.BorderStyle = 2
            Me.txtReaderCd.CaptionName = "독자 코드"
            Me.txtReaderCd.Enabled = False
            Me.txtReaderCd.Location = New System.Drawing.Point(497, 78)
            Me.txtReaderCd.MaxLength = 8
            Me.txtReaderCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderCd.Multiline = False
            Me.txtReaderCd.Name = "txtReaderCd"
            Me.txtReaderCd.ReadOnlys = True
            Me.txtReaderCd.SelectedText = ""
            Me.txtReaderCd.SelectionLength = 0
            Me.txtReaderCd.SelectionStart = 0
            Me.txtReaderCd.Size = New System.Drawing.Size(100, 20)
            Me.txtReaderCd.TabIndex = 1505
            Me.txtReaderCd.Tag = "need;init(00000000);"
            Me.txtReaderCd.TextAlign = 0
            Me.txtReaderCd.TextValue = ""
            Me.txtReaderCd.ToolTipText = ""
            '
            'popNewPostNum
            '
            Me.popNewPostNum.BorderColor = System.Drawing.Color.Empty
            Me.popNewPostNum.BorderStyle = 2
            Me.popNewPostNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popNewPostNum.CaptionName = "사업장우편번호"
            Me.popNewPostNum.CodeText = ""
            Me.popNewPostNum.CodeWidth = 60
            Me.popNewPostNum.Location = New System.Drawing.Point(497, 235)
            Me.popNewPostNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popNewPostNum.MaxLength = 6
            Me.popNewPostNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popNewPostNum.Name = "popNewPostNum"
            Me.popNewPostNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popNewPostNum.NameText = ""
            Me.popNewPostNum.ReadOnlys = False
            Me.popNewPostNum.SelectedText = ""
            Me.popNewPostNum.SelectionLength = 0
            Me.popNewPostNum.SelectionStart = 0
            Me.popNewPostNum.Size = New System.Drawing.Size(296, 20)
            Me.popNewPostNum.TabIndex = 1522
            Me.popNewPostNum.Tag = "code(우편번호);rtnvalue(txtBusiAddr);"
            Me.popNewPostNum.TextAlign = 0
            Me.popNewPostNum.TextValue = ""
            Me.popNewPostNum.ToolTipText = ""
            '
            'popOldPostNum
            '
            Me.popOldPostNum.BorderColor = System.Drawing.Color.Empty
            Me.popOldPostNum.BorderStyle = 2
            Me.popOldPostNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popOldPostNum.CaptionName = "계약자우편번호"
            Me.popOldPostNum.CodeText = ""
            Me.popOldPostNum.CodeWidth = 60
            Me.popOldPostNum.Location = New System.Drawing.Point(497, 182)
            Me.popOldPostNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popOldPostNum.MaxLength = 6
            Me.popOldPostNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popOldPostNum.Name = "popOldPostNum"
            Me.popOldPostNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popOldPostNum.NameText = ""
            Me.popOldPostNum.ReadOnlys = False
            Me.popOldPostNum.SelectedText = ""
            Me.popOldPostNum.SelectionLength = 0
            Me.popOldPostNum.SelectionStart = 0
            Me.popOldPostNum.Size = New System.Drawing.Size(295, 20)
            Me.popOldPostNum.TabIndex = 1521
            Me.popOldPostNum.Tag = "need;code(우편번호);rtnvalue(txtAddr);"
            Me.popOldPostNum.TextAlign = 0
            Me.popOldPostNum.TextValue = ""
            Me.popOldPostNum.ToolTipText = ""
            '
            'PNC203
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popNewPostNum)
            Me.Controls.Add(Me.popOldPostNum)
            Me.Controls.Add(Me.txtNewAddr2)
            Me.Controls.Add(Me.txtOldAddr2)
            Me.Controls.Add(Me.lblOldPostNum)
            Me.Controls.Add(Me.lblOldAddr2)
            Me.Controls.Add(Me.lblNewPostNum)
            Me.Controls.Add(Me.lblNewAddr2)
            Me.Controls.Add(Me.lblPhoneNum2)
            Me.Controls.Add(Me.txtPhoneNum2)
            Me.Controls.Add(Me.lblPhoneNumber)
            Me.Controls.Add(Me.txtPhoneNum1)
            Me.Controls.Add(Me.lblMobileNum)
            Me.Controls.Add(Me.txtMobileNum)
            Me.Controls.Add(Me.lblReaderNm)
            Me.Controls.Add(Me.txtReaderNm)
            Me.Controls.Add(Me.lblReaderCd)
            Me.Controls.Add(Me.txtReaderCd)
            Me.Controls.Add(Me.btnCopy)
            Me.Controls.Add(Me.btnRowSave)
            Me.Controls.Add(Me.btnRowDelete)
            Me.Controls.Add(Me.btnRowInsert)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.picIo_1)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.txtReaderName)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.txtReaderCode)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNC203"
            Me.Size = New System.Drawing.Size(811, 689)
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtReaderName As ubiLease.CommonControls.txt
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtReaderCode As ubiLease.CommonControls.txt
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox
        Friend WithEvents btnCopy As System.Windows.Forms.Button
        Friend WithEvents btnRowSave As System.Windows.Forms.Button
        Friend WithEvents btnRowDelete As System.Windows.Forms.Button
        Friend WithEvents btnRowInsert As System.Windows.Forms.Button
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtNewAddr2 As ubiLease.CommonControls.txt
        Friend WithEvents txtOldAddr2 As ubiLease.CommonControls.txt
        Friend WithEvents lblOldPostNum As System.Windows.Forms.Label
        Friend WithEvents lblOldAddr2 As System.Windows.Forms.Label
        Friend WithEvents lblNewPostNum As System.Windows.Forms.Label
        Friend WithEvents lblNewAddr2 As System.Windows.Forms.Label
        Friend WithEvents lblPhoneNum2 As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum2 As ubiLease.CommonControls.txt
        Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum1 As ubiLease.CommonControls.txt
        Friend WithEvents lblMobileNum As System.Windows.Forms.Label
        Friend WithEvents txtMobileNum As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderNm As System.Windows.Forms.Label
        Friend WithEvents txtReaderNm As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderCd As System.Windows.Forms.Label
        Friend WithEvents txtReaderCd As ubiLease.CommonControls.txt
        Friend WithEvents popNewPostNum As ubiLease.CommonControls.pop
        Friend WithEvents popOldPostNum As ubiLease.CommonControls.pop


    End Class

End Namespace
