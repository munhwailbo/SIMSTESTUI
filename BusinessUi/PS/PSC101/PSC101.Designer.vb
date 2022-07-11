Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSC101 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSC101))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.lblTitle2 = New System.Windows.Forms.Label
            Me.picTitle2 = New System.Windows.Forms.PictureBox
            Me.lblTitle3 = New System.Windows.Forms.Label
            Me.picTitle3 = New System.Windows.Forms.PictureBox
            Me.picBar2 = New System.Windows.Forms.PictureBox
            Me.picBar = New System.Windows.Forms.PictureBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpPubDateTo_R = New ubiLease.CommonControls.dtp
            Me.dtpPubDateFr_R = New ubiLease.CommonControls.dtp
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblSaleTypeCd_R = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
            Me.picBarY2 = New System.Windows.Forms.PictureBox
            Me.picBarY = New System.Windows.Forms.PictureBox
            Me.btnRowAdd = New System.Windows.Forms.Button
            Me.btnReqSale = New System.Windows.Forms.Button
            Me.lblPubYYmm = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpPubYYmm_R = New ubiLease.CommonControls.dtp
            Me.numPubSeq_R = New ubiLease.CommonControls.num
            Me.lblCriteria = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBarY2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBarY, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(790, 60)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 90)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 276)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 7
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
            Me.grd_2.Location = New System.Drawing.Point(5, 393)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(472, 244)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 6
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
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
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(483, 393)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(312, 244)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 5
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(11, 72)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(93, 12)
            Me.lblTitle1.TabIndex = 1782
            Me.lblTitle1.Text = "<계산서 내역>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(5, 68)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(790, 23)
            Me.picTitle1.TabIndex = 1781
            Me.picTitle1.TabStop = False
            '
            'lblTitle2
            '
            Me.lblTitle2.AutoSize = True
            Me.lblTitle2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle2.Location = New System.Drawing.Point(11, 376)
            Me.lblTitle2.Name = "lblTitle2"
            Me.lblTitle2.Size = New System.Drawing.Size(80, 12)
            Me.lblTitle2.TabIndex = 1784
            Me.lblTitle2.Text = "<매출 계획>"
            Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle2
            '
            Me.picTitle2.BackColor = System.Drawing.Color.LightGray
            Me.picTitle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle2.Location = New System.Drawing.Point(5, 371)
            Me.picTitle2.Name = "picTitle2"
            Me.picTitle2.Size = New System.Drawing.Size(472, 23)
            Me.picTitle2.TabIndex = 1783
            Me.picTitle2.TabStop = False
            '
            'lblTitle3
            '
            Me.lblTitle3.AutoSize = True
            Me.lblTitle3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle3.Location = New System.Drawing.Point(494, 376)
            Me.lblTitle3.Name = "lblTitle3"
            Me.lblTitle3.Size = New System.Drawing.Size(111, 12)
            Me.lblTitle3.TabIndex = 1786
            Me.lblTitle3.Text = "<매출 처리 내역>"
            Me.lblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle3
            '
            Me.picTitle3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle3.BackColor = System.Drawing.Color.LightGray
            Me.picTitle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle3.Location = New System.Drawing.Point(483, 371)
            Me.picTitle3.Name = "picTitle3"
            Me.picTitle3.Size = New System.Drawing.Size(312, 23)
            Me.picTitle3.TabIndex = 1785
            Me.picTitle3.TabStop = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(5, 327)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(790, 2)
            Me.picBar2.TabIndex = 1788
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar.Location = New System.Drawing.Point(5, 367)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(790, 3)
            Me.picBar.TabIndex = 1787
            Me.picBar.TabStop = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(618, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(11, 12)
            Me.Label6.TabIndex = 1798
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
            Me.dtpPubDateTo_R.Location = New System.Drawing.Point(631, 39)
            Me.dtpPubDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateTo_R.MaxLength = 0
            Me.dtpPubDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateTo_R.Name = "dtpPubDateTo_R"
            Me.dtpPubDateTo_R.ReadOnlys = False
            Me.dtpPubDateTo_R.SelectedText = ""
            Me.dtpPubDateTo_R.SelectionLength = 0
            Me.dtpPubDateTo_R.SelectionStart = 0
            Me.dtpPubDateTo_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateTo_R.TabIndex = 1797
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
            Me.dtpPubDateFr_R.Location = New System.Drawing.Point(512, 39)
            Me.dtpPubDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateFr_R.MaxLength = 0
            Me.dtpPubDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateFr_R.Name = "dtpPubDateFr_R"
            Me.dtpPubDateFr_R.ReadOnlys = False
            Me.dtpPubDateFr_R.SelectedText = ""
            Me.dtpPubDateFr_R.SelectionLength = 0
            Me.dtpPubDateFr_R.SelectionStart = 0
            Me.dtpPubDateFr_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateFr_R.TabIndex = 1796
            Me.dtpPubDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDateFr_R.TextAlign = 0
            Me.dtpPubDateFr_R.TextValue = "[4]dtpPubDate_Fr"
            Me.dtpPubDateFr_R.ToolTipText = "발행일자"
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
            Me.popCustomerCode_R.Location = New System.Drawing.Point(114, 39)
            Me.popCustomerCode_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCustomerCode_R.MaxLength = 7
            Me.popCustomerCode_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popCustomerCode_R.Name = "popCustomerCode_R"
            Me.popCustomerCode_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCustomerCode_R.NameText = ""
            Me.popCustomerCode_R.ReadOnlys = False
            Me.popCustomerCode_R.SelectedText = ""
            Me.popCustomerCode_R.SelectionLength = 0
            Me.popCustomerCode_R.SelectionStart = 0
            Me.popCustomerCode_R.Size = New System.Drawing.Size(268, 20)
            Me.popCustomerCode_R.TabIndex = 1792
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[1] pop경리거래처코드"
            Me.popCustomerCode_R.ToolTipText = "경리거래처코드"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(39, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 12)
            Me.Label1.TabIndex = 1791
            Me.Label1.Text = "거래처코드"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(17, 18)
            Me.lblSaleTypeCd_R.Name = "lblSaleTypeCd_R"
            Me.lblSaleTypeCd_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd_R.TabIndex = 1789
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(114, 14)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(268, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1790
            Me.cboSaleTypeCd_R.Tag = "code(판매매출구분);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'picBarY2
            '
            Me.picBarY2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.picBarY2.BackColor = System.Drawing.Color.DarkGray
            Me.picBarY2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBarY2.Location = New System.Drawing.Point(461, 371)
            Me.picBarY2.Name = "picBarY2"
            Me.picBarY2.Size = New System.Drawing.Size(2, 266)
            Me.picBarY2.TabIndex = 1800
            Me.picBarY2.TabStop = False
            Me.picBarY2.Visible = False
            '
            'picBarY
            '
            Me.picBarY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.picBarY.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBarY.Cursor = System.Windows.Forms.Cursors.VSplit
            Me.picBarY.Location = New System.Drawing.Point(479, 371)
            Me.picBarY.Name = "picBarY"
            Me.picBarY.Size = New System.Drawing.Size(4, 266)
            Me.picBarY.TabIndex = 1799
            Me.picBarY.TabStop = False
            '
            'btnRowAdd
            '
            Me.btnRowAdd.Location = New System.Drawing.Point(734, 372)
            Me.btnRowAdd.Name = "btnRowAdd"
            Me.btnRowAdd.Size = New System.Drawing.Size(61, 20)
            Me.btnRowAdd.TabIndex = 1802
            Me.btnRowAdd.Text = "행추가"
            Me.btnRowAdd.UseVisualStyleBackColor = True
            '
            'btnReqSale
            '
            Me.btnReqSale.Location = New System.Drawing.Point(645, 372)
            Me.btnReqSale.Name = "btnReqSale"
            Me.btnReqSale.Size = New System.Drawing.Size(80, 20)
            Me.btnReqSale.TabIndex = 1801
            Me.btnReqSale.Text = "계획 반영"
            Me.btnReqSale.UseVisualStyleBackColor = True
            '
            'lblPubYYmm
            '
            Me.lblPubYYmm.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPubYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblPubYYmm.Location = New System.Drawing.Point(443, 18)
            Me.lblPubYYmm.Name = "lblPubYYmm"
            Me.lblPubYYmm.Size = New System.Drawing.Size(65, 12)
            Me.lblPubYYmm.TabIndex = 1843
            Me.lblPubYYmm.Text = "계산서번호"
            Me.lblPubYYmm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(443, 42)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 12)
            Me.Label2.TabIndex = 1844
            Me.Label2.Text = "기준일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Enabled = False
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(603, 18)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(9, 12)
            Me.Label3.TabIndex = 1841
            Me.Label3.Text = "-"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPubYYmm_R
            '
            Me.dtpPubYYmm_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubYYmm_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubYYmm_R.BorderStyle = 2
            Me.dtpPubYYmm_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubYYmm_R.CaptionName = "계산서발행년월"
            Me.dtpPubYYmm_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpPubYYmm_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubYYmm_R.Location = New System.Drawing.Point(513, 14)
            Me.dtpPubYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm_R.MaxLength = 0
            Me.dtpPubYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm_R.Name = "dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ReadOnlys = False
            Me.dtpPubYYmm_R.SelectedText = ""
            Me.dtpPubYYmm_R.SelectionLength = 0
            Me.dtpPubYYmm_R.SelectionStart = 0
            Me.dtpPubYYmm_R.Size = New System.Drawing.Size(88, 20)
            Me.dtpPubYYmm_R.TabIndex = 1840
            Me.dtpPubYYmm_R.Tag = "format(&&&&-&&);"
            Me.dtpPubYYmm_R.TextAlign = 0
            Me.dtpPubYYmm_R.TextValue = "[1]dtpPubYYmm"
            Me.dtpPubYYmm_R.ToolTipText = "계산서발행년월"
            '
            'numPubSeq_R
            '
            Me.numPubSeq_R.BackColor = System.Drawing.SystemColors.Window
            Me.numPubSeq_R.BorderColor = System.Drawing.Color.Empty
            Me.numPubSeq_R.BorderStyle = 2
            Me.numPubSeq_R.CaptionName = "발행순번"
            Me.numPubSeq_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numPubSeq_R.LengthPrecision = 15
            Me.numPubSeq_R.LengthScale = 0
            Me.numPubSeq_R.Location = New System.Drawing.Point(615, 14)
            Me.numPubSeq_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPubSeq_R.MaxLength = 0
            Me.numPubSeq_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPubSeq_R.Name = "numPubSeq_R"
            Me.numPubSeq_R.ReadOnlys = False
            Me.numPubSeq_R.SelectedText = ""
            Me.numPubSeq_R.SelectionLength = 0
            Me.numPubSeq_R.SelectionStart = 1
            Me.numPubSeq_R.Size = New System.Drawing.Size(52, 20)
            Me.numPubSeq_R.TabIndex = 1842
            Me.numPubSeq_R.Tag = ""
            Me.numPubSeq_R.TextValue = "0"
            Me.numPubSeq_R.ToolTipText = "발행순번"
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.LightGray
            Me.lblCriteria.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria.Location = New System.Drawing.Point(127, 74)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria.TabIndex = 1845
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PSC101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblCriteria)
            Me.Controls.Add(Me.lblPubYYmm)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpPubYYmm_R)
            Me.Controls.Add(Me.numPubSeq_R)
            Me.Controls.Add(Me.btnRowAdd)
            Me.Controls.Add(Me.btnReqSale)
            Me.Controls.Add(Me.picBarY2)
            Me.Controls.Add(Me.picBarY)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpPubDateTo_R)
            Me.Controls.Add(Me.dtpPubDateFr_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblSaleTypeCd_R)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.lblTitle2)
            Me.Controls.Add(Me.picTitle2)
            Me.Controls.Add(Me.lblTitle3)
            Me.Controls.Add(Me.picTitle3)
            Me.Name = "PSC101"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picTitle3, 0)
            Me.Controls.SetChildIndex(Me.lblTitle3, 0)
            Me.Controls.SetChildIndex(Me.picTitle2, 0)
            Me.Controls.SetChildIndex(Me.lblTitle2, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.picBarY, 0)
            Me.Controls.SetChildIndex(Me.picBarY2, 0)
            Me.Controls.SetChildIndex(Me.btnReqSale, 0)
            Me.Controls.SetChildIndex(Me.btnRowAdd, 0)
            Me.Controls.SetChildIndex(Me.numPubSeq_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubYYmm_R, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.lblPubYYmm, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBarY2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBarY, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle2 As System.Windows.Forms.Label
        Friend WithEvents picTitle2 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle3 As System.Windows.Forms.Label
        Friend WithEvents picTitle3 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpPubDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents dtpPubDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblSaleTypeCd_R As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents picBarY2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBarY As System.Windows.Forms.PictureBox
        Friend WithEvents btnRowAdd As System.Windows.Forms.Button
        Friend WithEvents btnReqSale As System.Windows.Forms.Button
        Friend WithEvents lblPubYYmm As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpPubYYmm_R As ubiLease.CommonControls.dtp
        Friend WithEvents numPubSeq_R As ubiLease.CommonControls.num
        Friend WithEvents lblCriteria As System.Windows.Forms.Label
 
    End Class 
 
End Namespace 