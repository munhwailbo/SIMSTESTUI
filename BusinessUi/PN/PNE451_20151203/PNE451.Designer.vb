Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE451
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE451))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.lblCodeDivision = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.popChargeEmpNum = New ubiLease.CommonControls.txt
            Me.popBranchNum = New ubiLease.CommonControls.txt
            Me.cboOldOrNew = New ubiLease.CommonControls.cbo
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optExpAmt3 = New System.Windows.Forms.RadioButton
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.optExpAmt2 = New System.Windows.Forms.RadioButton
            Me.Label2 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.popEmployeeExpNum_R = New ubiLease.CommonControls.pop
            Me.Label15 = New System.Windows.Forms.Label
            Me.Opt1 = New ubiLease.CommonControls.opt
            Me.RadioButton2 = New System.Windows.Forms.RadioButton
            Me.RadioButton3 = New System.Windows.Forms.RadioButton
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(239, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(57, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 6
            Me.lblCodeDivisionHangulName.Text = "담당명"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblCodeDivisionHangulName.Visible = False
            '
            'lblCodeDivision
            '
            Me.lblCodeDivision.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivision.Location = New System.Drawing.Point(452, 22)
            Me.lblCodeDivision.Name = "lblCodeDivision"
            Me.lblCodeDivision.Size = New System.Drawing.Size(60, 15)
            Me.lblCodeDivision.TabIndex = 7
            Me.lblCodeDivision.Text = "지국 명"
            Me.lblCodeDivision.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblCodeDivision.Visible = False
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 67)
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(4, 74)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 497)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 9
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "기준 일자"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(116, 19)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(117, 20)
            Me.dtpBaseYear.TabIndex = 0
            Me.dtpBaseYear.Tag = "format(&&&&-&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = ""
            Me.dtpBaseYear.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(38, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 15)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "기준 일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BackColor = System.Drawing.SystemColors.Window
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.CaptionName = "담당 명"
            Me.popChargeEmpNum.Location = New System.Drawing.Point(305, 19)
            Me.popChargeEmpNum.MaxLength = 32767
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popChargeEmpNum.Multiline = False
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(115, 20)
            Me.popChargeEmpNum.TabIndex = 1
            Me.popChargeEmpNum.Tag = Nothing
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            Me.popChargeEmpNum.Visible = False
            '
            'popBranchNum
            '
            Me.popBranchNum.BackColor = System.Drawing.SystemColors.Window
            Me.popBranchNum.BorderColor = System.Drawing.Color.Empty
            Me.popBranchNum.BorderStyle = 2
            Me.popBranchNum.CaptionName = "지국 명"
            Me.popBranchNum.Location = New System.Drawing.Point(518, 19)
            Me.popBranchNum.MaxLength = 32767
            Me.popBranchNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popBranchNum.Multiline = False
            Me.popBranchNum.Name = "popBranchNum"
            Me.popBranchNum.ReadOnlys = False
            Me.popBranchNum.SelectedText = ""
            Me.popBranchNum.SelectionLength = 0
            Me.popBranchNum.SelectionStart = 0
            Me.popBranchNum.Size = New System.Drawing.Size(115, 20)
            Me.popBranchNum.TabIndex = 2
            Me.popBranchNum.Tag = Nothing
            Me.popBranchNum.TextAlign = 0
            Me.popBranchNum.TextValue = ""
            Me.popBranchNum.ToolTipText = ""
            Me.popBranchNum.Visible = False
            '
            'cboOldOrNew
            '
            Me.cboOldOrNew.CaptionName = "전임현임구분"
            Me.cboOldOrNew.Enabled = False
            Me.cboOldOrNew.ListCount = 0
            Me.cboOldOrNew.Location = New System.Drawing.Point(676, 19)
            Me.cboOldOrNew.Name = "cboOldOrNew"
            Me.cboOldOrNew.ReadOnlys = False
            Me.cboOldOrNew.Size = New System.Drawing.Size(114, 20)
            Me.cboOldOrNew.TabIndex = 3
            Me.cboOldOrNew.Tag = "code(담당자구분코드|전체);"
            Me.cboOldOrNew.TextValue = ""
            Me.cboOldOrNew.Visible = False
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optExpAmt3)
            Me.Opt2.Controls.Add(Me.optExpAmt1)
            Me.Opt2.Controls.Add(Me.optExpAmt2)
            Me.Opt2.Location = New System.Drawing.Point(6, 78)
            Me.Opt2.MaximumSize = New System.Drawing.Size(1000, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(611, 36)
            Me.Opt2.TabIndex = 8
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optExpAmt3
            '
            Me.optExpAmt3.AutoSize = True
            Me.optExpAmt3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt3.Location = New System.Drawing.Point(408, 9)
            Me.optExpAmt3.Name = "optExpAmt3"
            Me.optExpAmt3.Size = New System.Drawing.Size(151, 16)
            Me.optExpAmt3.TabIndex = 2
            Me.optExpAmt3.Text = "확장처별 월배달비 현황"
            Me.optExpAmt3.UseVisualStyleBackColor = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Checked = True
            Me.optExpAmt1.Location = New System.Drawing.Point(21, 9)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(163, 16)
            Me.optExpAmt1.TabIndex = 0
            Me.optExpAmt1.TabStop = True
            Me.optExpAmt1.Text = "본사수금 구독료지급 현황"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'optExpAmt2
            '
            Me.optExpAmt2.AutoSize = True
            Me.optExpAmt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt2.Location = New System.Drawing.Point(209, 9)
            Me.optExpAmt2.Name = "optExpAmt2"
            Me.optExpAmt2.Size = New System.Drawing.Size(175, 16)
            Me.optExpAmt2.TabIndex = 1
            Me.optExpAmt2.Text = "확장처별 월구독료 공제현황"
            Me.optExpAmt2.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label2.Location = New System.Drawing.Point(624, 84)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(177, 25)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(621, 78)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(186, 36)
            Me.PictureBox1.TabIndex = 1643
            Me.PictureBox1.TabStop = False
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(116, 40)
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
            Me.popCompanyCd.Size = New System.Drawing.Size(272, 20)
            Me.popCompanyCd.TabIndex = 1644
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(38, 40)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(73, 20)
            Me.lblBranchNm.TabIndex = 1645
            Me.lblBranchNm.Text = "확장처 명"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label3.Location = New System.Drawing.Point(79, 581)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(131, 18)
            Me.Label3.TabIndex = 1646
            Me.Label3.Text = "(A) 총청구대상총액"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.White
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(4, 574)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(804, 70)
            Me.PictureBox2.TabIndex = 1647
            Me.PictureBox2.TabStop = False
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label4.Location = New System.Drawing.Point(79, 599)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(131, 18)
            Me.Label4.TabIndex = 1646
            Me.Label4.Text = "(B) 총청구액"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label5.Location = New System.Drawing.Point(79, 623)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(131, 18)
            Me.Label5.TabIndex = 1648
            Me.Label5.Text = "(C) 미청구총액 (A-B)"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.White
            Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label6.Location = New System.Drawing.Point(284, 623)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(131, 18)
            Me.Label6.TabIndex = 1651
            Me.Label6.Text = "(F) 미수금액 (B-E)"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label7.BackColor = System.Drawing.Color.White
            Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label7.Location = New System.Drawing.Point(284, 602)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(131, 18)
            Me.Label7.TabIndex = 1650
            Me.Label7.Text = "(E) 수금총액"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label8.BackColor = System.Drawing.Color.White
            Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label8.Location = New System.Drawing.Point(284, 581)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(131, 18)
            Me.Label8.TabIndex = 1649
            Me.Label8.Text = "(D) 미청구액"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label10.BackColor = System.Drawing.Color.White
            Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label10.Location = New System.Drawing.Point(36, 614)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(174, 10)
            Me.Label10.TabIndex = 1654
            Me.Label10.Text = "-----------------------------------"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label11
            '
            Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label11.BackColor = System.Drawing.Color.White
            Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label11.Location = New System.Drawing.Point(466, 617)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(131, 18)
            Me.Label11.TabIndex = 1655
            Me.Label11.Text = "(H) 미배분 (E-G)"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label12.BackColor = System.Drawing.Color.White
            Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label12.Location = New System.Drawing.Point(466, 599)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(131, 18)
            Me.Label12.TabIndex = 1656
            Me.Label12.Text = "(G) 배분"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.BackColor = System.Drawing.Color.White
            Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Label9.Location = New System.Drawing.Point(54, 599)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(20, 18)
            Me.Label9.TabIndex = 1659
            Me.Label9.Text = "-"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popEmployeeExpNum_R
            '
            Me.popEmployeeExpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeExpNum_R.BorderStyle = 2
            Me.popEmployeeExpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeExpNum_R.CaptionName = "사원확장 명"
            Me.popEmployeeExpNum_R.CodeText = ""
            Me.popEmployeeExpNum_R.CodeWidth = 90
            Me.popEmployeeExpNum_R.Location = New System.Drawing.Point(494, 40)
            Me.popEmployeeExpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeExpNum_R.MaxLength = 12
            Me.popEmployeeExpNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeExpNum_R.Name = "popEmployeeExpNum_R"
            Me.popEmployeeExpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeExpNum_R.NameText = ""
            Me.popEmployeeExpNum_R.ReadOnlys = False
            Me.popEmployeeExpNum_R.SelectedText = ""
            Me.popEmployeeExpNum_R.SelectionLength = 0
            Me.popEmployeeExpNum_R.SelectionStart = 0
            Me.popEmployeeExpNum_R.Size = New System.Drawing.Size(287, 20)
            Me.popEmployeeExpNum_R.TabIndex = 1758
            Me.popEmployeeExpNum_R.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum_R.TextAlign = 0
            Me.popEmployeeExpNum_R.TextValue = ""
            Me.popEmployeeExpNum_R.ToolTipText = ""
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(415, 41)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(73, 18)
            Me.Label15.TabIndex = 1759
            Me.Label15.Text = "확  장  명"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Opt1
            '
            Me.Opt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt1.CaptionName = Nothing
            Me.Opt1.Controls.Add(Me.RadioButton2)
            Me.Opt1.Controls.Add(Me.RadioButton3)
            Me.Opt1.Location = New System.Drawing.Point(494, 9)
            Me.Opt1.MaximumSize = New System.Drawing.Size(1000, 100)
            Me.Opt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt1.Name = "Opt1"
            Me.Opt1.ReadOnlys = False
            Me.Opt1.Size = New System.Drawing.Size(287, 25)
            Me.Opt1.TabIndex = 1760
            Me.Opt1.Tag = Nothing
            Me.Opt1.TextValue = ""
            Me.Opt1.Visible = False
            '
            'RadioButton2
            '
            Me.RadioButton2.AutoSize = True
            Me.RadioButton2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.RadioButton2.Checked = True
            Me.RadioButton2.Location = New System.Drawing.Point(43, 3)
            Me.RadioButton2.Name = "RadioButton2"
            Me.RadioButton2.Size = New System.Drawing.Size(75, 16)
            Me.RadioButton2.TabIndex = 0
            Me.RadioButton2.TabStop = True
            Me.RadioButton2.Text = "확장처 별"
            Me.RadioButton2.UseVisualStyleBackColor = False
            '
            'RadioButton3
            '
            Me.RadioButton3.AutoSize = True
            Me.RadioButton3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.RadioButton3.Location = New System.Drawing.Point(165, 3)
            Me.RadioButton3.Name = "RadioButton3"
            Me.RadioButton3.Size = New System.Drawing.Size(63, 16)
            Me.RadioButton3.TabIndex = 1
            Me.RadioButton3.Text = "확장 별"
            Me.RadioButton3.UseVisualStyleBackColor = False
            '
            'PNE451
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Opt1)
            Me.Controls.Add(Me.popEmployeeExpNum_R)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.cboOldOrNew)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.popBranchNum)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.lblCodeDivision)
            Me.Name = "PNE451"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.lblCodeDivision, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.popBranchNum, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            Me.Controls.SetChildIndex(Me.cboOldOrNew, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYear, 0)
            Me.Controls.SetChildIndex(Me.Opt2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.Label10, 0)
            Me.Controls.SetChildIndex(Me.Label11, 0)
            Me.Controls.SetChildIndex(Me.Label12, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeExpNum_R, 0)
            Me.Controls.SetChildIndex(Me.Opt1, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt1.ResumeLayout(False)
            Me.Opt1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents lblCodeDivision As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.txt
        Friend WithEvents popBranchNum As ubiLease.CommonControls.txt
        Friend WithEvents cboOldOrNew As ubiLease.CommonControls.cbo
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt2 As System.Windows.Forms.RadioButton
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents optExpAmt3 As System.Windows.Forms.RadioButton
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeExpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Opt1 As ubiLease.CommonControls.opt
        Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton

    End Class

End Namespace
