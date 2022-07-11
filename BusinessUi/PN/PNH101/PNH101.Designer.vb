Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNH101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNH101))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.txtBranchNm_R = New ubiLease.CommonControls.txt
            Me.lblReaderNm_2 = New System.Windows.Forms.Label
            Me.txtEmployee_R = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.btnNew = New ubiLease.CommonControls.btn
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.dtpBaseYearToday = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpBaseYearBefore = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.numYdPaperNumY = New ubiLease.CommonControls.num
            Me.Label40 = New System.Windows.Forms.Label
            Me.numYdPaperNumM = New ubiLease.CommonControls.num
            Me.Label4 = New System.Windows.Forms.Label
            Me.numYdPaperNumT = New ubiLease.CommonControls.num
            Me.Label5 = New System.Windows.Forms.Label
            Me.numPrintPaperNumT = New ubiLease.CommonControls.num
            Me.numPrintPaperNumM = New ubiLease.CommonControls.num
            Me.numPrintPaperNumY = New ubiLease.CommonControls.num
            Me.numIncPaperNumT = New ubiLease.CommonControls.num
            Me.numIncPaperNumM = New ubiLease.CommonControls.num
            Me.numIncPaperNumY = New ubiLease.CommonControls.num
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 45)
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
            Me.grd_1.Location = New System.Drawing.Point(5, 56)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 480)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "발행 일자"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(121, 20)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear.TabIndex = 24
            Me.dtpBaseYear.Tag = "format(&&&&-&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = Nothing
            Me.dtpBaseYear.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(24, 23)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(81, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 23
            Me.lblCodeDivisionHangulName.Text = "발행일자"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBranchNm_R
            '
            Me.txtBranchNm_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm_R.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm_R.BorderStyle = 2
            Me.txtBranchNm_R.CaptionName = "지국 명"
            Me.txtBranchNm_R.Location = New System.Drawing.Point(497, 20)
            Me.txtBranchNm_R.MaxLength = 32767
            Me.txtBranchNm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm_R.Multiline = False
            Me.txtBranchNm_R.Name = "txtBranchNm_R"
            Me.txtBranchNm_R.ReadOnlys = False
            Me.txtBranchNm_R.SelectedText = ""
            Me.txtBranchNm_R.SelectionLength = 0
            Me.txtBranchNm_R.SelectionStart = 0
            Me.txtBranchNm_R.Size = New System.Drawing.Size(115, 20)
            Me.txtBranchNm_R.TabIndex = 1456
            Me.txtBranchNm_R.Tag = Nothing
            Me.txtBranchNm_R.TextAlign = 0
            Me.txtBranchNm_R.TextValue = ""
            Me.txtBranchNm_R.ToolTipText = ""
            '
            'lblReaderNm_2
            '
            Me.lblReaderNm_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderNm_2.Location = New System.Drawing.Point(426, 23)
            Me.lblReaderNm_2.Name = "lblReaderNm_2"
            Me.lblReaderNm_2.Size = New System.Drawing.Size(65, 15)
            Me.lblReaderNm_2.TabIndex = 1455
            Me.lblReaderNm_2.Text = "지국명"
            Me.lblReaderNm_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtEmployee_R
            '
            Me.txtEmployee_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtEmployee_R.BorderColor = System.Drawing.Color.Empty
            Me.txtEmployee_R.BorderStyle = 2
            Me.txtEmployee_R.CaptionName = "담당 명"
            Me.txtEmployee_R.Location = New System.Drawing.Point(300, 20)
            Me.txtEmployee_R.MaxLength = 32767
            Me.txtEmployee_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtEmployee_R.Multiline = False
            Me.txtEmployee_R.Name = "txtEmployee_R"
            Me.txtEmployee_R.ReadOnlys = False
            Me.txtEmployee_R.SelectedText = ""
            Me.txtEmployee_R.SelectionLength = 0
            Me.txtEmployee_R.SelectionStart = 0
            Me.txtEmployee_R.Size = New System.Drawing.Size(115, 20)
            Me.txtEmployee_R.TabIndex = 1458
            Me.txtEmployee_R.Tag = Nothing
            Me.txtEmployee_R.TextAlign = 0
            Me.txtEmployee_R.TextValue = ""
            Me.txtEmployee_R.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(229, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(65, 15)
            Me.Label1.TabIndex = 1457
            Me.Label1.Text = "담당명"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnNew
            '
            Me.btnNew.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Location = New System.Drawing.Point(680, 16)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(109, 26)
            Me.btnNew.TabIndex = 1561
            Me.btnNew.Text = "전일부수이월"
            Me.btnNew.UseVisualStyleBackColor = True
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(5, 541)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(803, 102)
            Me.picIo_2.TabIndex = 1562
            Me.picIo_2.TabStop = False
            '
            'dtpBaseYearToday
            '
            Me.dtpBaseYearToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpBaseYearToday.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYearToday.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYearToday.BorderStyle = 2
            Me.dtpBaseYearToday.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYearToday.CaptionName = "당일 발행 일자"
            Me.dtpBaseYearToday.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseYearToday.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYearToday.Location = New System.Drawing.Point(147, 615)
            Me.dtpBaseYearToday.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYearToday.MaxLength = 0
            Me.dtpBaseYearToday.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYearToday.Name = "dtpBaseYearToday"
            Me.dtpBaseYearToday.ReadOnlys = True
            Me.dtpBaseYearToday.SelectedText = ""
            Me.dtpBaseYearToday.SelectionLength = 0
            Me.dtpBaseYearToday.SelectionStart = 0
            Me.dtpBaseYearToday.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYearToday.TabIndex = 1564
            Me.dtpBaseYearToday.Tag = "read;format(&&&&-&&-&&);"
            Me.dtpBaseYearToday.TextAlign = 0
            Me.dtpBaseYearToday.TextValue = Nothing
            Me.dtpBaseYearToday.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(50, 618)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(81, 15)
            Me.Label2.TabIndex = 1563
            Me.Label2.Text = "당 일"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpBaseYearBefore
            '
            Me.dtpBaseYearBefore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpBaseYearBefore.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYearBefore.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYearBefore.BorderStyle = 2
            Me.dtpBaseYearBefore.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYearBefore.CaptionName = "전일 발행 일자"
            Me.dtpBaseYearBefore.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseYearBefore.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYearBefore.Location = New System.Drawing.Point(147, 572)
            Me.dtpBaseYearBefore.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYearBefore.MaxLength = 0
            Me.dtpBaseYearBefore.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYearBefore.Name = "dtpBaseYearBefore"
            Me.dtpBaseYearBefore.ReadOnlys = True
            Me.dtpBaseYearBefore.SelectedText = ""
            Me.dtpBaseYearBefore.SelectionLength = 0
            Me.dtpBaseYearBefore.SelectionStart = 0
            Me.dtpBaseYearBefore.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYearBefore.TabIndex = 1566
            Me.dtpBaseYearBefore.Tag = "read;format(&&&&-&&-&&);"
            Me.dtpBaseYearBefore.TextAlign = 0
            Me.dtpBaseYearBefore.TextValue = Nothing
            Me.dtpBaseYearBefore.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(50, 575)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 15)
            Me.Label3.TabIndex = 1565
            Me.Label3.Text = "전 일"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numYdPaperNumY
            '
            Me.numYdPaperNumY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numYdPaperNumY.BackColor = System.Drawing.SystemColors.Window
            Me.numYdPaperNumY.BorderColor = System.Drawing.Color.Empty
            Me.numYdPaperNumY.BorderStyle = 2
            Me.numYdPaperNumY.CaptionName = "전일유가"
            Me.numYdPaperNumY.LengthPrecision = 15
            Me.numYdPaperNumY.LengthScale = 0
            Me.numYdPaperNumY.Location = New System.Drawing.Point(274, 572)
            Me.numYdPaperNumY.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numYdPaperNumY.MaxLength = 32767
            Me.numYdPaperNumY.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numYdPaperNumY.Name = "numYdPaperNumY"
            Me.numYdPaperNumY.ReadOnlys = True
            Me.numYdPaperNumY.SelectedText = ""
            Me.numYdPaperNumY.SelectionLength = 0
            Me.numYdPaperNumY.SelectionStart = 1
            Me.numYdPaperNumY.Size = New System.Drawing.Size(80, 20)
            Me.numYdPaperNumY.TabIndex = 1567
            Me.numYdPaperNumY.Tag = "read;"
            Me.numYdPaperNumY.TextValue = "0"
            Me.numYdPaperNumY.ToolTipText = ""
            '
            'Label40
            '
            Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label40.BackColor = System.Drawing.Color.GhostWhite
            Me.Label40.Location = New System.Drawing.Point(274, 551)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(80, 18)
            Me.Label40.TabIndex = 1568
            Me.Label40.Text = "유가"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numYdPaperNumM
            '
            Me.numYdPaperNumM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numYdPaperNumM.BackColor = System.Drawing.SystemColors.Window
            Me.numYdPaperNumM.BorderColor = System.Drawing.Color.Empty
            Me.numYdPaperNumM.BorderStyle = 2
            Me.numYdPaperNumM.CaptionName = "전일무가"
            Me.numYdPaperNumM.LengthPrecision = 15
            Me.numYdPaperNumM.LengthScale = 0
            Me.numYdPaperNumM.Location = New System.Drawing.Point(367, 572)
            Me.numYdPaperNumM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numYdPaperNumM.MaxLength = 32767
            Me.numYdPaperNumM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numYdPaperNumM.Name = "numYdPaperNumM"
            Me.numYdPaperNumM.ReadOnlys = True
            Me.numYdPaperNumM.SelectedText = ""
            Me.numYdPaperNumM.SelectionLength = 0
            Me.numYdPaperNumM.SelectionStart = 1
            Me.numYdPaperNumM.Size = New System.Drawing.Size(80, 20)
            Me.numYdPaperNumM.TabIndex = 1569
            Me.numYdPaperNumM.Tag = "read;"
            Me.numYdPaperNumM.TextValue = "0"
            Me.numYdPaperNumM.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(367, 551)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(80, 18)
            Me.Label4.TabIndex = 1570
            Me.Label4.Text = "무가"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numYdPaperNumT
            '
            Me.numYdPaperNumT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numYdPaperNumT.BackColor = System.Drawing.SystemColors.Window
            Me.numYdPaperNumT.BorderColor = System.Drawing.Color.Empty
            Me.numYdPaperNumT.BorderStyle = 2
            Me.numYdPaperNumT.CaptionName = "전일부수계"
            Me.numYdPaperNumT.LengthPrecision = 15
            Me.numYdPaperNumT.LengthScale = 0
            Me.numYdPaperNumT.Location = New System.Drawing.Point(461, 572)
            Me.numYdPaperNumT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numYdPaperNumT.MaxLength = 32767
            Me.numYdPaperNumT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numYdPaperNumT.Name = "numYdPaperNumT"
            Me.numYdPaperNumT.ReadOnlys = True
            Me.numYdPaperNumT.SelectedText = ""
            Me.numYdPaperNumT.SelectionLength = 0
            Me.numYdPaperNumT.SelectionStart = 1
            Me.numYdPaperNumT.Size = New System.Drawing.Size(80, 20)
            Me.numYdPaperNumT.TabIndex = 1571
            Me.numYdPaperNumT.Tag = "read;"
            Me.numYdPaperNumT.TextValue = "0"
            Me.numYdPaperNumT.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(461, 551)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(80, 18)
            Me.Label5.TabIndex = 1572
            Me.Label5.Text = "부수계"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numPrintPaperNumT
            '
            Me.numPrintPaperNumT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numPrintPaperNumT.BackColor = System.Drawing.SystemColors.Window
            Me.numPrintPaperNumT.BorderColor = System.Drawing.Color.Empty
            Me.numPrintPaperNumT.BorderStyle = 2
            Me.numPrintPaperNumT.CaptionName = "당일부수계"
            Me.numPrintPaperNumT.LengthPrecision = 15
            Me.numPrintPaperNumT.LengthScale = 0
            Me.numPrintPaperNumT.Location = New System.Drawing.Point(461, 615)
            Me.numPrintPaperNumT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPrintPaperNumT.MaxLength = 32767
            Me.numPrintPaperNumT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPrintPaperNumT.Name = "numPrintPaperNumT"
            Me.numPrintPaperNumT.ReadOnlys = True
            Me.numPrintPaperNumT.SelectedText = ""
            Me.numPrintPaperNumT.SelectionLength = 0
            Me.numPrintPaperNumT.SelectionStart = 1
            Me.numPrintPaperNumT.Size = New System.Drawing.Size(80, 20)
            Me.numPrintPaperNumT.TabIndex = 1575
            Me.numPrintPaperNumT.Tag = "read;"
            Me.numPrintPaperNumT.TextValue = "0"
            Me.numPrintPaperNumT.ToolTipText = ""
            '
            'numPrintPaperNumM
            '
            Me.numPrintPaperNumM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numPrintPaperNumM.BackColor = System.Drawing.SystemColors.Window
            Me.numPrintPaperNumM.BorderColor = System.Drawing.Color.Empty
            Me.numPrintPaperNumM.BorderStyle = 2
            Me.numPrintPaperNumM.CaptionName = "당일무가"
            Me.numPrintPaperNumM.LengthPrecision = 15
            Me.numPrintPaperNumM.LengthScale = 0
            Me.numPrintPaperNumM.Location = New System.Drawing.Point(367, 615)
            Me.numPrintPaperNumM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPrintPaperNumM.MaxLength = 32767
            Me.numPrintPaperNumM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPrintPaperNumM.Name = "numPrintPaperNumM"
            Me.numPrintPaperNumM.ReadOnlys = True
            Me.numPrintPaperNumM.SelectedText = ""
            Me.numPrintPaperNumM.SelectionLength = 0
            Me.numPrintPaperNumM.SelectionStart = 1
            Me.numPrintPaperNumM.Size = New System.Drawing.Size(80, 20)
            Me.numPrintPaperNumM.TabIndex = 1574
            Me.numPrintPaperNumM.Tag = "read;"
            Me.numPrintPaperNumM.TextValue = "0"
            Me.numPrintPaperNumM.ToolTipText = ""
            '
            'numPrintPaperNumY
            '
            Me.numPrintPaperNumY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numPrintPaperNumY.BackColor = System.Drawing.SystemColors.Window
            Me.numPrintPaperNumY.BorderColor = System.Drawing.Color.Empty
            Me.numPrintPaperNumY.BorderStyle = 2
            Me.numPrintPaperNumY.CaptionName = "당일유가"
            Me.numPrintPaperNumY.LengthPrecision = 15
            Me.numPrintPaperNumY.LengthScale = 0
            Me.numPrintPaperNumY.Location = New System.Drawing.Point(274, 615)
            Me.numPrintPaperNumY.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPrintPaperNumY.MaxLength = 32767
            Me.numPrintPaperNumY.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPrintPaperNumY.Name = "numPrintPaperNumY"
            Me.numPrintPaperNumY.ReadOnlys = True
            Me.numPrintPaperNumY.SelectedText = ""
            Me.numPrintPaperNumY.SelectionLength = 0
            Me.numPrintPaperNumY.SelectionStart = 1
            Me.numPrintPaperNumY.Size = New System.Drawing.Size(80, 20)
            Me.numPrintPaperNumY.TabIndex = 1573
            Me.numPrintPaperNumY.Tag = "read;"
            Me.numPrintPaperNumY.TextValue = "0"
            Me.numPrintPaperNumY.ToolTipText = ""
            '
            'numIncPaperNumT
            '
            Me.numIncPaperNumT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numIncPaperNumT.BackColor = System.Drawing.SystemColors.Window
            Me.numIncPaperNumT.BorderColor = System.Drawing.Color.Empty
            Me.numIncPaperNumT.BorderStyle = 2
            Me.numIncPaperNumT.CaptionName = "증감부수계"
            Me.numIncPaperNumT.LengthPrecision = 15
            Me.numIncPaperNumT.LengthScale = 0
            Me.numIncPaperNumT.Location = New System.Drawing.Point(461, 593)
            Me.numIncPaperNumT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numIncPaperNumT.MaxLength = 32767
            Me.numIncPaperNumT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numIncPaperNumT.Name = "numIncPaperNumT"
            Me.numIncPaperNumT.ReadOnlys = False
            Me.numIncPaperNumT.SelectedText = ""
            Me.numIncPaperNumT.SelectionLength = 0
            Me.numIncPaperNumT.SelectionStart = 1
            Me.numIncPaperNumT.Size = New System.Drawing.Size(80, 20)
            Me.numIncPaperNumT.TabIndex = 1578
            Me.numIncPaperNumT.Tag = "read;"
            Me.numIncPaperNumT.TextValue = "0"
            Me.numIncPaperNumT.ToolTipText = ""
            '
            'numIncPaperNumM
            '
            Me.numIncPaperNumM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numIncPaperNumM.BackColor = System.Drawing.SystemColors.Window
            Me.numIncPaperNumM.BorderColor = System.Drawing.Color.Empty
            Me.numIncPaperNumM.BorderStyle = 2
            Me.numIncPaperNumM.CaptionName = "증감무가"
            Me.numIncPaperNumM.LengthPrecision = 15
            Me.numIncPaperNumM.LengthScale = 0
            Me.numIncPaperNumM.Location = New System.Drawing.Point(367, 593)
            Me.numIncPaperNumM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numIncPaperNumM.MaxLength = 32767
            Me.numIncPaperNumM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numIncPaperNumM.Name = "numIncPaperNumM"
            Me.numIncPaperNumM.ReadOnlys = False
            Me.numIncPaperNumM.SelectedText = ""
            Me.numIncPaperNumM.SelectionLength = 0
            Me.numIncPaperNumM.SelectionStart = 1
            Me.numIncPaperNumM.Size = New System.Drawing.Size(80, 20)
            Me.numIncPaperNumM.TabIndex = 1577
            Me.numIncPaperNumM.Tag = Nothing
            Me.numIncPaperNumM.TextValue = "0"
            Me.numIncPaperNumM.ToolTipText = ""
            '
            'numIncPaperNumY
            '
            Me.numIncPaperNumY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numIncPaperNumY.BackColor = System.Drawing.SystemColors.Window
            Me.numIncPaperNumY.BorderColor = System.Drawing.Color.Empty
            Me.numIncPaperNumY.BorderStyle = 2
            Me.numIncPaperNumY.CaptionName = "증감유가"
            Me.numIncPaperNumY.LengthPrecision = 15
            Me.numIncPaperNumY.LengthScale = 0
            Me.numIncPaperNumY.Location = New System.Drawing.Point(274, 593)
            Me.numIncPaperNumY.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numIncPaperNumY.MaxLength = 32767
            Me.numIncPaperNumY.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numIncPaperNumY.Name = "numIncPaperNumY"
            Me.numIncPaperNumY.ReadOnlys = False
            Me.numIncPaperNumY.SelectedText = ""
            Me.numIncPaperNumY.SelectionLength = 0
            Me.numIncPaperNumY.SelectionStart = 1
            Me.numIncPaperNumY.Size = New System.Drawing.Size(80, 20)
            Me.numIncPaperNumY.TabIndex = 1576
            Me.numIncPaperNumY.Tag = Nothing
            Me.numIncPaperNumY.TextValue = "0"
            Me.numIncPaperNumY.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Location = New System.Drawing.Point(50, 596)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(81, 15)
            Me.Label6.TabIndex = 1579
            Me.Label6.Text = "증 감"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label7.BackColor = System.Drawing.Color.GhostWhite
            Me.Label7.Location = New System.Drawing.Point(147, 553)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(100, 15)
            Me.Label7.TabIndex = 1580
            Me.Label7.Text = "발행일자"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNH101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.numIncPaperNumT)
            Me.Controls.Add(Me.numIncPaperNumM)
            Me.Controls.Add(Me.numIncPaperNumY)
            Me.Controls.Add(Me.numPrintPaperNumT)
            Me.Controls.Add(Me.numPrintPaperNumM)
            Me.Controls.Add(Me.numPrintPaperNumY)
            Me.Controls.Add(Me.numYdPaperNumT)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.numYdPaperNumM)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.numYdPaperNumY)
            Me.Controls.Add(Me.Label40)
            Me.Controls.Add(Me.dtpBaseYearBefore)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpBaseYearToday)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.btnNew)
            Me.Controls.Add(Me.txtEmployee_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtBranchNm_R)
            Me.Controls.Add(Me.lblReaderNm_2)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNH101"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm_R As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderNm_2 As System.Windows.Forms.Label
        Friend WithEvents txtEmployee_R As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnNew As ubiLease.CommonControls.btn
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpBaseYearToday As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseYearBefore As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents numYdPaperNumY As ubiLease.CommonControls.num
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents numYdPaperNumM As ubiLease.CommonControls.num
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents numYdPaperNumT As ubiLease.CommonControls.num
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents numPrintPaperNumT As ubiLease.CommonControls.num
        Friend WithEvents numPrintPaperNumM As ubiLease.CommonControls.num
        Friend WithEvents numPrintPaperNumY As ubiLease.CommonControls.num
        Friend WithEvents numIncPaperNumT As ubiLease.CommonControls.num
        Friend WithEvents numIncPaperNumM As ubiLease.CommonControls.num
        Friend WithEvents numIncPaperNumY As ubiLease.CommonControls.num
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label

    End Class

End Namespace
