Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI403
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI403))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.dtpFromYearMonths = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpToYearMonths = New ubiLease.CommonControls.dtp
            Me.popBranchNum = New ubiLease.CommonControls.pop
            Me.lblDeliveryBranchCd = New System.Windows.Forms.Label
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            Me.popBranchChiefCd = New ubiLease.CommonControls.pop
            Me.Label9 = New System.Windows.Forms.Label
            Me.lblJoinCompanyDate = New System.Windows.Forms.Label
            Me.dtpContractDt = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            Me.popBranchCd = New ubiLease.CommonControls.pop
            Me.txtChangeNum = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.numDepositAmt = New ubiLease.CommonControls.num
            Me.Label21 = New System.Windows.Forms.Label
            Me.Label19 = New System.Windows.Forms.Label
            Me.cboBranchRegionCd = New ubiLease.CommonControls.cbo
            Me.numDepositAmt2 = New ubiLease.CommonControls.num
            Me.Label2 = New System.Windows.Forms.Label
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            Me.Label5 = New System.Windows.Forms.Label
            Me.lblJiral = New System.Windows.Forms.Label
            Me.popChargeEmpNum_r = New ubiLease.CommonControls.pop
            Me.Label6 = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 50)
            Me.picCriteria_1.TabIndex = 2
            Me.picCriteria_1.TabStop = False
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
            Me.grd_2.Location = New System.Drawing.Point(5, 151)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(802, 493)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 2
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpFromYearMonths
            '
            Me.dtpFromYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromYearMonths.BorderStyle = 2
            Me.dtpFromYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromYearMonths.CaptionName = "기준 일자"
            Me.dtpFromYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpFromYearMonths.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpFromYearMonths.Location = New System.Drawing.Point(597, 68)
            Me.dtpFromYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromYearMonths.MaxLength = 0
            Me.dtpFromYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromYearMonths.Name = "dtpFromYearMonths"
            Me.dtpFromYearMonths.ReadOnlys = False
            Me.dtpFromYearMonths.SelectedText = ""
            Me.dtpFromYearMonths.SelectionLength = 0
            Me.dtpFromYearMonths.SelectionStart = 0
            Me.dtpFromYearMonths.Size = New System.Drawing.Size(87, 20)
            Me.dtpFromYearMonths.TabIndex = 0
            Me.dtpFromYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpFromYearMonths.TextAlign = 0
            Me.dtpFromYearMonths.TextValue = ""
            Me.dtpFromYearMonths.ToolTipText = ""
            Me.dtpFromYearMonths.Visible = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(16, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(87, 15)
            Me.Label1.TabIndex = 25
            Me.Label1.Text = "기준 년월"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpToYearMonths
            '
            Me.dtpToYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpToYearMonths.BorderStyle = 2
            Me.dtpToYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToYearMonths.CaptionName = "기준 일자"
            Me.dtpToYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpToYearMonths.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpToYearMonths.Location = New System.Drawing.Point(109, 20)
            Me.dtpToYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToYearMonths.MaxLength = 0
            Me.dtpToYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToYearMonths.Name = "dtpToYearMonths"
            Me.dtpToYearMonths.ReadOnlys = False
            Me.dtpToYearMonths.SelectedText = ""
            Me.dtpToYearMonths.SelectionLength = 0
            Me.dtpToYearMonths.SelectionStart = 0
            Me.dtpToYearMonths.Size = New System.Drawing.Size(87, 20)
            Me.dtpToYearMonths.TabIndex = 1
            Me.dtpToYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpToYearMonths.TextAlign = 0
            Me.dtpToYearMonths.TextValue = ""
            Me.dtpToYearMonths.ToolTipText = ""
            '
            'popBranchNum
            '
            Me.popBranchNum.BorderColor = System.Drawing.Color.Empty
            Me.popBranchNum.BorderStyle = 2
            Me.popBranchNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchNum.CaptionName = "지국 번호"
            Me.popBranchNum.CodeText = ""
            Me.popBranchNum.CodeWidth = 70
            Me.popBranchNum.Location = New System.Drawing.Point(303, 22)
            Me.popBranchNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchNum.MaxLength = 9
            Me.popBranchNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchNum.Name = "popBranchNum"
            Me.popBranchNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchNum.NameText = ""
            Me.popBranchNum.ReadOnlys = False
            Me.popBranchNum.SelectedText = ""
            Me.popBranchNum.SelectionLength = 0
            Me.popBranchNum.SelectionStart = 0
            Me.popBranchNum.Size = New System.Drawing.Size(180, 20)
            Me.popBranchNum.TabIndex = 2
            Me.popBranchNum.Tag = "need();code(지국번호);"
            Me.popBranchNum.TextAlign = 0
            Me.popBranchNum.TextValue = ""
            Me.popBranchNum.ToolTipText = ""
            '
            'lblDeliveryBranchCd
            '
            Me.lblDeliveryBranchCd.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDeliveryBranchCd.Location = New System.Drawing.Point(228, 23)
            Me.lblDeliveryBranchCd.Name = "lblDeliveryBranchCd"
            Me.lblDeliveryBranchCd.Size = New System.Drawing.Size(70, 18)
            Me.lblDeliveryBranchCd.TabIndex = 1613
            Me.lblDeliveryBranchCd.Text = "지국 번호"
            Me.lblDeliveryBranchCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_1
            '
            Me.picIo_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(5, 61)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(802, 84)
            Me.picIo_1.TabIndex = 1704
            Me.picIo_1.TabStop = False
            '
            'popBranchChiefCd
            '
            Me.popBranchChiefCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchChiefCd.BorderStyle = 2
            Me.popBranchChiefCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchChiefCd.CaptionName = "지국장코드"
            Me.popBranchChiefCd.CodeText = ""
            Me.popBranchChiefCd.CodeWidth = 70
            Me.popBranchChiefCd.Location = New System.Drawing.Point(108, 94)
            Me.popBranchChiefCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBranchChiefCd.MaxLength = 10
            Me.popBranchChiefCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchChiefCd.Name = "popBranchChiefCd"
            Me.popBranchChiefCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchChiefCd.NameText = ""
            Me.popBranchChiefCd.ReadOnlys = False
            Me.popBranchChiefCd.SelectedText = ""
            Me.popBranchChiefCd.SelectionLength = 0
            Me.popBranchChiefCd.SelectionStart = 0
            Me.popBranchChiefCd.Size = New System.Drawing.Size(208, 20)
            Me.popBranchChiefCd.TabIndex = 1708
            Me.popBranchChiefCd.Tag = "read;code(지국장 명);"
            Me.popBranchChiefCd.TextAlign = 0
            Me.popBranchChiefCd.TextValue = ""
            Me.popBranchChiefCd.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.GhostWhite
            Me.Label9.Location = New System.Drawing.Point(36, 94)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(66, 20)
            Me.Label9.TabIndex = 1712
            Me.Label9.Text = "계약자"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblJoinCompanyDate
            '
            Me.lblJoinCompanyDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lblJoinCompanyDate.Location = New System.Drawing.Point(333, 94)
            Me.lblJoinCompanyDate.Name = "lblJoinCompanyDate"
            Me.lblJoinCompanyDate.Size = New System.Drawing.Size(66, 20)
            Me.lblJoinCompanyDate.TabIndex = 1711
            Me.lblJoinCompanyDate.Text = "계약일자"
            Me.lblJoinCompanyDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpContractDt
            '
            Me.dtpContractDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpContractDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpContractDt.BorderStyle = 2
            Me.dtpContractDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpContractDt.CaptionName = "계약일자"
            Me.dtpContractDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpContractDt.Location = New System.Drawing.Point(404, 94)
            Me.dtpContractDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpContractDt.MaxLength = 0
            Me.dtpContractDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpContractDt.Name = "dtpContractDt"
            Me.dtpContractDt.ReadOnlys = True
            Me.dtpContractDt.SelectedText = ""
            Me.dtpContractDt.SelectionLength = 0
            Me.dtpContractDt.SelectionStart = 0
            Me.dtpContractDt.Size = New System.Drawing.Size(106, 20)
            Me.dtpContractDt.TabIndex = 1707
            Me.dtpContractDt.Tag = "read;format(####-##-##);"
            Me.dtpContractDt.TextAlign = 0
            Me.dtpContractDt.TextValue = ""
            Me.dtpContractDt.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.Location = New System.Drawing.Point(333, 72)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 20)
            Me.Label4.TabIndex = 1710
            Me.Label4.Text = "교체횟수"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBranchCd
            '
            Me.popBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd.BorderStyle = 2
            Me.popBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd.CaptionName = "지국코드"
            Me.popBranchCd.CodeText = ""
            Me.popBranchCd.CodeWidth = 50
            Me.popBranchCd.Location = New System.Drawing.Point(108, 72)
            Me.popBranchCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBranchCd.MaxLength = 7
            Me.popBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd.Name = "popBranchCd"
            Me.popBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd.NameText = ""
            Me.popBranchCd.ReadOnlys = False
            Me.popBranchCd.SelectedText = ""
            Me.popBranchCd.SelectionLength = 0
            Me.popBranchCd.SelectionStart = 0
            Me.popBranchCd.Size = New System.Drawing.Size(208, 20)
            Me.popBranchCd.TabIndex = 1705
            Me.popBranchCd.Tag = "read;code(지국코드);"
            Me.popBranchCd.TextAlign = 0
            Me.popBranchCd.TextValue = ""
            Me.popBranchCd.ToolTipText = ""
            '
            'txtChangeNum
            '
            Me.txtChangeNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtChangeNum.BorderColor = System.Drawing.Color.Empty
            Me.txtChangeNum.BorderStyle = 2
            Me.txtChangeNum.CaptionName = "교체 횟수"
            Me.txtChangeNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtChangeNum.Location = New System.Drawing.Point(404, 72)
            Me.txtChangeNum.MaxLength = 30
            Me.txtChangeNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtChangeNum.Multiline = False
            Me.txtChangeNum.Name = "txtChangeNum"
            Me.txtChangeNum.ReadOnlys = False
            Me.txtChangeNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtChangeNum.SelectedText = ""
            Me.txtChangeNum.SelectionLength = 0
            Me.txtChangeNum.SelectionStart = 0
            Me.txtChangeNum.Size = New System.Drawing.Size(45, 20)
            Me.txtChangeNum.TabIndex = 1706
            Me.txtChangeNum.Tag = "read;"
            Me.txtChangeNum.TextAlign = 0
            Me.txtChangeNum.TextValue = "0"
            Me.txtChangeNum.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(36, 72)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(66, 20)
            Me.Label3.TabIndex = 1709
            Me.Label3.Text = "지국코드"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numDepositAmt
            '
            Me.numDepositAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numDepositAmt.BorderColor = System.Drawing.Color.Empty
            Me.numDepositAmt.BorderStyle = 2
            Me.numDepositAmt.CaptionName = "지국보증금"
            Me.numDepositAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numDepositAmt.LengthPrecision = 15
            Me.numDepositAmt.LengthScale = 0
            Me.numDepositAmt.Location = New System.Drawing.Point(404, 116)
            Me.numDepositAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numDepositAmt.MaxLength = 32767
            Me.numDepositAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numDepositAmt.Name = "numDepositAmt"
            Me.numDepositAmt.ReadOnlys = False
            Me.numDepositAmt.SelectedText = ""
            Me.numDepositAmt.SelectionLength = 0
            Me.numDepositAmt.SelectionStart = 1
            Me.numDepositAmt.Size = New System.Drawing.Size(106, 20)
            Me.numDepositAmt.TabIndex = 1714
            Me.numDepositAmt.Tag = "read;"
            Me.numDepositAmt.TextValue = "0"
            Me.numDepositAmt.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label21.Location = New System.Drawing.Point(333, 116)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(66, 20)
            Me.Label21.TabIndex = 1716
            Me.Label21.Text = "지국보증금"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.GhostWhite
            Me.Label19.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label19.Location = New System.Drawing.Point(36, 116)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(66, 20)
            Me.Label19.TabIndex = 1715
            Me.Label19.Text = "지국지역"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBranchRegionCd
            '
            Me.cboBranchRegionCd.CaptionName = "지국 지역"
            Me.cboBranchRegionCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBranchRegionCd.ListCount = 0
            Me.cboBranchRegionCd.Location = New System.Drawing.Point(108, 116)
            Me.cboBranchRegionCd.Name = "cboBranchRegionCd"
            Me.cboBranchRegionCd.ReadOnlys = False
            Me.cboBranchRegionCd.Size = New System.Drawing.Size(106, 20)
            Me.cboBranchRegionCd.TabIndex = 1713
            Me.cboBranchRegionCd.Tag = "read;code(지국지역코드|전체);"
            Me.cboBranchRegionCd.TextValue = ""
            '
            'numDepositAmt2
            '
            Me.numDepositAmt2.BackColor = System.Drawing.SystemColors.Window
            Me.numDepositAmt2.BorderColor = System.Drawing.Color.Empty
            Me.numDepositAmt2.BorderStyle = 2
            Me.numDepositAmt2.CaptionName = "지국보증금"
            Me.numDepositAmt2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numDepositAmt2.LengthPrecision = 15
            Me.numDepositAmt2.LengthScale = 0
            Me.numDepositAmt2.Location = New System.Drawing.Point(597, 116)
            Me.numDepositAmt2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numDepositAmt2.MaxLength = 32767
            Me.numDepositAmt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numDepositAmt2.Name = "numDepositAmt2"
            Me.numDepositAmt2.ReadOnlys = False
            Me.numDepositAmt2.SelectedText = ""
            Me.numDepositAmt2.SelectionLength = 0
            Me.numDepositAmt2.SelectionStart = 1
            Me.numDepositAmt2.Size = New System.Drawing.Size(106, 20)
            Me.numDepositAmt2.TabIndex = 1717
            Me.numDepositAmt2.Tag = "read;"
            Me.numDepositAmt2.TextValue = "0"
            Me.numDepositAmt2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(519, 116)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 20)
            Me.Label2.TabIndex = 1718
            Me.Label2.Text = "완납적립금"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "영업담당"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 50
            Me.popChargeEmpNum.Location = New System.Drawing.Point(597, 94)
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
            Me.popChargeEmpNum.Size = New System.Drawing.Size(191, 20)
            Me.popChargeEmpNum.TabIndex = 1719
            Me.popChargeEmpNum.Tag = "read;code(사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(519, 94)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 20)
            Me.Label5.TabIndex = 1720
            Me.Label5.Text = "담당"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblJiral
            '
            Me.lblJiral.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblJiral.Location = New System.Drawing.Point(684, 71)
            Me.lblJiral.Name = "lblJiral"
            Me.lblJiral.Size = New System.Drawing.Size(16, 15)
            Me.lblJiral.TabIndex = 28
            Me.lblJiral.Text = "~"
            Me.lblJiral.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblJiral.Visible = False
            '
            'popChargeEmpNum_r
            '
            Me.popChargeEmpNum_r.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_r.BorderStyle = 2
            Me.popChargeEmpNum_r.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_r.CaptionName = "지국 번호"
            Me.popChargeEmpNum_r.CodeText = ""
            Me.popChargeEmpNum_r.CodeWidth = 70
            Me.popChargeEmpNum_r.Location = New System.Drawing.Point(587, 21)
            Me.popChargeEmpNum_r.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum_r.MaxLength = 6
            Me.popChargeEmpNum_r.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum_r.Name = "popChargeEmpNum_r"
            Me.popChargeEmpNum_r.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_r.NameText = ""
            Me.popChargeEmpNum_r.ReadOnlys = False
            Me.popChargeEmpNum_r.SelectedText = ""
            Me.popChargeEmpNum_r.SelectionLength = 0
            Me.popChargeEmpNum_r.SelectionStart = 0
            Me.popChargeEmpNum_r.Size = New System.Drawing.Size(180, 20)
            Me.popChargeEmpNum_r.TabIndex = 1721
            Me.popChargeEmpNum_r.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_r.TextAlign = 0
            Me.popChargeEmpNum_r.TextValue = ""
            Me.popChargeEmpNum_r.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(512, 22)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(70, 18)
            Me.Label6.TabIndex = 1722
            Me.Label6.Text = "담당자"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI403
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popChargeEmpNum_r)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.numDepositAmt2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.numDepositAmt)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.cboBranchRegionCd)
            Me.Controls.Add(Me.popBranchChiefCd)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.lblJoinCompanyDate)
            Me.Controls.Add(Me.dtpContractDt)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.popBranchCd)
            Me.Controls.Add(Me.txtChangeNum)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popBranchNum)
            Me.Controls.Add(Me.lblDeliveryBranchCd)
            Me.Controls.Add(Me.dtpToYearMonths)
            Me.Controls.Add(Me.dtpFromYearMonths)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.lblJiral)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picIo_1)
            Me.Name = "PNI403"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picIo_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblJiral, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpFromYearMonths, 0)
            Me.Controls.SetChildIndex(Me.dtpToYearMonths, 0)
            Me.Controls.SetChildIndex(Me.lblDeliveryBranchCd, 0)
            Me.Controls.SetChildIndex(Me.popBranchNum, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.txtChangeNum, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.dtpContractDt, 0)
            Me.Controls.SetChildIndex(Me.lblJoinCompanyDate, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.popBranchChiefCd, 0)
            Me.Controls.SetChildIndex(Me.cboBranchRegionCd, 0)
            Me.Controls.SetChildIndex(Me.Label19, 0)
            Me.Controls.SetChildIndex(Me.Label21, 0)
            Me.Controls.SetChildIndex(Me.numDepositAmt, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.numDepositAmt2, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum_r, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents dtpFromYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpToYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents popBranchNum As ubiLease.CommonControls.pop
        Friend WithEvents lblDeliveryBranchCd As System.Windows.Forms.Label
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox
        Friend WithEvents popBranchChiefCd As ubiLease.CommonControls.pop
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblJoinCompanyDate As System.Windows.Forms.Label
        Friend WithEvents dtpContractDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents txtChangeNum As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents numDepositAmt As ubiLease.CommonControls.num
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cboBranchRegionCd As ubiLease.CommonControls.cbo
        Friend WithEvents numDepositAmt2 As ubiLease.CommonControls.num
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblJiral As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum_r As ubiLease.CommonControls.pop
        Friend WithEvents Label6 As System.Windows.Forms.Label

    End Class

End Namespace
