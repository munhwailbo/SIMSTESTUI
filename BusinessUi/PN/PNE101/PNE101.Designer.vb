Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE101))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpToExpand = New ubiLease.CommonControls.dtp
            Me.lblExpandDt = New System.Windows.Forms.Label
            Me.dtpFromExpand = New ubiLease.CommonControls.dtp
            Me.btnNew = New ubiLease.CommonControls.btn
            Me.Label2 = New System.Windows.Forms.Label
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.btnSave = New ubiLease.CommonControls.btn
            Me.btnDel = New ubiLease.CommonControls.btn
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.brnReExt = New ubiLease.CommonControls.btn
            Me.btnOpenExcel = New ubiLease.CommonControls.btn
            Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
            Me.btnEmExReader = New ubiLease.CommonControls.btn
            Me.BtnNewLine = New ubiLease.CommonControls.btn
            Me.TxtContactPaperNumTot = New ubiLease.CommonControls.txt
            Me.TxtFixedPagerNum = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.btnExecDemand = New ubiLease.CommonControls.btn
            Me.lblBillType_R = New System.Windows.Forms.Label
            Me.cboBillType_R = New ubiLease.CommonControls.cbo
            Me.popTrAdEmployeeNum = New ubiLease.CommonControls.pop
            Me.Label17 = New System.Windows.Forms.Label
            Me.popAdEmployeeNum = New ubiLease.CommonControls.pop
            Me.Label36 = New System.Windows.Forms.Label
            Me.btnBulkApply = New ubiLease.CommonControls.btn
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtSelectedNum = New ubiLease.CommonControls.txt
            Me.popTrAdEmployeeDeptCd = New ubiLease.CommonControls.pop
            Me.Label15 = New System.Windows.Forms.Label
            Me.popAdEmployeeDeptCd = New ubiLease.CommonControls.pop
            Me.Label14 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 71)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 254)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 852
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 64)
            Me.picCriteria.TabIndex = 911
            Me.picCriteria.TabStop = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(193, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(18, 20)
            Me.Label5.TabIndex = 923
            Me.Label5.Text = "~"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpToExpand
            '
            Me.dtpToExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpToExpand.BorderStyle = 2
            Me.dtpToExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToExpand.CaptionName = "회계 일자"
            Me.dtpToExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToExpand.Location = New System.Drawing.Point(213, 17)
            Me.dtpToExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToExpand.MaxLength = 0
            Me.dtpToExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToExpand.Name = "dtpToExpand"
            Me.dtpToExpand.ReadOnlys = False
            Me.dtpToExpand.SelectedText = ""
            Me.dtpToExpand.SelectionLength = 0
            Me.dtpToExpand.SelectionStart = 0
            Me.dtpToExpand.Size = New System.Drawing.Size(96, 20)
            Me.dtpToExpand.TabIndex = 1
            Me.dtpToExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpToExpand.TextAlign = 0
            Me.dtpToExpand.TextValue = ""
            Me.dtpToExpand.ToolTipText = ""
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(28, 20)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(69, 15)
            Me.lblExpandDt.TabIndex = 921
            Me.lblExpandDt.Text = "접수일자"
            Me.lblExpandDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFromExpand
            '
            Me.dtpFromExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromExpand.BorderStyle = 2
            Me.dtpFromExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromExpand.CaptionName = "회계 일자"
            Me.dtpFromExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromExpand.Location = New System.Drawing.Point(100, 17)
            Me.dtpFromExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromExpand.MaxLength = 0
            Me.dtpFromExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromExpand.Name = "dtpFromExpand"
            Me.dtpFromExpand.ReadOnlys = False
            Me.dtpFromExpand.SelectedText = ""
            Me.dtpFromExpand.SelectionLength = 0
            Me.dtpFromExpand.SelectionStart = 0
            Me.dtpFromExpand.Size = New System.Drawing.Size(96, 20)
            Me.dtpFromExpand.TabIndex = 0
            Me.dtpFromExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpFromExpand.TextAlign = 0
            Me.dtpFromExpand.TextValue = ""
            Me.dtpFromExpand.ToolTipText = ""
            '
            'btnNew
            '
            Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNew.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Location = New System.Drawing.Point(594, 331)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(108, 23)
            Me.btnNew.TabIndex = 1098
            Me.btnNew.Text = "기초 자료 생성"
            Me.btnNew.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(8, 333)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(41, 20)
            Me.Label2.TabIndex = 1097
            Me.Label2.Text = "투입처"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(3, 415)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(805, 227)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1096
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSave.Location = New System.Drawing.Point(704, 331)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(50, 23)
            Me.btnSave.TabIndex = 1099
            Me.btnSave.Text = "저장"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnDel
            '
            Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDel.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDel.Location = New System.Drawing.Point(756, 331)
            Me.btnDel.Name = "btnDel"
            Me.btnDel.Size = New System.Drawing.Size(50, 23)
            Me.btnDel.TabIndex = 1100
            Me.btnDel.Text = "삭제"
            Me.btnDel.UseVisualStyleBackColor = True
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(28, 40)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(69, 20)
            Me.lblBranchNm.TabIndex = 1102
            Me.lblBranchNm.Text = "확장처"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'brnReExt
            '
            Me.brnReExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.brnReExt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.brnReExt.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.brnReExt.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.brnReExt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.brnReExt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.brnReExt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.brnReExt.Location = New System.Drawing.Point(522, 22)
            Me.brnReExt.Name = "brnReExt"
            Me.brnReExt.Size = New System.Drawing.Size(81, 32)
            Me.brnReExt.TabIndex = 1103
            Me.brnReExt.Text = "재확장"
            Me.brnReExt.UseVisualStyleBackColor = True
            '
            'btnOpenExcel
            '
            Me.btnOpenExcel.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnOpenExcel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnOpenExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnOpenExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnOpenExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnOpenExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnOpenExcel.Location = New System.Drawing.Point(55, 331)
            Me.btnOpenExcel.Name = "btnOpenExcel"
            Me.btnOpenExcel.Size = New System.Drawing.Size(104, 23)
            Me.btnOpenExcel.TabIndex = 1104
            Me.btnOpenExcel.Text = "엑셀 Import"
            Me.btnOpenExcel.UseVisualStyleBackColor = True
            '
            'dlgOpenFile
            '
            Me.dlgOpenFile.FileName = "OpenFileDialog1"
            '
            'btnEmExReader
            '
            Me.btnEmExReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEmExReader.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnEmExReader.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnEmExReader.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnEmExReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnEmExReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnEmExReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnEmExReader.Location = New System.Drawing.Point(612, 22)
            Me.btnEmExReader.Name = "btnEmExReader"
            Me.btnEmExReader.Size = New System.Drawing.Size(81, 32)
            Me.btnEmExReader.TabIndex = 3
            Me.btnEmExReader.Text = "권유자등록"
            Me.btnEmExReader.UseVisualStyleBackColor = True
            '
            'BtnNewLine
            '
            Me.BtnNewLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnNewLine.BackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnNewLine.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.BtnNewLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnNewLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.BtnNewLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.BtnNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.BtnNewLine.Location = New System.Drawing.Point(530, 331)
            Me.BtnNewLine.Name = "BtnNewLine"
            Me.BtnNewLine.Size = New System.Drawing.Size(61, 23)
            Me.BtnNewLine.TabIndex = 1106
            Me.BtnNewLine.Text = "신규추가"
            Me.BtnNewLine.UseVisualStyleBackColor = True
            '
            'TxtContactPaperNumTot
            '
            Me.TxtContactPaperNumTot.BackColor = System.Drawing.SystemColors.Window
            Me.TxtContactPaperNumTot.BorderColor = System.Drawing.Color.Empty
            Me.TxtContactPaperNumTot.BorderStyle = 2
            Me.TxtContactPaperNumTot.CaptionName = "확장처"
            Me.TxtContactPaperNumTot.ForeColor = System.Drawing.SystemColors.ControlText
            Me.TxtContactPaperNumTot.Location = New System.Drawing.Point(227, 333)
            Me.TxtContactPaperNumTot.MaxLength = 50
            Me.TxtContactPaperNumTot.MinimumSize = New System.Drawing.Size(20, 20)
            Me.TxtContactPaperNumTot.Multiline = False
            Me.TxtContactPaperNumTot.Name = "TxtContactPaperNumTot"
            Me.TxtContactPaperNumTot.ReadOnlys = False
            Me.TxtContactPaperNumTot.SelectedText = ""
            Me.TxtContactPaperNumTot.SelectionLength = 0
            Me.TxtContactPaperNumTot.SelectionStart = 0
            Me.TxtContactPaperNumTot.Size = New System.Drawing.Size(53, 20)
            Me.TxtContactPaperNumTot.TabIndex = 1107
            Me.TxtContactPaperNumTot.Tag = ""
            Me.TxtContactPaperNumTot.TextAlign = 0
            Me.TxtContactPaperNumTot.TextValue = ""
            Me.TxtContactPaperNumTot.ToolTipText = ""
            '
            'TxtFixedPagerNum
            '
            Me.TxtFixedPagerNum.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFixedPagerNum.BorderColor = System.Drawing.Color.Empty
            Me.TxtFixedPagerNum.BorderStyle = 2
            Me.TxtFixedPagerNum.CaptionName = "확장처"
            Me.TxtFixedPagerNum.ForeColor = System.Drawing.SystemColors.ControlText
            Me.TxtFixedPagerNum.Location = New System.Drawing.Point(366, 333)
            Me.TxtFixedPagerNum.MaxLength = 50
            Me.TxtFixedPagerNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.TxtFixedPagerNum.Multiline = False
            Me.TxtFixedPagerNum.Name = "TxtFixedPagerNum"
            Me.TxtFixedPagerNum.ReadOnlys = False
            Me.TxtFixedPagerNum.SelectedText = ""
            Me.TxtFixedPagerNum.SelectionLength = 0
            Me.TxtFixedPagerNum.SelectionStart = 0
            Me.TxtFixedPagerNum.Size = New System.Drawing.Size(53, 20)
            Me.TxtFixedPagerNum.TabIndex = 1108
            Me.TxtFixedPagerNum.Tag = ""
            Me.TxtFixedPagerNum.TextAlign = 0
            Me.TxtFixedPagerNum.TextValue = ""
            Me.TxtFixedPagerNum.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(164, 333)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 20)
            Me.Label1.TabIndex = 1109
            Me.Label1.Text = "접수부수"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(303, 333)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(57, 20)
            Me.Label3.TabIndex = 1110
            Me.Label3.Text = "투입부수"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(100, 40)
            Me.popCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCompanyCd.MaxLength = 32767
            Me.popCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd.Name = "popCompanyCd"
            Me.popCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd.NameText = ""
            Me.popCompanyCd.ReadOnlys = False
            Me.popCompanyCd.SelectedText = ""
            Me.popCompanyCd.SelectionLength = 0
            Me.popCompanyCd.SelectionStart = 0
            Me.popCompanyCd.Size = New System.Drawing.Size(262, 20)
            Me.popCompanyCd.TabIndex = 2
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'btnExecDemand
            '
            Me.btnExecDemand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExecDemand.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExecDemand.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnExecDemand.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExecDemand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnExecDemand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnExecDemand.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnExecDemand.Location = New System.Drawing.Point(703, 22)
            Me.btnExecDemand.Name = "btnExecDemand"
            Me.btnExecDemand.Size = New System.Drawing.Size(96, 32)
            Me.btnExecDemand.TabIndex = 1111
            Me.btnExecDemand.Text = "청구계획 등록"
            Me.btnExecDemand.UseVisualStyleBackColor = True
            '
            'lblBillType_R
            '
            Me.lblBillType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBillType_R.Location = New System.Drawing.Point(406, 19)
            Me.lblBillType_R.Name = "lblBillType_R"
            Me.lblBillType_R.Size = New System.Drawing.Size(54, 12)
            Me.lblBillType_R.TabIndex = 1791
            Me.lblBillType_R.Text = "청구유형"
            Me.lblBillType_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBillType_R
            '
            Me.cboBillType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboBillType_R.CaptionName = "청구유형명"
            Me.cboBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBillType_R.ListCount = 0
            Me.cboBillType_R.Location = New System.Drawing.Point(465, 14)
            Me.cboBillType_R.MaxLength = 5
            Me.cboBillType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboBillType_R.Name = "cboBillType_R"
            Me.cboBillType_R.ReadOnlys = False
            Me.cboBillType_R.Size = New System.Drawing.Size(136, 20)
            Me.cboBillType_R.TabIndex = 1792
            Me.cboBillType_R.Tag = "code(청구유형명|전체);"
            Me.cboBillType_R.TextValue = ""
            '
            'popTrAdEmployeeNum
            '
            Me.popTrAdEmployeeNum.BorderColor = System.Drawing.Color.Empty
            Me.popTrAdEmployeeNum.BorderStyle = 2
            Me.popTrAdEmployeeNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTrAdEmployeeNum.CaptionName = "권유자 코드"
            Me.popTrAdEmployeeNum.CodeText = ""
            Me.popTrAdEmployeeNum.CodeWidth = 60
            Me.popTrAdEmployeeNum.Location = New System.Drawing.Point(81, 360)
            Me.popTrAdEmployeeNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popTrAdEmployeeNum.MaxLength = 6
            Me.popTrAdEmployeeNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popTrAdEmployeeNum.Name = "popTrAdEmployeeNum"
            Me.popTrAdEmployeeNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popTrAdEmployeeNum.NameText = ""
            Me.popTrAdEmployeeNum.ReadOnlys = False
            Me.popTrAdEmployeeNum.SelectedText = ""
            Me.popTrAdEmployeeNum.SelectionLength = 0
            Me.popTrAdEmployeeNum.SelectionStart = 0
            Me.popTrAdEmployeeNum.Size = New System.Drawing.Size(182, 20)
            Me.popTrAdEmployeeNum.TabIndex = 1793
            Me.popTrAdEmployeeNum.Tag = "code(사원 명);rtnValue(popTrAdEmployeeDeptCd);"
            Me.popTrAdEmployeeNum.TextAlign = 0
            Me.popTrAdEmployeeNum.TextValue = ""
            Me.popTrAdEmployeeNum.ToolTipText = ""
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label17.Location = New System.Drawing.Point(5, 361)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(67, 18)
            Me.Label17.TabIndex = 1796
            Me.Label17.Text = "주권유자명"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popAdEmployeeNum
            '
            Me.popAdEmployeeNum.BorderColor = System.Drawing.Color.Empty
            Me.popAdEmployeeNum.BorderStyle = 2
            Me.popAdEmployeeNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popAdEmployeeNum.CaptionName = "권유자 코드"
            Me.popAdEmployeeNum.CodeText = ""
            Me.popAdEmployeeNum.CodeWidth = 60
            Me.popAdEmployeeNum.Location = New System.Drawing.Point(81, 386)
            Me.popAdEmployeeNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popAdEmployeeNum.MaxLength = 6
            Me.popAdEmployeeNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popAdEmployeeNum.Name = "popAdEmployeeNum"
            Me.popAdEmployeeNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popAdEmployeeNum.NameText = ""
            Me.popAdEmployeeNum.ReadOnlys = False
            Me.popAdEmployeeNum.SelectedText = ""
            Me.popAdEmployeeNum.SelectionLength = 0
            Me.popAdEmployeeNum.SelectionStart = 0
            Me.popAdEmployeeNum.Size = New System.Drawing.Size(182, 20)
            Me.popAdEmployeeNum.TabIndex = 1794
            Me.popAdEmployeeNum.Tag = "code(사원 명);rtnValue(popAdEmployeeDeptCd);"
            Me.popAdEmployeeNum.TextAlign = 0
            Me.popAdEmployeeNum.TextValue = ""
            Me.popAdEmployeeNum.ToolTipText = ""
            '
            'Label36
            '
            Me.Label36.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label36.Location = New System.Drawing.Point(18, 387)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(54, 18)
            Me.Label36.TabIndex = 1795
            Me.Label36.Text = "권유자명"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnBulkApply
            '
            Me.btnBulkApply.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnBulkApply.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnBulkApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnBulkApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnBulkApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnBulkApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnBulkApply.Location = New System.Drawing.Point(691, 383)
            Me.btnBulkApply.Name = "btnBulkApply"
            Me.btnBulkApply.Size = New System.Drawing.Size(61, 23)
            Me.btnBulkApply.TabIndex = 1797
            Me.btnBulkApply.Text = "일괄적용"
            Me.btnBulkApply.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(562, 385)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(57, 20)
            Me.Label4.TabIndex = 1799
            Me.Label4.Text = "선택부수"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtSelectedNum
            '
            Me.txtSelectedNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtSelectedNum.BorderColor = System.Drawing.Color.Empty
            Me.txtSelectedNum.BorderStyle = 2
            Me.txtSelectedNum.CaptionName = "확장처"
            Me.txtSelectedNum.Enabled = False
            Me.txtSelectedNum.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtSelectedNum.Location = New System.Drawing.Point(625, 385)
            Me.txtSelectedNum.MaxLength = 50
            Me.txtSelectedNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSelectedNum.Multiline = False
            Me.txtSelectedNum.Name = "txtSelectedNum"
            Me.txtSelectedNum.ReadOnlys = False
            Me.txtSelectedNum.SelectedText = ""
            Me.txtSelectedNum.SelectionLength = 0
            Me.txtSelectedNum.SelectionStart = 0
            Me.txtSelectedNum.Size = New System.Drawing.Size(53, 20)
            Me.txtSelectedNum.TabIndex = 1798
            Me.txtSelectedNum.Tag = ""
            Me.txtSelectedNum.TextAlign = 1
            Me.txtSelectedNum.TextValue = "0"
            Me.txtSelectedNum.ToolTipText = ""
            '
            'popTrAdEmployeeDeptCd
            '
            Me.popTrAdEmployeeDeptCd.BorderColor = System.Drawing.Color.Empty
            Me.popTrAdEmployeeDeptCd.BorderStyle = 2
            Me.popTrAdEmployeeDeptCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTrAdEmployeeDeptCd.CaptionName = "부서 명"
            Me.popTrAdEmployeeDeptCd.CodeText = ""
            Me.popTrAdEmployeeDeptCd.CodeWidth = 50
            Me.popTrAdEmployeeDeptCd.Location = New System.Drawing.Point(357, 361)
            Me.popTrAdEmployeeDeptCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popTrAdEmployeeDeptCd.MaxLength = 5
            Me.popTrAdEmployeeDeptCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popTrAdEmployeeDeptCd.Name = "popTrAdEmployeeDeptCd"
            Me.popTrAdEmployeeDeptCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popTrAdEmployeeDeptCd.NameText = ""
            Me.popTrAdEmployeeDeptCd.ReadOnlys = False
            Me.popTrAdEmployeeDeptCd.SelectedText = ""
            Me.popTrAdEmployeeDeptCd.SelectionLength = 0
            Me.popTrAdEmployeeDeptCd.SelectionStart = 0
            Me.popTrAdEmployeeDeptCd.Size = New System.Drawing.Size(180, 20)
            Me.popTrAdEmployeeDeptCd.TabIndex = 1800
            Me.popTrAdEmployeeDeptCd.Tag = "code(부서 명);"
            Me.popTrAdEmployeeDeptCd.TextAlign = 0
            Me.popTrAdEmployeeDeptCd.TextValue = ""
            Me.popTrAdEmployeeDeptCd.ToolTipText = ""
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(275, 365)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(77, 16)
            Me.Label15.TabIndex = 1803
            Me.Label15.Text = "주권유자부서"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popAdEmployeeDeptCd
            '
            Me.popAdEmployeeDeptCd.BorderColor = System.Drawing.Color.Empty
            Me.popAdEmployeeDeptCd.BorderStyle = 2
            Me.popAdEmployeeDeptCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popAdEmployeeDeptCd.CaptionName = "부서 명"
            Me.popAdEmployeeDeptCd.CodeText = ""
            Me.popAdEmployeeDeptCd.CodeWidth = 50
            Me.popAdEmployeeDeptCd.Location = New System.Drawing.Point(357, 386)
            Me.popAdEmployeeDeptCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popAdEmployeeDeptCd.MaxLength = 5
            Me.popAdEmployeeDeptCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popAdEmployeeDeptCd.Name = "popAdEmployeeDeptCd"
            Me.popAdEmployeeDeptCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popAdEmployeeDeptCd.NameText = ""
            Me.popAdEmployeeDeptCd.ReadOnlys = False
            Me.popAdEmployeeDeptCd.SelectedText = ""
            Me.popAdEmployeeDeptCd.SelectionLength = 0
            Me.popAdEmployeeDeptCd.SelectionStart = 0
            Me.popAdEmployeeDeptCd.Size = New System.Drawing.Size(180, 20)
            Me.popAdEmployeeDeptCd.TabIndex = 1801
            Me.popAdEmployeeDeptCd.Tag = "code(부서 명);"
            Me.popAdEmployeeDeptCd.TextAlign = 0
            Me.popAdEmployeeDeptCd.TextValue = ""
            Me.popAdEmployeeDeptCd.ToolTipText = ""
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label14.Location = New System.Drawing.Point(275, 388)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(77, 16)
            Me.Label14.TabIndex = 1802
            Me.Label14.Text = "권유자부서"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNE101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popTrAdEmployeeDeptCd)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.popAdEmployeeDeptCd)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtSelectedNum)
            Me.Controls.Add(Me.btnBulkApply)
            Me.Controls.Add(Me.popTrAdEmployeeNum)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.popAdEmployeeNum)
            Me.Controls.Add(Me.Label36)
            Me.Controls.Add(Me.btnExecDemand)
            Me.Controls.Add(Me.btnEmExReader)
            Me.Controls.Add(Me.brnReExt)
            Me.Controls.Add(Me.lblBillType_R)
            Me.Controls.Add(Me.cboBillType_R)
            Me.Controls.Add(Me.dtpToExpand)
            Me.Controls.Add(Me.dtpFromExpand)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtFixedPagerNum)
            Me.Controls.Add(Me.TxtContactPaperNumTot)
            Me.Controls.Add(Me.BtnNewLine)
            Me.Controls.Add(Me.btnOpenExcel)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.btnDel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnNew)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNE101"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblExpandDt, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.btnNew, 0)
            Me.Controls.SetChildIndex(Me.btnSave, 0)
            Me.Controls.SetChildIndex(Me.btnDel, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.btnOpenExcel, 0)
            Me.Controls.SetChildIndex(Me.BtnNewLine, 0)
            Me.Controls.SetChildIndex(Me.TxtContactPaperNumTot, 0)
            Me.Controls.SetChildIndex(Me.TxtFixedPagerNum, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.dtpFromExpand, 0)
            Me.Controls.SetChildIndex(Me.dtpToExpand, 0)
            Me.Controls.SetChildIndex(Me.cboBillType_R, 0)
            Me.Controls.SetChildIndex(Me.lblBillType_R, 0)
            Me.Controls.SetChildIndex(Me.brnReExt, 0)
            Me.Controls.SetChildIndex(Me.btnEmExReader, 0)
            Me.Controls.SetChildIndex(Me.btnExecDemand, 0)
            Me.Controls.SetChildIndex(Me.Label36, 0)
            Me.Controls.SetChildIndex(Me.popAdEmployeeNum, 0)
            Me.Controls.SetChildIndex(Me.Label17, 0)
            Me.Controls.SetChildIndex(Me.popTrAdEmployeeNum, 0)
            Me.Controls.SetChildIndex(Me.btnBulkApply, 0)
            Me.Controls.SetChildIndex(Me.txtSelectedNum, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.Label14, 0)
            Me.Controls.SetChildIndex(Me.popAdEmployeeDeptCd, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.popTrAdEmployeeDeptCd, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpToExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpFromExpand As ubiLease.CommonControls.dtp
        Friend WithEvents btnNew As ubiLease.CommonControls.btn
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents btnSave As ubiLease.CommonControls.btn
        Friend WithEvents btnDel As ubiLease.CommonControls.btn
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents brnReExt As ubiLease.CommonControls.btn
        Friend WithEvents btnOpenExcel As ubiLease.CommonControls.btn
        Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnEmExReader As ubiLease.CommonControls.btn
        Friend WithEvents BtnNewLine As ubiLease.CommonControls.btn
        Friend WithEvents TxtContactPaperNumTot As ubiLease.CommonControls.txt
        Friend WithEvents TxtFixedPagerNum As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents btnExecDemand As ubiLease.CommonControls.btn
        Friend WithEvents lblBillType_R As System.Windows.Forms.Label
        Friend WithEvents cboBillType_R As ubiLease.CommonControls.cbo
        Friend WithEvents popTrAdEmployeeNum As ubiLease.CommonControls.pop
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents popAdEmployeeNum As ubiLease.CommonControls.pop
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents btnBulkApply As ubiLease.CommonControls.btn
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtSelectedNum As ubiLease.CommonControls.txt
        Friend WithEvents popTrAdEmployeeDeptCd As ubiLease.CommonControls.pop
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents popAdEmployeeDeptCd As ubiLease.CommonControls.pop
        Friend WithEvents Label14 As System.Windows.Forms.Label


    End Class

End Namespace
