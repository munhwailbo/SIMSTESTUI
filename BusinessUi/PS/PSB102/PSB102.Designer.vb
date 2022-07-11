Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSB102 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSB102))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpPubDateTo_R = New ubiLease.CommonControls.dtp
            Me.dtpPubDateFr_R = New ubiLease.CommonControls.dtp
            Me.optGb2 = New System.Windows.Forms.RadioButton
            Me.optGb1 = New System.Windows.Forms.RadioButton
            Me.dtpPubYYmm_R = New ubiLease.CommonControls.dtp
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblSaleTypeCd_R = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.lblTitle2 = New System.Windows.Forms.Label
            Me.picTitle2 = New System.Windows.Forms.PictureBox
            Me.picBar2 = New System.Windows.Forms.PictureBox
            Me.picBar = New System.Windows.Forms.PictureBox
            Me.btnSave = New System.Windows.Forms.Button
            Me.btnReqSale = New System.Windows.Forms.Button
            Me.lblTitle22 = New System.Windows.Forms.Label
            Me.dtpSaleDateTo_R = New ubiLease.CommonControls.dtp
            Me.lblTitle21 = New System.Windows.Forms.Label
            Me.dtpSaleDateFr_R = New ubiLease.CommonControls.dtp
            Me.chkSaleDateYesOrNo = New ubiLease.CommonControls.chk
            Me.dtpSaleDate_All = New ubiLease.CommonControls.dtp
            Me.btnSaleDate_All = New System.Windows.Forms.Button
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.grd_1.Location = New System.Drawing.Point(2, 105)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(792, 532)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 6
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
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
            Me.grd_2.Location = New System.Drawing.Point(2, 477)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(792, 160)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 5
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(627, 42)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(11, 12)
            Me.Label6.TabIndex = 1614
            Me.Label6.Text = "~"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPubDateTo_R
            '
            Me.dtpPubDateTo_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubDateTo_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubDateTo_R.BorderStyle = 2
            Me.dtpPubDateTo_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubDateTo_R.CaptionName = "발행일자"
            Me.dtpPubDateTo_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpPubDateTo_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubDateTo_R.Location = New System.Drawing.Point(640, 38)
            Me.dtpPubDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateTo_R.MaxLength = 0
            Me.dtpPubDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateTo_R.Name = "dtpPubDateTo_R"
            Me.dtpPubDateTo_R.ReadOnlys = False
            Me.dtpPubDateTo_R.SelectedText = ""
            Me.dtpPubDateTo_R.SelectionLength = 0
            Me.dtpPubDateTo_R.SelectionStart = 0
            Me.dtpPubDateTo_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateTo_R.TabIndex = 1613
            Me.dtpPubDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDateTo_R.TextAlign = 0
            Me.dtpPubDateTo_R.TextValue = "[4]dtpPubDate_To"
            Me.dtpPubDateTo_R.ToolTipText = "발행일자"
            '
            'dtpPubDateFr_R
            '
            Me.dtpPubDateFr_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubDateFr_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubDateFr_R.BorderStyle = 2
            Me.dtpPubDateFr_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubDateFr_R.CaptionName = "발행일자"
            Me.dtpPubDateFr_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpPubDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubDateFr_R.Location = New System.Drawing.Point(521, 38)
            Me.dtpPubDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateFr_R.MaxLength = 0
            Me.dtpPubDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateFr_R.Name = "dtpPubDateFr_R"
            Me.dtpPubDateFr_R.ReadOnlys = False
            Me.dtpPubDateFr_R.SelectedText = ""
            Me.dtpPubDateFr_R.SelectionLength = 0
            Me.dtpPubDateFr_R.SelectionStart = 0
            Me.dtpPubDateFr_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateFr_R.TabIndex = 1612
            Me.dtpPubDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDateFr_R.TextAlign = 0
            Me.dtpPubDateFr_R.TextValue = "[4]dtpPubDate_Fr"
            Me.dtpPubDateFr_R.ToolTipText = "발행일자"
            '
            'optGb2
            '
            Me.optGb2.AutoSize = True
            Me.optGb2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGb2.Location = New System.Drawing.Point(443, 40)
            Me.optGb2.Name = "optGb2"
            Me.optGb2.Size = New System.Drawing.Size(71, 16)
            Me.optGb2.TabIndex = 1611
            Me.optGb2.TabStop = True
            Me.optGb2.Text = "발행일자"
            Me.optGb2.UseVisualStyleBackColor = False
            '
            'optGb1
            '
            Me.optGb1.AutoSize = True
            Me.optGb1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGb1.Location = New System.Drawing.Point(443, 15)
            Me.optGb1.Name = "optGb1"
            Me.optGb1.Size = New System.Drawing.Size(71, 16)
            Me.optGb1.TabIndex = 1610
            Me.optGb1.TabStop = True
            Me.optGb1.Text = "발행년월"
            Me.optGb1.UseVisualStyleBackColor = False
            '
            'dtpPubYYmm_R
            '
            Me.dtpPubYYmm_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubYYmm_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubYYmm_R.BorderStyle = 2
            Me.dtpPubYYmm_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubYYmm_R.CaptionName = "발행년월"
            Me.dtpPubYYmm_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpPubYYmm_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubYYmm_R.Location = New System.Drawing.Point(521, 12)
            Me.dtpPubYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm_R.MaxLength = 0
            Me.dtpPubYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm_R.Name = "dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ReadOnlys = False
            Me.dtpPubYYmm_R.SelectedText = ""
            Me.dtpPubYYmm_R.SelectionLength = 0
            Me.dtpPubYYmm_R.SelectionStart = 0
            Me.dtpPubYYmm_R.Size = New System.Drawing.Size(78, 20)
            Me.dtpPubYYmm_R.TabIndex = 1609
            Me.dtpPubYYmm_R.Tag = "format(&&&&-&&);"
            Me.dtpPubYYmm_R.TextAlign = 0
            Me.dtpPubYYmm_R.TextValue = "[1]dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ToolTipText = "발행년월"
            '
            'popCustomerCode_R
            '
            Me.popCustomerCode_R.BorderColor = System.Drawing.Color.Empty
            Me.popCustomerCode_R.BorderStyle = 2
            Me.popCustomerCode_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCustomerCode_R.CaptionName = "경리거래처코드"
            Me.popCustomerCode_R.CausesValidation = False
            Me.popCustomerCode_R.CodeText = "[1] pop경리거래처코드"
            Me.popCustomerCode_R.CodeWidth = 70
            Me.popCustomerCode_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCustomerCode_R.Location = New System.Drawing.Point(123, 38)
            Me.popCustomerCode_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCustomerCode_R.MaxLength = 6
            Me.popCustomerCode_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popCustomerCode_R.Name = "popCustomerCode_R"
            Me.popCustomerCode_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCustomerCode_R.NameText = ""
            Me.popCustomerCode_R.ReadOnlys = False
            Me.popCustomerCode_R.SelectedText = ""
            Me.popCustomerCode_R.SelectionLength = 0
            Me.popCustomerCode_R.SelectionStart = 0
            Me.popCustomerCode_R.Size = New System.Drawing.Size(268, 20)
            Me.popCustomerCode_R.TabIndex = 1608
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[1] pop경리거래처코드"
            Me.popCustomerCode_R.ToolTipText = "경리거래처코드"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(48, 42)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 12)
            Me.Label1.TabIndex = 1607
            Me.Label1.Text = "거래처코드"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(26, 17)
            Me.lblSaleTypeCd_R.Name = "lblSaleTypeCd_R"
            Me.lblSaleTypeCd_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd_R.TabIndex = 1604
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(123, 12)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(268, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1605
            Me.cboSaleTypeCd_R.Tag = "code(판매매출구분);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(2, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(792, 61)
            Me.picCriteria.TabIndex = 1606
            Me.picCriteria.TabStop = False
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(10, 74)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(124, 12)
            Me.lblTitle1.TabIndex = 1616
            Me.lblTitle1.Text = "<계산서 발행 내역>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(2, 68)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(792, 39)
            Me.picTitle1.TabIndex = 1615
            Me.picTitle1.TabStop = False
            '
            'lblTitle2
            '
            Me.lblTitle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle2.AutoSize = True
            Me.lblTitle2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle2.Location = New System.Drawing.Point(6, 460)
            Me.lblTitle2.Name = "lblTitle2"
            Me.lblTitle2.Size = New System.Drawing.Size(157, 12)
            Me.lblTitle2.TabIndex = 1617
            Me.lblTitle2.Text = "<계산서 상세/매출 내역>"
            Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle2
            '
            Me.picTitle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle2.BackColor = System.Drawing.Color.LightGray
            Me.picTitle2.Location = New System.Drawing.Point(2, 454)
            Me.picTitle2.Name = "picTitle2"
            Me.picTitle2.Size = New System.Drawing.Size(792, 23)
            Me.picTitle2.TabIndex = 1618
            Me.picTitle2.TabStop = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(3, 379)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(791, 2)
            Me.picBar2.TabIndex = 1778
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar.Location = New System.Drawing.Point(3, 450)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(791, 3)
            Me.picBar.TabIndex = 1777
            Me.picBar.TabStop = False
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(594, 73)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(90, 26)
            Me.btnSave.TabIndex = 1784
            Me.btnSave.Text = "계산서 등록"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnReqSale
            '
            Me.btnReqSale.Location = New System.Drawing.Point(463, 73)
            Me.btnReqSale.Name = "btnReqSale"
            Me.btnReqSale.Size = New System.Drawing.Size(121, 26)
            Me.btnReqSale.TabIndex = 1783
            Me.btnReqSale.Text = "매출기초자료 조회"
            Me.btnReqSale.UseVisualStyleBackColor = True
            '
            'lblTitle22
            '
            Me.lblTitle22.BackColor = System.Drawing.Color.GhostWhite
            Me.lblTitle22.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle22.Location = New System.Drawing.Point(341, 81)
            Me.lblTitle22.Name = "lblTitle22"
            Me.lblTitle22.Size = New System.Drawing.Size(11, 12)
            Me.lblTitle22.TabIndex = 1782
            Me.lblTitle22.Text = "~"
            Me.lblTitle22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpSaleDateTo_R
            '
            Me.dtpSaleDateTo_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSaleDateTo_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpSaleDateTo_R.BorderStyle = 2
            Me.dtpSaleDateTo_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSaleDateTo_R.CaptionName = "발행일자"
            Me.dtpSaleDateTo_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSaleDateTo_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSaleDateTo_R.Location = New System.Drawing.Point(355, 77)
            Me.dtpSaleDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDateTo_R.MaxLength = 0
            Me.dtpSaleDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDateTo_R.Name = "dtpSaleDateTo_R"
            Me.dtpSaleDateTo_R.ReadOnlys = False
            Me.dtpSaleDateTo_R.SelectedText = ""
            Me.dtpSaleDateTo_R.SelectionLength = 0
            Me.dtpSaleDateTo_R.SelectionStart = 0
            Me.dtpSaleDateTo_R.Size = New System.Drawing.Size(102, 20)
            Me.dtpSaleDateTo_R.TabIndex = 1781
            Me.dtpSaleDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDateTo_R.TextAlign = 0
            Me.dtpSaleDateTo_R.TextValue = "[4]dtpSaleDateTo_R"
            Me.dtpSaleDateTo_R.ToolTipText = "발행일자"
            '
            'lblTitle21
            '
            Me.lblTitle21.BackColor = System.Drawing.Color.GhostWhite
            Me.lblTitle21.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle21.Location = New System.Drawing.Point(160, 81)
            Me.lblTitle21.Name = "lblTitle21"
            Me.lblTitle21.Size = New System.Drawing.Size(71, 12)
            Me.lblTitle21.TabIndex = 1779
            Me.lblTitle21.Text = "발행일자"
            Me.lblTitle21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpSaleDateFr_R
            '
            Me.dtpSaleDateFr_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSaleDateFr_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpSaleDateFr_R.BorderStyle = 2
            Me.dtpSaleDateFr_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSaleDateFr_R.CaptionName = "발행일자"
            Me.dtpSaleDateFr_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSaleDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSaleDateFr_R.Location = New System.Drawing.Point(235, 77)
            Me.dtpSaleDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDateFr_R.MaxLength = 0
            Me.dtpSaleDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDateFr_R.Name = "dtpSaleDateFr_R"
            Me.dtpSaleDateFr_R.ReadOnlys = False
            Me.dtpSaleDateFr_R.SelectedText = ""
            Me.dtpSaleDateFr_R.SelectionLength = 0
            Me.dtpSaleDateFr_R.SelectionStart = 0
            Me.dtpSaleDateFr_R.Size = New System.Drawing.Size(102, 20)
            Me.dtpSaleDateFr_R.TabIndex = 1780
            Me.dtpSaleDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDateFr_R.TextAlign = 0
            Me.dtpSaleDateFr_R.TextValue = "[4]dtpSaleDateFr_R"
            Me.dtpSaleDateFr_R.ToolTipText = "발행일자"
            '
            'chkSaleDateYesOrNo
            '
            Me.chkSaleDateYesOrNo.AutoSize = True
            Me.chkSaleDateYesOrNo.BackColor = System.Drawing.Color.LightGray
            Me.chkSaleDateYesOrNo.CaptionName = Nothing
            Me.chkSaleDateYesOrNo.Location = New System.Drawing.Point(708, 73)
            Me.chkSaleDateYesOrNo.Name = "chkSaleDateYesOrNo"
            Me.chkSaleDateYesOrNo.ReadOnlys = False
            Me.chkSaleDateYesOrNo.Size = New System.Drawing.Size(72, 28)
            Me.chkSaleDateYesOrNo.TabIndex = 1785
            Me.chkSaleDateYesOrNo.Tag = Nothing
            Me.chkSaleDateYesOrNo.Text = "발행일자" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "일괄적용"
            Me.chkSaleDateYesOrNo.TextValue = "0"
            Me.chkSaleDateYesOrNo.UseVisualStyleBackColor = False
            '
            'dtpSaleDate_All
            '
            Me.dtpSaleDate_All.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSaleDate_All.BorderColor = System.Drawing.Color.Empty
            Me.dtpSaleDate_All.BorderStyle = 2
            Me.dtpSaleDate_All.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSaleDate_All.CaptionName = "발행일자"
            Me.dtpSaleDate_All.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSaleDate_All.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSaleDate_All.Location = New System.Drawing.Point(786, 76)
            Me.dtpSaleDate_All.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDate_All.MaxLength = 0
            Me.dtpSaleDate_All.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDate_All.Name = "dtpSaleDate_All"
            Me.dtpSaleDate_All.ReadOnlys = False
            Me.dtpSaleDate_All.SelectedText = ""
            Me.dtpSaleDate_All.SelectionLength = 0
            Me.dtpSaleDate_All.SelectionStart = 0
            Me.dtpSaleDate_All.Size = New System.Drawing.Size(102, 20)
            Me.dtpSaleDate_All.TabIndex = 1786
            Me.dtpSaleDate_All.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDate_All.TextAlign = 0
            Me.dtpSaleDate_All.TextValue = "dtpSaleDate_All"
            Me.dtpSaleDate_All.ToolTipText = "발행일자"
            Me.dtpSaleDate_All.Visible = False
            '
            'btnSaleDate_All
            '
            Me.btnSaleDate_All.Location = New System.Drawing.Point(889, 72)
            Me.btnSaleDate_All.Name = "btnSaleDate_All"
            Me.btnSaleDate_All.Size = New System.Drawing.Size(74, 26)
            Me.btnSaleDate_All.TabIndex = 1787
            Me.btnSaleDate_All.Text = "일괄적용"
            Me.btnSaleDate_All.UseVisualStyleBackColor = True
            '
            'PSB102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnSaleDate_All)
            Me.Controls.Add(Me.dtpSaleDate_All)
            Me.Controls.Add(Me.chkSaleDateYesOrNo)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnReqSale)
            Me.Controls.Add(Me.lblTitle22)
            Me.Controls.Add(Me.dtpSaleDateTo_R)
            Me.Controls.Add(Me.lblTitle21)
            Me.Controls.Add(Me.dtpSaleDateFr_R)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.lblTitle2)
            Me.Controls.Add(Me.picTitle2)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpPubDateTo_R)
            Me.Controls.Add(Me.dtpPubDateFr_R)
            Me.Controls.Add(Me.optGb2)
            Me.Controls.Add(Me.optGb1)
            Me.Controls.Add(Me.dtpPubYYmm_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblSaleTypeCd_R)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSB102"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubYYmm_R, 0)
            Me.Controls.SetChildIndex(Me.optGb1, 0)
            Me.Controls.SetChildIndex(Me.optGb2, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.picTitle2, 0)
            Me.Controls.SetChildIndex(Me.lblTitle2, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.lblTitle21, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.lblTitle22, 0)
            Me.Controls.SetChildIndex(Me.btnReqSale, 0)
            Me.Controls.SetChildIndex(Me.btnSave, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.chkSaleDateYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDate_All, 0)
            Me.Controls.SetChildIndex(Me.btnSaleDate_All, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub





        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpPubDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents dtpPubDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents optGb2 As System.Windows.Forms.RadioButton
        Friend WithEvents optGb1 As System.Windows.Forms.RadioButton
        Friend WithEvents dtpPubYYmm_R As ubiLease.CommonControls.dtp
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblSaleTypeCd_R As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle2 As System.Windows.Forms.Label
        Friend WithEvents picTitle2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnReqSale As System.Windows.Forms.Button
        Friend WithEvents lblTitle22 As System.Windows.Forms.Label
        Friend WithEvents dtpSaleDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblTitle21 As System.Windows.Forms.Label
        Friend WithEvents dtpSaleDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents chkSaleDateYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents dtpSaleDate_All As ubiLease.CommonControls.dtp
        Friend WithEvents btnSaleDate_All As System.Windows.Forms.Button

 
    End Class 
 
End Namespace 