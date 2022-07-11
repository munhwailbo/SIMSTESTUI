Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB101))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.txtNewGubn = New ubiLease.CommonControls.txt
            Me.txtBranchCd = New ubiLease.CommonControls.txt
            Me.Label26 = New System.Windows.Forms.Label
            Me.cboChargeTypeCd2 = New ubiLease.CommonControls.cbo
            Me.popChargeEmpNum_2 = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.lblEmployeeNumber = New System.Windows.Forms.Label
            Me.txtBranchNm = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.grd_4 = New ubiLease.GridControl.grd
            Me.grd_5 = New ubiLease.GridControl.grd
            Me.grd_6 = New ubiLease.GridControl.grd
            Me.btngrd_3 = New System.Windows.Forms.Button
            Me.btngrd_7 = New System.Windows.Forms.Button
            Me.btngrd_6 = New System.Windows.Forms.Button
            Me.btngrd_5 = New System.Windows.Forms.Button
            Me.btngrd_4 = New System.Windows.Forms.Button
            Me.btnPlus = New System.Windows.Forms.Button
            Me.btnSave = New System.Windows.Forms.Button
            Me.Label3 = New System.Windows.Forms.Label
            Me.cboChargeTypeCd = New ubiLease.CommonControls.cbo
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtBranchNm_2 = New ubiLease.CommonControls.txt
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.btnDelete = New System.Windows.Forms.Button
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.lbl_grd_Title = New System.Windows.Forms.Label
            Me.txtBizArea = New ubiLease.CommonControls.txt
            Me.txtMkTargetGroup = New ubiLease.CommonControls.txt
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.lbl = New System.Windows.Forms.Label
            Me.dtpOpenDate = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.dtpCloseDate = New ubiLease.CommonControls.dtp
            Me.txtCloseRemark = New ubiLease.CommonControls.txt
            Me.Label9 = New System.Windows.Forms.Label
            Me.grd_7 = New ubiLease.GridControl.grd
            Me.chkCloseCheck = New ubiLease.CommonControls.chk
            Me.chkOpenCheck = New ubiLease.CommonControls.chk
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
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
            Me.grd_1.Location = New System.Drawing.Point(5, 61)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(486, 229)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtNewGubn
            '
            Me.txtNewGubn.BackColor = System.Drawing.SystemColors.Window
            Me.txtNewGubn.BorderColor = System.Drawing.Color.Empty
            Me.txtNewGubn.BorderStyle = 2
            Me.txtNewGubn.CaptionName = "지국 명"
            Me.txtNewGubn.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtNewGubn.Location = New System.Drawing.Point(758, 75)
            Me.txtNewGubn.MaxLength = 6
            Me.txtNewGubn.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNewGubn.Multiline = False
            Me.txtNewGubn.Name = "txtNewGubn"
            Me.txtNewGubn.ReadOnlys = False
            Me.txtNewGubn.SelectedText = ""
            Me.txtNewGubn.SelectionLength = 0
            Me.txtNewGubn.SelectionStart = 0
            Me.txtNewGubn.Size = New System.Drawing.Size(20, 20)
            Me.txtNewGubn.TabIndex = 1055
            Me.txtNewGubn.Tag = ""
            Me.txtNewGubn.TextAlign = 0
            Me.txtNewGubn.TextValue = ""
            Me.txtNewGubn.ToolTipText = ""
            Me.txtNewGubn.Visible = False
            '
            'txtBranchCd
            '
            Me.txtBranchCd.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchCd.BorderStyle = 2
            Me.txtBranchCd.CaptionName = "사원 번호"
            Me.txtBranchCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBranchCd.Location = New System.Drawing.Point(585, 75)
            Me.txtBranchCd.MaxLength = 7
            Me.txtBranchCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchCd.Multiline = False
            Me.txtBranchCd.Name = "txtBranchCd"
            Me.txtBranchCd.ReadOnlys = False
            Me.txtBranchCd.SelectedText = ""
            Me.txtBranchCd.SelectionLength = 0
            Me.txtBranchCd.SelectionStart = 0
            Me.txtBranchCd.Size = New System.Drawing.Size(167, 20)
            Me.txtBranchCd.TabIndex = 1054
            Me.txtBranchCd.Tag = "need;"
            Me.txtBranchCd.TextAlign = 0
            Me.txtBranchCd.TextValue = ""
            Me.txtBranchCd.ToolTipText = ""
            '
            'Label26
            '
            Me.Label26.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label26.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label26.Location = New System.Drawing.Point(512, 141)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(67, 20)
            Me.Label26.TabIndex = 1053
            Me.Label26.Text = "담당자유형"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboChargeTypeCd2
            '
            Me.cboChargeTypeCd2.CaptionName = "담당자 유형 코드"
            Me.cboChargeTypeCd2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboChargeTypeCd2.ListCount = 0
            Me.cboChargeTypeCd2.Location = New System.Drawing.Point(585, 141)
            Me.cboChargeTypeCd2.Name = "cboChargeTypeCd2"
            Me.cboChargeTypeCd2.ReadOnlys = False
            Me.cboChargeTypeCd2.Size = New System.Drawing.Size(193, 20)
            Me.cboChargeTypeCd2.TabIndex = 1052
            Me.cboChargeTypeCd2.Tag = "code(담당자유형코드|선택하세요);"
            Me.cboChargeTypeCd2.TextValue = ""
            '
            'popChargeEmpNum_2
            '
            Me.popChargeEmpNum_2.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_2.BorderStyle = 2
            Me.popChargeEmpNum_2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_2.CaptionName = "담당자"
            Me.popChargeEmpNum_2.CodeText = ""
            Me.popChargeEmpNum_2.CodeWidth = 60
            Me.popChargeEmpNum_2.Location = New System.Drawing.Point(585, 118)
            Me.popChargeEmpNum_2.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popChargeEmpNum_2.MaxLength = 6
            Me.popChargeEmpNum_2.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum_2.Name = "popChargeEmpNum_2"
            Me.popChargeEmpNum_2.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_2.NameText = ""
            Me.popChargeEmpNum_2.ReadOnlys = False
            Me.popChargeEmpNum_2.SelectedText = ""
            Me.popChargeEmpNum_2.SelectionLength = 0
            Me.popChargeEmpNum_2.SelectionStart = 0
            Me.popChargeEmpNum_2.Size = New System.Drawing.Size(193, 20)
            Me.popChargeEmpNum_2.TabIndex = 1051
            Me.popChargeEmpNum_2.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_2.TextAlign = 0
            Me.popChargeEmpNum_2.TextValue = ""
            Me.popChargeEmpNum_2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(508, 118)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(71, 20)
            Me.Label2.TabIndex = 1050
            Me.Label2.Text = "현 담당자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblEmployeeNumber
            '
            Me.lblEmployeeNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblEmployeeNumber.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblEmployeeNumber.Location = New System.Drawing.Point(508, 97)
            Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
            Me.lblEmployeeNumber.Size = New System.Drawing.Size(71, 20)
            Me.lblEmployeeNumber.TabIndex = 1048
            Me.lblEmployeeNumber.Text = "지국명"
            Me.lblEmployeeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBranchNm
            '
            Me.txtBranchNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm.BorderStyle = 2
            Me.txtBranchNm.CaptionName = "지국 명"
            Me.txtBranchNm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBranchNm.Location = New System.Drawing.Point(585, 97)
            Me.txtBranchNm.MaxLength = 30
            Me.txtBranchNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm.Multiline = False
            Me.txtBranchNm.Name = "txtBranchNm"
            Me.txtBranchNm.ReadOnlys = False
            Me.txtBranchNm.SelectedText = ""
            Me.txtBranchNm.SelectionLength = 0
            Me.txtBranchNm.SelectionStart = 0
            Me.txtBranchNm.Size = New System.Drawing.Size(193, 20)
            Me.txtBranchNm.TabIndex = 1049
            Me.txtBranchNm.Tag = "need;"
            Me.txtBranchNm.TextAlign = 0
            Me.txtBranchNm.TextValue = ""
            Me.txtBranchNm.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(508, 74)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 20)
            Me.Label1.TabIndex = 1046
            Me.Label1.Text = "지국코드"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(5, 347)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(799, 297)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 1034
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_3.Visible = False
            '
            'grd_4
            '
            Me.grd_4.AllowBigSelection = False
            Me.grd_4.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_4.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_4.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_4.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_4.Cols = 2
            Me.grd_4.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExtendLastCol = True
            Me.grd_4.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_4.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_4.FrozenCols = 1
            Me.grd_4.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_4.Location = New System.Drawing.Point(5, 346)
            Me.grd_4.Name = "grd_4"
            Me.grd_4.NodeClosedPicture = Nothing
            Me.grd_4.NodeOpenPicture = Nothing
            Me.grd_4.OutlineCol = -1
            Me.grd_4.RowHeightMax = 18
            Me.grd_4.RowHeightMin = 18
            Me.grd_4.Rows = 2
            Me.grd_4.Size = New System.Drawing.Size(799, 295)
            Me.grd_4.StyleInfo = resources.GetString("grd_4.StyleInfo")
            Me.grd_4.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_4.TabIndex = 1036
            Me.grd_4.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_4.Visible = False
            '
            'grd_5
            '
            Me.grd_5.AllowBigSelection = False
            Me.grd_5.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_5.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_5.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_5.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_5.Cols = 2
            Me.grd_5.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_5.ExplorerBar = 0
            Me.grd_5.ExtendLastCol = True
            Me.grd_5.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_5.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_5.FrozenCols = 1
            Me.grd_5.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_5.Location = New System.Drawing.Point(5, 346)
            Me.grd_5.Name = "grd_5"
            Me.grd_5.NodeClosedPicture = Nothing
            Me.grd_5.NodeOpenPicture = Nothing
            Me.grd_5.OutlineCol = -1
            Me.grd_5.RowHeightMax = 18
            Me.grd_5.RowHeightMin = 18
            Me.grd_5.Rows = 2
            Me.grd_5.Size = New System.Drawing.Size(799, 295)
            Me.grd_5.StyleInfo = resources.GetString("grd_5.StyleInfo")
            Me.grd_5.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_5.TabIndex = 1037
            Me.grd_5.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_5.Visible = False
            '
            'grd_6
            '
            Me.grd_6.AllowBigSelection = False
            Me.grd_6.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_6.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_6.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_6.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_6.Cols = 2
            Me.grd_6.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_6.ExplorerBar = 0
            Me.grd_6.ExtendLastCol = True
            Me.grd_6.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_6.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_6.FrozenCols = 1
            Me.grd_6.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_6.Location = New System.Drawing.Point(5, 346)
            Me.grd_6.Name = "grd_6"
            Me.grd_6.NodeClosedPicture = Nothing
            Me.grd_6.NodeOpenPicture = Nothing
            Me.grd_6.OutlineCol = -1
            Me.grd_6.RowHeightMax = 18
            Me.grd_6.RowHeightMin = 18
            Me.grd_6.Rows = 2
            Me.grd_6.Size = New System.Drawing.Size(799, 295)
            Me.grd_6.StyleInfo = resources.GetString("grd_6.StyleInfo")
            Me.grd_6.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_6.TabIndex = 1038
            Me.grd_6.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_6.Visible = False
            '
            'btngrd_3
            '
            Me.btngrd_3.Location = New System.Drawing.Point(361, 294)
            Me.btngrd_3.Name = "btngrd_3"
            Me.btngrd_3.Size = New System.Drawing.Size(89, 25)
            Me.btngrd_3.TabIndex = 1041
            Me.btngrd_3.Text = "지국사무실"
            Me.btngrd_3.UseVisualStyleBackColor = True
            '
            'btngrd_7
            '
            Me.btngrd_7.Location = New System.Drawing.Point(5, 294)
            Me.btngrd_7.Name = "btngrd_7"
            Me.btngrd_7.Size = New System.Drawing.Size(89, 25)
            Me.btngrd_7.TabIndex = 1042
            Me.btngrd_7.Text = "담당자이력"
            Me.btngrd_7.UseVisualStyleBackColor = True
            '
            'btngrd_6
            '
            Me.btngrd_6.Location = New System.Drawing.Point(272, 294)
            Me.btngrd_6.Name = "btngrd_6"
            Me.btngrd_6.Size = New System.Drawing.Size(89, 25)
            Me.btngrd_6.TabIndex = 1043
            Me.btngrd_6.Text = "관할지역"
            Me.btngrd_6.UseVisualStyleBackColor = True
            '
            'btngrd_5
            '
            Me.btngrd_5.Location = New System.Drawing.Point(183, 294)
            Me.btngrd_5.Name = "btngrd_5"
            Me.btngrd_5.Size = New System.Drawing.Size(89, 25)
            Me.btngrd_5.TabIndex = 1044
            Me.btngrd_5.Text = "지원장비"
            Me.btngrd_5.UseVisualStyleBackColor = True
            '
            'btngrd_4
            '
            Me.btngrd_4.Location = New System.Drawing.Point(94, 294)
            Me.btngrd_4.Name = "btngrd_4"
            Me.btngrd_4.Size = New System.Drawing.Size(89, 25)
            Me.btngrd_4.TabIndex = 1045
            Me.btngrd_4.Text = "인쇄공장"
            Me.btngrd_4.UseVisualStyleBackColor = True
            '
            'btnPlus
            '
            Me.btnPlus.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnPlus.Location = New System.Drawing.Point(585, 316)
            Me.btnPlus.Name = "btnPlus"
            Me.btnPlus.Size = New System.Drawing.Size(71, 27)
            Me.btnPlus.TabIndex = 1046
            Me.btnPlus.Text = "추가"
            Me.btnPlus.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnSave.Location = New System.Drawing.Point(656, 316)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(71, 27)
            Me.btnSave.TabIndex = 1047
            Me.btnSave.Text = "저장"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(445, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 20)
            Me.Label3.TabIndex = 1061
            Me.Label3.Text = "담당자유형"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboChargeTypeCd
            '
            Me.cboChargeTypeCd.CaptionName = "담당자 유형 코드"
            Me.cboChargeTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboChargeTypeCd.ListCount = 0
            Me.cboChargeTypeCd.Location = New System.Drawing.Point(518, 20)
            Me.cboChargeTypeCd.Name = "cboChargeTypeCd"
            Me.cboChargeTypeCd.ReadOnlys = False
            Me.cboChargeTypeCd.Size = New System.Drawing.Size(114, 20)
            Me.cboChargeTypeCd.TabIndex = 1060
            Me.cboChargeTypeCd.Tag = "code(담당자유형코드|선택하세요);"
            Me.cboChargeTypeCd.TextValue = ""
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "담당자"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 60
            Me.popChargeEmpNum.Location = New System.Drawing.Point(249, 20)
            Me.popChargeEmpNum.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popChargeEmpNum.MaxLength = 6
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum.NameText = ""
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(183, 20)
            Me.popChargeEmpNum.TabIndex = 1059
            Me.popChargeEmpNum.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(197, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(46, 20)
            Me.Label4.TabIndex = 1058
            Me.Label4.Text = "담당자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label5.Location = New System.Drawing.Point(28, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 20)
            Me.Label5.TabIndex = 1056
            Me.Label5.Text = "지국명"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBranchNm_2
            '
            Me.txtBranchNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm_2.BorderStyle = 2
            Me.txtBranchNm_2.CaptionName = "지국 명"
            Me.txtBranchNm_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBranchNm_2.Location = New System.Drawing.Point(78, 20)
            Me.txtBranchNm_2.MaxLength = 6
            Me.txtBranchNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm_2.Multiline = False
            Me.txtBranchNm_2.Name = "txtBranchNm_2"
            Me.txtBranchNm_2.ReadOnlys = False
            Me.txtBranchNm_2.SelectedText = ""
            Me.txtBranchNm_2.SelectionLength = 0
            Me.txtBranchNm_2.SelectionStart = 0
            Me.txtBranchNm_2.Size = New System.Drawing.Size(115, 20)
            Me.txtBranchNm_2.TabIndex = 1057
            Me.txtBranchNm_2.Tag = ""
            Me.txtBranchNm_2.TextAlign = 0
            Me.txtBranchNm_2.TextValue = ""
            Me.txtBranchNm_2.ToolTipText = ""
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(799, 50)
            Me.picCriteria.TabIndex = 613
            Me.picCriteria.TabStop = False
            '
            'btnDelete
            '
            Me.btnDelete.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnDelete.Location = New System.Drawing.Point(727, 316)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(71, 27)
            Me.btnDelete.TabIndex = 1062
            Me.btnDelete.Text = "삭제"
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(499, 61)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(305, 229)
            Me.picIo_2.TabIndex = 1063
            Me.picIo_2.TabStop = False
            '
            'lbl_grd_Title
            '
            Me.lbl_grd_Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbl_grd_Title.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbl_grd_Title.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lbl_grd_Title.Location = New System.Drawing.Point(3, 323)
            Me.lbl_grd_Title.Name = "lbl_grd_Title"
            Me.lbl_grd_Title.Size = New System.Drawing.Size(801, 20)
            Me.lbl_grd_Title.TabIndex = 1064
            Me.lbl_grd_Title.Tag = "left;"
            Me.lbl_grd_Title.Text = "[ 담당자이력 ]"
            Me.lbl_grd_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtBizArea
            '
            Me.txtBizArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtBizArea.BackColor = System.Drawing.SystemColors.Window
            Me.txtBizArea.BorderColor = System.Drawing.Color.Empty
            Me.txtBizArea.BorderStyle = 2
            Me.txtBizArea.CaptionName = "관할 지역"
            Me.txtBizArea.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBizArea.Location = New System.Drawing.Point(586, 168)
            Me.txtBizArea.MaxLength = 2000
            Me.txtBizArea.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBizArea.Multiline = False
            Me.txtBizArea.Name = "txtBizArea"
            Me.txtBizArea.ReadOnlys = False
            Me.txtBizArea.SelectedText = ""
            Me.txtBizArea.SelectionLength = 0
            Me.txtBizArea.SelectionStart = 0
            Me.txtBizArea.Size = New System.Drawing.Size(193, 20)
            Me.txtBizArea.TabIndex = 1065
            Me.txtBizArea.Tag = ""
            Me.txtBizArea.TextAlign = 0
            Me.txtBizArea.TextValue = ""
            Me.txtBizArea.ToolTipText = ""
            '
            'txtMkTargetGroup
            '
            Me.txtMkTargetGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtMkTargetGroup.BackColor = System.Drawing.SystemColors.Window
            Me.txtMkTargetGroup.BorderColor = System.Drawing.Color.Empty
            Me.txtMkTargetGroup.BorderStyle = 2
            Me.txtMkTargetGroup.CaptionName = "구독대상처"
            Me.txtMkTargetGroup.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtMkTargetGroup.Location = New System.Drawing.Point(586, 193)
            Me.txtMkTargetGroup.MaxLength = 2000
            Me.txtMkTargetGroup.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtMkTargetGroup.Multiline = False
            Me.txtMkTargetGroup.Name = "txtMkTargetGroup"
            Me.txtMkTargetGroup.ReadOnlys = False
            Me.txtMkTargetGroup.SelectedText = ""
            Me.txtMkTargetGroup.SelectionLength = 0
            Me.txtMkTargetGroup.SelectionStart = 0
            Me.txtMkTargetGroup.Size = New System.Drawing.Size(193, 20)
            Me.txtMkTargetGroup.TabIndex = 1067
            Me.txtMkTargetGroup.Tag = ""
            Me.txtMkTargetGroup.TextAlign = 0
            Me.txtMkTargetGroup.TextValue = ""
            Me.txtMkTargetGroup.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(509, 168)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(71, 20)
            Me.Label6.TabIndex = 1066
            Me.Label6.Text = "관할 지역"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label7.Location = New System.Drawing.Point(509, 193)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(71, 20)
            Me.Label7.TabIndex = 1068
            Me.Label7.Text = "구독대상처"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lbl
            '
            Me.lbl.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbl.Location = New System.Drawing.Point(518, 224)
            Me.lbl.Name = "lbl"
            Me.lbl.Size = New System.Drawing.Size(62, 15)
            Me.lbl.TabIndex = 1070
            Me.lbl.Text = "개국일자"
            Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpOpenDate
            '
            Me.dtpOpenDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpOpenDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpOpenDate.BorderStyle = 2
            Me.dtpOpenDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpOpenDate.CaptionName = "개국일자"
            Me.dtpOpenDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpOpenDate.Location = New System.Drawing.Point(586, 221)
            Me.dtpOpenDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpOpenDate.MaxLength = 0
            Me.dtpOpenDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpOpenDate.Name = "dtpOpenDate"
            Me.dtpOpenDate.ReadOnlys = False
            Me.dtpOpenDate.SelectedText = ""
            Me.dtpOpenDate.SelectionLength = 0
            Me.dtpOpenDate.SelectionStart = 0
            Me.dtpOpenDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpOpenDate.TabIndex = 1069
            Me.dtpOpenDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpOpenDate.TextAlign = 0
            Me.dtpOpenDate.TextValue = ""
            Me.dtpOpenDate.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(518, 245)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(62, 15)
            Me.Label8.TabIndex = 1072
            Me.Label8.Text = "폐국일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCloseDate
            '
            Me.dtpCloseDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCloseDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpCloseDate.BorderStyle = 2
            Me.dtpCloseDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCloseDate.CaptionName = "폐국일자"
            Me.dtpCloseDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpCloseDate.Location = New System.Drawing.Point(586, 242)
            Me.dtpCloseDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCloseDate.MaxLength = 0
            Me.dtpCloseDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCloseDate.Name = "dtpCloseDate"
            Me.dtpCloseDate.ReadOnlys = False
            Me.dtpCloseDate.SelectedText = ""
            Me.dtpCloseDate.SelectionLength = 0
            Me.dtpCloseDate.SelectionStart = 0
            Me.dtpCloseDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpCloseDate.TabIndex = 1071
            Me.dtpCloseDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpCloseDate.TextAlign = 0
            Me.dtpCloseDate.TextValue = ""
            Me.dtpCloseDate.ToolTipText = ""
            '
            'txtCloseRemark
            '
            Me.txtCloseRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCloseRemark.BackColor = System.Drawing.SystemColors.Window
            Me.txtCloseRemark.BorderColor = System.Drawing.Color.Empty
            Me.txtCloseRemark.BorderStyle = 2
            Me.txtCloseRemark.CaptionName = "폐국사유"
            Me.txtCloseRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtCloseRemark.Location = New System.Drawing.Point(586, 263)
            Me.txtCloseRemark.MaxLength = 2000
            Me.txtCloseRemark.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCloseRemark.Multiline = False
            Me.txtCloseRemark.Name = "txtCloseRemark"
            Me.txtCloseRemark.ReadOnlys = False
            Me.txtCloseRemark.SelectedText = ""
            Me.txtCloseRemark.SelectionLength = 0
            Me.txtCloseRemark.SelectionStart = 0
            Me.txtCloseRemark.Size = New System.Drawing.Size(193, 20)
            Me.txtCloseRemark.TabIndex = 1073
            Me.txtCloseRemark.Tag = ""
            Me.txtCloseRemark.TextAlign = 0
            Me.txtCloseRemark.TextValue = ""
            Me.txtCloseRemark.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label9.Location = New System.Drawing.Point(509, 263)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(71, 20)
            Me.Label9.TabIndex = 1074
            Me.Label9.Text = "폐국사유"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'grd_7
            '
            Me.grd_7.AllowBigSelection = False
            Me.grd_7.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_7.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_7.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_7.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_7.Cols = 2
            Me.grd_7.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_7.ExplorerBar = 0
            Me.grd_7.ExtendLastCol = True
            Me.grd_7.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_7.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_7.FrozenCols = 1
            Me.grd_7.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_7.Location = New System.Drawing.Point(5, 346)
            Me.grd_7.Name = "grd_7"
            Me.grd_7.NodeClosedPicture = Nothing
            Me.grd_7.NodeOpenPicture = Nothing
            Me.grd_7.OutlineCol = -1
            Me.grd_7.RowHeightMax = 18
            Me.grd_7.RowHeightMin = 18
            Me.grd_7.Rows = 2
            Me.grd_7.Size = New System.Drawing.Size(799, 297)
            Me.grd_7.StyleInfo = resources.GetString("grd_7.StyleInfo")
            Me.grd_7.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_7.TabIndex = 1075
            Me.grd_7.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_7.Visible = False
            '
            'chkCloseCheck
            '
            Me.chkCloseCheck.AutoSize = True
            Me.chkCloseCheck.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkCloseCheck.CaptionName = Nothing
            Me.chkCloseCheck.Location = New System.Drawing.Point(652, 22)
            Me.chkCloseCheck.Name = "chkCloseCheck"
            Me.chkCloseCheck.ReadOnlys = False
            Me.chkCloseCheck.Size = New System.Drawing.Size(60, 16)
            Me.chkCloseCheck.TabIndex = 1076
            Me.chkCloseCheck.Tag = Nothing
            Me.chkCloseCheck.Text = "폐지국"
            Me.chkCloseCheck.TextValue = "0"
            Me.chkCloseCheck.UseVisualStyleBackColor = False
            '
            'chkOpenCheck
            '
            Me.chkOpenCheck.AutoSize = True
            Me.chkOpenCheck.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkOpenCheck.CaptionName = Nothing
            Me.chkOpenCheck.Location = New System.Drawing.Point(723, 22)
            Me.chkOpenCheck.Name = "chkOpenCheck"
            Me.chkOpenCheck.ReadOnlys = False
            Me.chkOpenCheck.Size = New System.Drawing.Size(72, 16)
            Me.chkOpenCheck.TabIndex = 1077
            Me.chkOpenCheck.Tag = Nothing
            Me.chkOpenCheck.Text = "전체지국"
            Me.chkOpenCheck.TextValue = "0"
            Me.chkOpenCheck.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(640, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(157, 35)
            Me.PictureBox1.TabIndex = 1078
            Me.PictureBox1.TabStop = False
            '
            'PNB101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkCloseCheck)
            Me.Controls.Add(Me.chkOpenCheck)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.grd_7)
            Me.Controls.Add(Me.txtCloseRemark)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.dtpCloseDate)
            Me.Controls.Add(Me.lbl)
            Me.Controls.Add(Me.dtpOpenDate)
            Me.Controls.Add(Me.txtMkTargetGroup)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtBizArea)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnPlus)
            Me.Controls.Add(Me.lbl_grd_Title)
            Me.Controls.Add(Me.txtNewGubn)
            Me.Controls.Add(Me.txtBranchCd)
            Me.Controls.Add(Me.Label26)
            Me.Controls.Add(Me.cboChargeTypeCd2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popChargeEmpNum_2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboChargeTypeCd)
            Me.Controls.Add(Me.lblEmployeeNumber)
            Me.Controls.Add(Me.txtBranchNm)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtBranchNm_2)
            Me.Controls.Add(Me.grd_4)
            Me.Controls.Add(Me.grd_5)
            Me.Controls.Add(Me.grd_6)
            Me.Controls.Add(Me.btngrd_4)
            Me.Controls.Add(Me.btngrd_5)
            Me.Controls.Add(Me.btngrd_6)
            Me.Controls.Add(Me.btngrd_7)
            Me.Controls.Add(Me.btngrd_3)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.picIo_2)
            Me.Name = "PNB101"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picIo_2, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.btngrd_3, 0)
            Me.Controls.SetChildIndex(Me.btngrd_7, 0)
            Me.Controls.SetChildIndex(Me.btngrd_6, 0)
            Me.Controls.SetChildIndex(Me.btngrd_5, 0)
            Me.Controls.SetChildIndex(Me.btngrd_4, 0)
            Me.Controls.SetChildIndex(Me.grd_6, 0)
            Me.Controls.SetChildIndex(Me.grd_5, 0)
            Me.Controls.SetChildIndex(Me.grd_4, 0)
            Me.Controls.SetChildIndex(Me.txtBranchNm_2, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            Me.Controls.SetChildIndex(Me.txtBranchNm, 0)
            Me.Controls.SetChildIndex(Me.lblEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.cboChargeTypeCd, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum_2, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.cboChargeTypeCd2, 0)
            Me.Controls.SetChildIndex(Me.Label26, 0)
            Me.Controls.SetChildIndex(Me.txtBranchCd, 0)
            Me.Controls.SetChildIndex(Me.txtNewGubn, 0)
            Me.Controls.SetChildIndex(Me.lbl_grd_Title, 0)
            Me.Controls.SetChildIndex(Me.btnPlus, 0)
            Me.Controls.SetChildIndex(Me.btnSave, 0)
            Me.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.Controls.SetChildIndex(Me.txtBizArea, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.txtMkTargetGroup, 0)
            Me.Controls.SetChildIndex(Me.dtpOpenDate, 0)
            Me.Controls.SetChildIndex(Me.lbl, 0)
            Me.Controls.SetChildIndex(Me.dtpCloseDate, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.txtCloseRemark, 0)
            Me.Controls.SetChildIndex(Me.grd_7, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.chkOpenCheck, 0)
            Me.Controls.SetChildIndex(Me.chkCloseCheck, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents grd_4 As ubiLease.GridControl.grd
        Friend WithEvents grd_5 As ubiLease.GridControl.grd
        Friend WithEvents grd_6 As ubiLease.GridControl.grd
        Friend WithEvents btngrd_3 As System.Windows.Forms.Button
        Friend WithEvents btngrd_7 As System.Windows.Forms.Button
        Friend WithEvents btngrd_6 As System.Windows.Forms.Button
        Friend WithEvents btngrd_5 As System.Windows.Forms.Button
        Friend WithEvents btngrd_4 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblEmployeeNumber As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm As ubiLease.CommonControls.txt
        Friend WithEvents popChargeEmpNum_2 As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents cboChargeTypeCd2 As ubiLease.CommonControls.cbo
        Friend WithEvents txtBranchCd As ubiLease.CommonControls.txt
        Friend WithEvents txtNewGubn As ubiLease.CommonControls.txt
        Friend WithEvents btnPlus As System.Windows.Forms.Button
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboChargeTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm_2 As ubiLease.CommonControls.txt
        Friend WithEvents btnDelete As System.Windows.Forms.Button
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents lbl_grd_Title As System.Windows.Forms.Label
        Friend WithEvents txtBizArea As ubiLease.CommonControls.txt
        Friend WithEvents txtMkTargetGroup As ubiLease.CommonControls.txt
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents lbl As System.Windows.Forms.Label
        Friend WithEvents dtpOpenDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dtpCloseDate As ubiLease.CommonControls.dtp
        Friend WithEvents txtCloseRemark As ubiLease.CommonControls.txt
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents grd_7 As ubiLease.GridControl.grd
        Friend WithEvents chkCloseCheck As ubiLease.CommonControls.chk
        Friend WithEvents chkOpenCheck As ubiLease.CommonControls.chk
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

    End Class

End Namespace
