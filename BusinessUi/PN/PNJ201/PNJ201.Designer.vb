Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ201))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popCouponCorpCd = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.picIo_1_1 = New System.Windows.Forms.PictureBox
            Me.popBranchCd = New ubiLease.CommonControls.pop
            Me.lblDeliveryBranchCd = New System.Windows.Forms.Label
            Me.dtpPayYYYYMM = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpRedeemDt = New ubiLease.CommonControls.dtp
            Me.Label5 = New System.Windows.Forms.Label
            Me.btnInsert = New ubiLease.CommonControls.btn
            Me.txtDetailOrders = New ubiLease.CommonControls.txt
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpPublishYearMonthTo = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpPublishYearMonthFrom = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnContine = New ubiLease.CommonControls.btn
            Me.txtBarCode = New ubiLease.CommonControls.txt
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.numRedeemUnitCost = New ubiLease.CommonControls.num
            Me.txtABarCode = New ubiLease.CommonControls.txt
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.btnApprovalAll = New ubiLease.CommonControls.btn
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.numApplyUnitCost = New ubiLease.CommonControls.num
            Me.Label11 = New System.Windows.Forms.Label
            Me.lblMsg12 = New System.Windows.Forms.Label
            Me.lblMsg13 = New System.Windows.Forms.Label
            Me.lblMsg11 = New System.Windows.Forms.Label
            Me.chkRedeemDt = New ubiLease.CommonControls.chk
            Me.dtpRedeemDt_FR = New ubiLease.CommonControls.dtp
            Me.Label12 = New System.Windows.Forms.Label
            Me.dtpRedeemDt_To = New ubiLease.CommonControls.dtp
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_1_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(3, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(805, 71)
            Me.picCriteria_1.TabIndex = 18
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
            Me.grd_1.Location = New System.Drawing.Point(3, 193)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 400)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 19
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popCouponCorpCd
            '
            Me.popCouponCorpCd.BorderColor = System.Drawing.Color.Empty
            Me.popCouponCorpCd.BorderStyle = 2
            Me.popCouponCorpCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCouponCorpCd.CaptionName = "소속사코드"
            Me.popCouponCorpCd.CodeText = ""
            Me.popCouponCorpCd.CodeWidth = 60
            Me.popCouponCorpCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCouponCorpCd.Location = New System.Drawing.Point(434, 18)
            Me.popCouponCorpCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCouponCorpCd.MaxLength = 4
            Me.popCouponCorpCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCouponCorpCd.Name = "popCouponCorpCd"
            Me.popCouponCorpCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCouponCorpCd.NameText = ""
            Me.popCouponCorpCd.ReadOnlys = False
            Me.popCouponCorpCd.SelectedText = ""
            Me.popCouponCorpCd.SelectionLength = 0
            Me.popCouponCorpCd.SelectionStart = 0
            Me.popCouponCorpCd.Size = New System.Drawing.Size(233, 20)
            Me.popCouponCorpCd.TabIndex = 4
            Me.popCouponCorpCd.Tag = "code(소속사 명);"
            Me.popCouponCorpCd.TextAlign = 0
            Me.popCouponCorpCd.TextValue = ""
            Me.popCouponCorpCd.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(371, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 18)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "소속사"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_1_1
            '
            Me.picIo_1_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1_1.Location = New System.Drawing.Point(3, 80)
            Me.picIo_1_1.Name = "picIo_1_1"
            Me.picIo_1_1.Size = New System.Drawing.Size(805, 110)
            Me.picIo_1_1.TabIndex = 1595
            Me.picIo_1_1.TabStop = False
            '
            'popBranchCd
            '
            Me.popBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd.BorderStyle = 2
            Me.popBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd.CaptionName = "지국 코드"
            Me.popBranchCd.CodeText = ""
            Me.popBranchCd.CodeWidth = 55
            Me.popBranchCd.Location = New System.Drawing.Point(109, 110)
            Me.popBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd.MaxLength = 7
            Me.popBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd.Name = "popBranchCd"
            Me.popBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd.NameText = ""
            Me.popBranchCd.ReadOnlys = False
            Me.popBranchCd.SelectedText = ""
            Me.popBranchCd.SelectionLength = 0
            Me.popBranchCd.SelectionStart = 0
            Me.popBranchCd.Size = New System.Drawing.Size(232, 20)
            Me.popBranchCd.TabIndex = 14
            Me.popBranchCd.Tag = "code(지국코드);"
            Me.popBranchCd.TextAlign = 0
            Me.popBranchCd.TextValue = ""
            Me.popBranchCd.ToolTipText = ""
            '
            'lblDeliveryBranchCd
            '
            Me.lblDeliveryBranchCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblDeliveryBranchCd.Location = New System.Drawing.Point(39, 113)
            Me.lblDeliveryBranchCd.Name = "lblDeliveryBranchCd"
            Me.lblDeliveryBranchCd.Size = New System.Drawing.Size(64, 15)
            Me.lblDeliveryBranchCd.TabIndex = 1611
            Me.lblDeliveryBranchCd.Text = "회수 지국"
            Me.lblDeliveryBranchCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPayYYYYMM
            '
            Me.dtpPayYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPayYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpPayYYYYMM.BorderStyle = 2
            Me.dtpPayYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPayYYYYMM.CaptionName = "회수 년월"
            Me.dtpPayYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpPayYYYYMM.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPayYYYYMM.Location = New System.Drawing.Point(417, 87)
            Me.dtpPayYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPayYYYYMM.MaxLength = 0
            Me.dtpPayYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPayYYYYMM.Name = "dtpPayYYYYMM"
            Me.dtpPayYYYYMM.ReadOnlys = False
            Me.dtpPayYYYYMM.SelectedText = ""
            Me.dtpPayYYYYMM.SelectionLength = 0
            Me.dtpPayYYYYMM.SelectionStart = 0
            Me.dtpPayYYYYMM.Size = New System.Drawing.Size(83, 20)
            Me.dtpPayYYYYMM.TabIndex = 13
            Me.dtpPayYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpPayYYYYMM.TextAlign = 0
            Me.dtpPayYYYYMM.TextValue = ""
            Me.dtpPayYYYYMM.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Location = New System.Drawing.Point(347, 90)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 15)
            Me.Label1.TabIndex = 1612
            Me.Label1.Text = "회수 년월"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpRedeemDt
            '
            Me.dtpRedeemDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRedeemDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpRedeemDt.BorderStyle = 2
            Me.dtpRedeemDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRedeemDt.CaptionName = "회수 일자"
            Me.dtpRedeemDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRedeemDt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpRedeemDt.Location = New System.Drawing.Point(109, 87)
            Me.dtpRedeemDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRedeemDt.MaxLength = 0
            Me.dtpRedeemDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRedeemDt.Name = "dtpRedeemDt"
            Me.dtpRedeemDt.ReadOnlys = False
            Me.dtpRedeemDt.SelectedText = ""
            Me.dtpRedeemDt.SelectionLength = 0
            Me.dtpRedeemDt.SelectionStart = 0
            Me.dtpRedeemDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpRedeemDt.TabIndex = 12
            Me.dtpRedeemDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpRedeemDt.TextAlign = 0
            Me.dtpRedeemDt.TextValue = ""
            Me.dtpRedeemDt.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(39, 90)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(64, 15)
            Me.Label5.TabIndex = 1614
            Me.Label5.Text = "회수 일자"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'btnInsert
            '
            Me.btnInsert.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnInsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnInsert.Location = New System.Drawing.Point(540, 110)
            Me.btnInsert.Name = "btnInsert"
            Me.btnInsert.Size = New System.Drawing.Size(100, 20)
            Me.btnInsert.TabIndex = 16
            Me.btnInsert.Text = "선택 입력"
            Me.btnInsert.UseVisualStyleBackColor = True
            '
            'txtDetailOrders
            '
            Me.txtDetailOrders.BackColor = System.Drawing.SystemColors.Window
            Me.txtDetailOrders.BorderColor = System.Drawing.Color.Empty
            Me.txtDetailOrders.BorderStyle = 2
            Me.txtDetailOrders.CaptionName = "발행상세순번"
            Me.txtDetailOrders.Location = New System.Drawing.Point(696, 18)
            Me.txtDetailOrders.MaxLength = 6
            Me.txtDetailOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDetailOrders.Multiline = False
            Me.txtDetailOrders.Name = "txtDetailOrders"
            Me.txtDetailOrders.ReadOnlys = False
            Me.txtDetailOrders.SelectedText = ""
            Me.txtDetailOrders.SelectionLength = 0
            Me.txtDetailOrders.SelectionStart = 0
            Me.txtDetailOrders.Size = New System.Drawing.Size(63, 20)
            Me.txtDetailOrders.TabIndex = 3
            Me.txtDetailOrders.Tag = "format(000000)"
            Me.txtDetailOrders.TextAlign = 0
            Me.txtDetailOrders.TextValue = Nothing
            Me.txtDetailOrders.ToolTipText = ""
            Me.txtDetailOrders.Visible = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(673, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(17, 16)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "-"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Label6.Visible = False
            '
            'dtpPublishYearMonthTo
            '
            Me.dtpPublishYearMonthTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPublishYearMonthTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpPublishYearMonthTo.BorderStyle = 2
            Me.dtpPublishYearMonthTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPublishYearMonthTo.CaptionName = "발행년월To"
            Me.dtpPublishYearMonthTo.DateTimeFormatText = "yyyy-MM"
            Me.dtpPublishYearMonthTo.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPublishYearMonthTo.Location = New System.Drawing.Point(236, 46)
            Me.dtpPublishYearMonthTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPublishYearMonthTo.MaxLength = 0
            Me.dtpPublishYearMonthTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPublishYearMonthTo.Name = "dtpPublishYearMonthTo"
            Me.dtpPublishYearMonthTo.ReadOnlys = False
            Me.dtpPublishYearMonthTo.SelectedText = ""
            Me.dtpPublishYearMonthTo.SelectionLength = 0
            Me.dtpPublishYearMonthTo.SelectionStart = 0
            Me.dtpPublishYearMonthTo.Size = New System.Drawing.Size(86, 20)
            Me.dtpPublishYearMonthTo.TabIndex = 8
            Me.dtpPublishYearMonthTo.Tag = "need;format(&&&&-&&);"
            Me.dtpPublishYearMonthTo.TextAlign = 0
            Me.dtpPublishYearMonthTo.TextValue = ""
            Me.dtpPublishYearMonthTo.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(217, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(21, 16)
            Me.Label3.TabIndex = 1620
            Me.Label3.Text = "~"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpPublishYearMonthFrom
            '
            Me.dtpPublishYearMonthFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPublishYearMonthFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpPublishYearMonthFrom.BorderStyle = 2
            Me.dtpPublishYearMonthFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPublishYearMonthFrom.CaptionName = "발행년월From"
            Me.dtpPublishYearMonthFrom.DateTimeFormatText = "yyyy-MM"
            Me.dtpPublishYearMonthFrom.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPublishYearMonthFrom.Location = New System.Drawing.Point(111, 46)
            Me.dtpPublishYearMonthFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPublishYearMonthFrom.MaxLength = 0
            Me.dtpPublishYearMonthFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPublishYearMonthFrom.Name = "dtpPublishYearMonthFrom"
            Me.dtpPublishYearMonthFrom.ReadOnlys = False
            Me.dtpPublishYearMonthFrom.SelectedText = ""
            Me.dtpPublishYearMonthFrom.SelectionLength = 0
            Me.dtpPublishYearMonthFrom.SelectionStart = 0
            Me.dtpPublishYearMonthFrom.Size = New System.Drawing.Size(86, 20)
            Me.dtpPublishYearMonthFrom.TabIndex = 7
            Me.dtpPublishYearMonthFrom.Tag = "need;format(&&&&-&&);"
            Me.dtpPublishYearMonthFrom.TextAlign = 0
            Me.dtpPublishYearMonthFrom.TextValue = ""
            Me.dtpPublishYearMonthFrom.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(33, 49)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(72, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 6
            Me.lblCodeDivisionHangulName.Text = "발행 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(39, 165)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(64, 15)
            Me.Label4.TabIndex = 1622
            Me.Label4.Text = "발행번호"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnContine
            '
            Me.btnContine.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnContine.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnContine.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnContine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnContine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnContine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnContine.Location = New System.Drawing.Point(356, 162)
            Me.btnContine.Name = "btnContine"
            Me.btnContine.Size = New System.Drawing.Size(144, 20)
            Me.btnContine.TabIndex = 18
            Me.btnContine.Text = "계속 입력"
            Me.btnContine.UseVisualStyleBackColor = True
            '
            'txtBarCode
            '
            Me.txtBarCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtBarCode.BorderColor = System.Drawing.Color.Empty
            Me.txtBarCode.BorderStyle = 2
            Me.txtBarCode.CaptionName = Nothing
            Me.txtBarCode.Location = New System.Drawing.Point(109, 162)
            Me.txtBarCode.MaxLength = 32767
            Me.txtBarCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBarCode.Multiline = False
            Me.txtBarCode.Name = "txtBarCode"
            Me.txtBarCode.ReadOnlys = False
            Me.txtBarCode.SelectedText = ""
            Me.txtBarCode.SelectionLength = 0
            Me.txtBarCode.SelectionStart = 0
            Me.txtBarCode.Size = New System.Drawing.Size(232, 20)
            Me.txtBarCode.TabIndex = 17
            Me.txtBarCode.Tag = Nothing
            Me.txtBarCode.TextAlign = 0
            Me.txtBarCode.TextValue = ""
            Me.txtBarCode.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Lavender
            Me.Label7.Font = New System.Drawing.Font("굴림", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label7.Location = New System.Drawing.Point(39, 140)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(460, 18)
            Me.Label7.TabIndex = 1623
            Me.Label7.Text = "※ (구)발행번호 입력 안내 : 0 + 소속사코드(3) + 발행년월(6)+순번(2) + 일련번호(6) "
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.GhostWhite
            Me.Label8.Location = New System.Drawing.Point(347, 113)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(64, 15)
            Me.Label8.TabIndex = 1625
            Me.Label8.Text = "회수 단가"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numRedeemUnitCost
            '
            Me.numRedeemUnitCost.BackColor = System.Drawing.SystemColors.Window
            Me.numRedeemUnitCost.BorderColor = System.Drawing.Color.Empty
            Me.numRedeemUnitCost.BorderStyle = 2
            Me.numRedeemUnitCost.CaptionName = Nothing
            Me.numRedeemUnitCost.LengthPrecision = 15
            Me.numRedeemUnitCost.LengthScale = 0
            Me.numRedeemUnitCost.Location = New System.Drawing.Point(417, 110)
            Me.numRedeemUnitCost.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numRedeemUnitCost.MaxLength = 0
            Me.numRedeemUnitCost.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numRedeemUnitCost.Name = "numRedeemUnitCost"
            Me.numRedeemUnitCost.ReadOnlys = False
            Me.numRedeemUnitCost.SelectedText = ""
            Me.numRedeemUnitCost.SelectionLength = 0
            Me.numRedeemUnitCost.SelectionStart = 1
            Me.numRedeemUnitCost.Size = New System.Drawing.Size(83, 20)
            Me.numRedeemUnitCost.TabIndex = 15
            Me.numRedeemUnitCost.Tag = "format(#,##0)"
            Me.numRedeemUnitCost.TextValue = "0"
            Me.numRedeemUnitCost.ToolTipText = ""
            '
            'txtABarCode
            '
            Me.txtABarCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtABarCode.BorderColor = System.Drawing.Color.Empty
            Me.txtABarCode.BorderStyle = 2
            Me.txtABarCode.CaptionName = Nothing
            Me.txtABarCode.Location = New System.Drawing.Point(434, 53)
            Me.txtABarCode.MaxLength = 32767
            Me.txtABarCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtABarCode.Multiline = False
            Me.txtABarCode.Name = "txtABarCode"
            Me.txtABarCode.ReadOnlys = False
            Me.txtABarCode.SelectedText = ""
            Me.txtABarCode.SelectionLength = 0
            Me.txtABarCode.SelectionStart = 0
            Me.txtABarCode.Size = New System.Drawing.Size(194, 20)
            Me.txtABarCode.TabIndex = 10
            Me.txtABarCode.Tag = Nothing
            Me.txtABarCode.TextAlign = 0
            Me.txtABarCode.TextValue = ""
            Me.txtABarCode.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(371, 56)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(57, 15)
            Me.Label9.TabIndex = 9
            Me.Label9.Text = "발행번호"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label10.Location = New System.Drawing.Point(425, 41)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(376, 11)
            Me.Label10.TabIndex = 11
            Me.Label10.Text = "※ (구)발행번호 조회 안내 : 0 + 소속사코드(3) + 발행년월(6)+ 일련번호(6) "
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnApprovalAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnApprovalAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnApprovalAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnApprovalAll.Location = New System.Drawing.Point(198, 609)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(91, 25)
            Me.btnApprovalAll.TabIndex = 21
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(3, 597)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(805, 48)
            Me.PictureBox2.TabIndex = 1763
            Me.PictureBox2.TabStop = False
            '
            'numApplyUnitCost
            '
            Me.numApplyUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numApplyUnitCost.BackColor = System.Drawing.SystemColors.Window
            Me.numApplyUnitCost.BorderColor = System.Drawing.Color.Empty
            Me.numApplyUnitCost.BorderStyle = 2
            Me.numApplyUnitCost.CaptionName = Nothing
            Me.numApplyUnitCost.LengthPrecision = 15
            Me.numApplyUnitCost.LengthScale = 0
            Me.numApplyUnitCost.Location = New System.Drawing.Point(109, 612)
            Me.numApplyUnitCost.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numApplyUnitCost.MaxLength = 0
            Me.numApplyUnitCost.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numApplyUnitCost.Name = "numApplyUnitCost"
            Me.numApplyUnitCost.ReadOnlys = False
            Me.numApplyUnitCost.SelectedText = ""
            Me.numApplyUnitCost.SelectionLength = 0
            Me.numApplyUnitCost.SelectionStart = 1
            Me.numApplyUnitCost.Size = New System.Drawing.Size(83, 20)
            Me.numApplyUnitCost.TabIndex = 20
            Me.numApplyUnitCost.Tag = "format(#,##0)"
            Me.numApplyUnitCost.TextValue = "0"
            Me.numApplyUnitCost.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(15, 615)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(90, 15)
            Me.Label11.TabIndex = 1766
            Me.Label11.Text = "조정 회수 단가"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMsg12
            '
            Me.lblMsg12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblMsg12.AutoSize = True
            Me.lblMsg12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblMsg12.Location = New System.Drawing.Point(298, 616)
            Me.lblMsg12.Name = "lblMsg12"
            Me.lblMsg12.Size = New System.Drawing.Size(465, 12)
            Me.lblMsg12.TabIndex = 22
            Me.lblMsg12.Text = "회수 여부, 회수 일자를 확인 후 유효 값이 있는 경우만 조정 회수 단가를 반영 합니다."
            Me.lblMsg12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMsg13
            '
            Me.lblMsg13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblMsg13.AutoSize = True
            Me.lblMsg13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblMsg13.Location = New System.Drawing.Point(298, 630)
            Me.lblMsg13.Name = "lblMsg13"
            Me.lblMsg13.Size = New System.Drawing.Size(225, 12)
            Me.lblMsg13.TabIndex = 24
            Me.lblMsg13.Text = "툴바의 저장 을 하셔야 최종 저장 됩니다."
            Me.lblMsg13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMsg11
            '
            Me.lblMsg11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblMsg11.AutoSize = True
            Me.lblMsg11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblMsg11.Location = New System.Drawing.Point(298, 602)
            Me.lblMsg11.Name = "lblMsg11"
            Me.lblMsg11.Size = New System.Drawing.Size(357, 12)
            Me.lblMsg11.TabIndex = 23
            Me.lblMsg11.Text = "조정을 원하는 행의 선택 부분을 체크 하시고 일괄 적용을 하세요."
            Me.lblMsg11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkRedeemDt
            '
            Me.chkRedeemDt.AutoSize = True
            Me.chkRedeemDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkRedeemDt.CaptionName = "회수일자"
            Me.chkRedeemDt.Checked = True
            Me.chkRedeemDt.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkRedeemDt.Enabled = False
            Me.chkRedeemDt.Location = New System.Drawing.Point(33, 20)
            Me.chkRedeemDt.Name = "chkRedeemDt"
            Me.chkRedeemDt.ReadOnlys = False
            Me.chkRedeemDt.Size = New System.Drawing.Size(72, 16)
            Me.chkRedeemDt.TabIndex = 25
            Me.chkRedeemDt.Tag = Nothing
            Me.chkRedeemDt.Text = "회수일자"
            Me.chkRedeemDt.TextValue = "1"
            Me.chkRedeemDt.UseVisualStyleBackColor = False
            '
            'dtpRedeemDt_FR
            '
            Me.dtpRedeemDt_FR.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRedeemDt_FR.BorderColor = System.Drawing.Color.Empty
            Me.dtpRedeemDt_FR.BorderStyle = 2
            Me.dtpRedeemDt_FR.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRedeemDt_FR.CaptionName = "발행년월From"
            Me.dtpRedeemDt_FR.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRedeemDt_FR.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpRedeemDt_FR.Location = New System.Drawing.Point(112, 18)
            Me.dtpRedeemDt_FR.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRedeemDt_FR.MaxLength = 0
            Me.dtpRedeemDt_FR.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRedeemDt_FR.Name = "dtpRedeemDt_FR"
            Me.dtpRedeemDt_FR.ReadOnlys = False
            Me.dtpRedeemDt_FR.SelectedText = ""
            Me.dtpRedeemDt_FR.SelectionLength = 0
            Me.dtpRedeemDt_FR.SelectionStart = 0
            Me.dtpRedeemDt_FR.Size = New System.Drawing.Size(109, 20)
            Me.dtpRedeemDt_FR.TabIndex = 26
            Me.dtpRedeemDt_FR.Tag = "format(&&&&-&&-&&);"
            Me.dtpRedeemDt_FR.TextAlign = 0
            Me.dtpRedeemDt_FR.TextValue = ""
            Me.dtpRedeemDt_FR.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label12.Location = New System.Drawing.Point(219, 20)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(21, 16)
            Me.Label12.TabIndex = 27
            Me.Label12.Text = "~"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpRedeemDt_To
            '
            Me.dtpRedeemDt_To.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRedeemDt_To.BorderColor = System.Drawing.Color.Empty
            Me.dtpRedeemDt_To.BorderStyle = 2
            Me.dtpRedeemDt_To.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRedeemDt_To.CaptionName = "발행년월From"
            Me.dtpRedeemDt_To.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRedeemDt_To.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpRedeemDt_To.Location = New System.Drawing.Point(236, 18)
            Me.dtpRedeemDt_To.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRedeemDt_To.MaxLength = 0
            Me.dtpRedeemDt_To.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRedeemDt_To.Name = "dtpRedeemDt_To"
            Me.dtpRedeemDt_To.ReadOnlys = False
            Me.dtpRedeemDt_To.SelectedText = ""
            Me.dtpRedeemDt_To.SelectionLength = 0
            Me.dtpRedeemDt_To.SelectionStart = 0
            Me.dtpRedeemDt_To.Size = New System.Drawing.Size(109, 20)
            Me.dtpRedeemDt_To.TabIndex = 2
            Me.dtpRedeemDt_To.Tag = "format(&&&&-&&-&&);"
            Me.dtpRedeemDt_To.TextAlign = 0
            Me.dtpRedeemDt_To.TextValue = ""
            Me.dtpRedeemDt_To.ToolTipText = ""
            '
            'PNJ201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtABarCode)
            Me.Controls.Add(Me.txtDetailOrders)
            Me.Controls.Add(Me.popCouponCorpCd)
            Me.Controls.Add(Me.dtpRedeemDt_To)
            Me.Controls.Add(Me.dtpRedeemDt_FR)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.chkRedeemDt)
            Me.Controls.Add(Me.lblMsg11)
            Me.Controls.Add(Me.lblMsg13)
            Me.Controls.Add(Me.lblMsg12)
            Me.Controls.Add(Me.numApplyUnitCost)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.numRedeemUnitCost)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtBarCode)
            Me.Controls.Add(Me.btnContine)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpPublishYearMonthTo)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpPublishYearMonthFrom)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.btnInsert)
            Me.Controls.Add(Me.dtpRedeemDt)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dtpPayYYYYMM)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popBranchCd)
            Me.Controls.Add(Me.lblDeliveryBranchCd)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picIo_1_1)
            Me.Name = "PNJ201"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picIo_1_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.lblDeliveryBranchCd, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpPayYYYYMM, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.dtpRedeemDt, 0)
            Me.Controls.SetChildIndex(Me.btnInsert, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpPublishYearMonthFrom, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.dtpPublishYearMonthTo, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.btnContine, 0)
            Me.Controls.SetChildIndex(Me.txtBarCode, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.numRedeemUnitCost, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.Label10, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            Me.Controls.SetChildIndex(Me.Label11, 0)
            Me.Controls.SetChildIndex(Me.numApplyUnitCost, 0)
            Me.Controls.SetChildIndex(Me.lblMsg12, 0)
            Me.Controls.SetChildIndex(Me.lblMsg13, 0)
            Me.Controls.SetChildIndex(Me.lblMsg11, 0)
            Me.Controls.SetChildIndex(Me.chkRedeemDt, 0)
            Me.Controls.SetChildIndex(Me.Label12, 0)
            Me.Controls.SetChildIndex(Me.dtpRedeemDt_FR, 0)
            Me.Controls.SetChildIndex(Me.dtpRedeemDt_To, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd, 0)
            Me.Controls.SetChildIndex(Me.txtDetailOrders, 0)
            Me.Controls.SetChildIndex(Me.txtABarCode, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_1_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popCouponCorpCd As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents picIo_1_1 As System.Windows.Forms.PictureBox
        Friend WithEvents popBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents lblDeliveryBranchCd As System.Windows.Forms.Label
        Friend WithEvents dtpPayYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpRedeemDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnInsert As ubiLease.CommonControls.btn
        Friend WithEvents txtDetailOrders As ubiLease.CommonControls.txt
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpPublishYearMonthTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpPublishYearMonthFrom As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnContine As ubiLease.CommonControls.btn
        Friend WithEvents txtBarCode As ubiLease.CommonControls.txt
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents numRedeemUnitCost As ubiLease.CommonControls.num
        Friend WithEvents txtABarCode As ubiLease.CommonControls.txt
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As ubiLease.CommonControls.btn
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents numApplyUnitCost As ubiLease.CommonControls.num
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblMsg12 As System.Windows.Forms.Label
        Friend WithEvents lblMsg13 As System.Windows.Forms.Label
        Friend WithEvents lblMsg11 As System.Windows.Forms.Label
        Friend WithEvents chkRedeemDt As ubiLease.CommonControls.chk
        Friend WithEvents dtpRedeemDt_FR As ubiLease.CommonControls.dtp
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpRedeemDt_To As ubiLease.CommonControls.dtp


    End Class

End Namespace
