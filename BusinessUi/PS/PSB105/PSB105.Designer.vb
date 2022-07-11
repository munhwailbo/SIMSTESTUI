Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSB105 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSB105))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.btnRowAdd = New System.Windows.Forms.Button
            Me.btnReqSale = New System.Windows.Forms.Button
            Me.lblBillPeriodCd = New System.Windows.Forms.Label
            Me.picBar2 = New System.Windows.Forms.PictureBox
            Me.picBar = New System.Windows.Forms.PictureBox
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblTitle2 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.popEmployeeExpNum = New ubiLease.CommonControls.pop
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.lblCompanyCd = New System.Windows.Forms.Label
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
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria.TabIndex = 7
            Me.picCriteria.TabStop = False
            '
            'btnRowAdd
            '
            Me.btnRowAdd.Location = New System.Drawing.Point(709, 357)
            Me.btnRowAdd.Name = "btnRowAdd"
            Me.btnRowAdd.Size = New System.Drawing.Size(61, 26)
            Me.btnRowAdd.TabIndex = 1800
            Me.btnRowAdd.Text = "행추가"
            Me.btnRowAdd.UseVisualStyleBackColor = True
            '
            'btnReqSale
            '
            Me.btnReqSale.Location = New System.Drawing.Point(620, 357)
            Me.btnReqSale.Name = "btnReqSale"
            Me.btnReqSale.Size = New System.Drawing.Size(80, 26)
            Me.btnReqSale.TabIndex = 1799
            Me.btnReqSale.Text = "기초자료"
            Me.btnReqSale.UseVisualStyleBackColor = True
            '
            'lblBillPeriodCd
            '
            Me.lblBillPeriodCd.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBillPeriodCd.Font = New System.Drawing.Font("굴림", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBillPeriodCd.Location = New System.Drawing.Point(432, 365)
            Me.lblBillPeriodCd.Name = "lblBillPeriodCd"
            Me.lblBillPeriodCd.Size = New System.Drawing.Size(64, 12)
            Me.lblBillPeriodCd.TabIndex = 1797
            Me.lblBillPeriodCd.Text = "확장명"
            Me.lblBillPeriodCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblBillPeriodCd.Visible = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(5, 309)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(790, 2)
            Me.picBar2.TabIndex = 1794
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar.Location = New System.Drawing.Point(5, 351)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(790, 3)
            Me.picBar.TabIndex = 1793
            Me.picBar.TabStop = False
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
            Me.grd_2.Location = New System.Drawing.Point(5, 386)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(790, 249)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1789
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
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
            Me.grd_1.Location = New System.Drawing.Point(5, 88)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 261)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1790
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblTitle2
            '
            Me.lblTitle2.AutoSize = True
            Me.lblTitle2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle2.Location = New System.Drawing.Point(11, 360)
            Me.lblTitle2.Name = "lblTitle2"
            Me.lblTitle2.Size = New System.Drawing.Size(80, 12)
            Me.lblTitle2.TabIndex = 1796
            Me.lblTitle2.Text = "<독자 명단>"
            Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 355)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(790, 32)
            Me.PictureBox1.TabIndex = 1795
            Me.PictureBox1.TabStop = False
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(11, 72)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(93, 12)
            Me.lblTitle1.TabIndex = 1792
            Me.lblTitle1.Text = "<계산서 내역>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(5, 67)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(790, 23)
            Me.picTitle1.TabIndex = 1791
            Me.picTitle1.TabStop = False
            '
            'popEmployeeExpNum
            '
            Me.popEmployeeExpNum.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeExpNum.BorderStyle = 2
            Me.popEmployeeExpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeExpNum.CaptionName = "사원확장 명"
            Me.popEmployeeExpNum.CodeText = ""
            Me.popEmployeeExpNum.CodeWidth = 90
            Me.popEmployeeExpNum.Font = New System.Drawing.Font("굴림", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popEmployeeExpNum.Location = New System.Drawing.Point(502, 362)
            Me.popEmployeeExpNum.MaximumSize = New System.Drawing.Size(500, 18)
            Me.popEmployeeExpNum.MaxLength = 11
            Me.popEmployeeExpNum.MinimumSize = New System.Drawing.Size(19, 18)
            Me.popEmployeeExpNum.Name = "popEmployeeExpNum"
            Me.popEmployeeExpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeExpNum.NameText = ""
            Me.popEmployeeExpNum.ReadOnlys = False
            Me.popEmployeeExpNum.SelectedText = ""
            Me.popEmployeeExpNum.SelectionLength = 0
            Me.popEmployeeExpNum.SelectionStart = 0
            Me.popEmployeeExpNum.Size = New System.Drawing.Size(113, 18)
            Me.popEmployeeExpNum.TabIndex = 1801
            Me.popEmployeeExpNum.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum.TextAlign = 0
            Me.popEmployeeExpNum.TextValue = ""
            Me.popEmployeeExpNum.ToolTipText = ""
            Me.popEmployeeExpNum.Visible = False
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 80
            Me.popCompanyCd.Font = New System.Drawing.Font("굴림", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCompanyCd.Location = New System.Drawing.Point(159, 362)
            Me.popCompanyCd.MaximumSize = New System.Drawing.Size(500, 18)
            Me.popCompanyCd.MaxLength = 12
            Me.popCompanyCd.MinimumSize = New System.Drawing.Size(19, 18)
            Me.popCompanyCd.Name = "popCompanyCd"
            Me.popCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd.NameText = ""
            Me.popCompanyCd.ReadOnlys = False
            Me.popCompanyCd.SelectedText = ""
            Me.popCompanyCd.SelectionLength = 0
            Me.popCompanyCd.SelectionStart = 0
            Me.popCompanyCd.Size = New System.Drawing.Size(267, 18)
            Me.popCompanyCd.TabIndex = 1802
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            Me.popCompanyCd.Visible = False
            '
            'lblCompanyCd
            '
            Me.lblCompanyCd.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCompanyCd.Font = New System.Drawing.Font("굴림", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCompanyCd.Location = New System.Drawing.Point(102, 365)
            Me.lblCompanyCd.Name = "lblCompanyCd"
            Me.lblCompanyCd.Size = New System.Drawing.Size(57, 12)
            Me.lblCompanyCd.TabIndex = 1803
            Me.lblCompanyCd.Text = "확장처 명"
            Me.lblCompanyCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblCompanyCd.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(618, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(11, 12)
            Me.Label6.TabIndex = 1813
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
            Me.dtpPubDateTo_R.TabIndex = 1812
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
            Me.dtpPubDateFr_R.TabIndex = 1811
            Me.dtpPubDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDateFr_R.TextAlign = 0
            Me.dtpPubDateFr_R.TextValue = "[4]dtpPubDate_Fr"
            Me.dtpPubDateFr_R.ToolTipText = "발행일자"
            '
            'optGb2
            '
            Me.optGb2.AutoSize = True
            Me.optGb2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGb2.Location = New System.Drawing.Point(434, 41)
            Me.optGb2.Name = "optGb2"
            Me.optGb2.Size = New System.Drawing.Size(71, 16)
            Me.optGb2.TabIndex = 1810
            Me.optGb2.TabStop = True
            Me.optGb2.Text = "발행일자"
            Me.optGb2.UseVisualStyleBackColor = False
            '
            'optGb1
            '
            Me.optGb1.AutoSize = True
            Me.optGb1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGb1.Location = New System.Drawing.Point(434, 16)
            Me.optGb1.Name = "optGb1"
            Me.optGb1.Size = New System.Drawing.Size(71, 16)
            Me.optGb1.TabIndex = 1809
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
            Me.dtpPubYYmm_R.Location = New System.Drawing.Point(512, 13)
            Me.dtpPubYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm_R.MaxLength = 0
            Me.dtpPubYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm_R.Name = "dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ReadOnlys = False
            Me.dtpPubYYmm_R.SelectedText = ""
            Me.dtpPubYYmm_R.SelectionLength = 0
            Me.dtpPubYYmm_R.SelectionStart = 0
            Me.dtpPubYYmm_R.Size = New System.Drawing.Size(78, 20)
            Me.dtpPubYYmm_R.TabIndex = 1808
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
            Me.popCustomerCode_R.TabIndex = 1807
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
            Me.Label1.TabIndex = 1806
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
            Me.lblSaleTypeCd_R.TabIndex = 1804
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(114, 13)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(268, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1805
            Me.cboSaleTypeCd_R.Tag = "code(업체매출구분);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'PSB105
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
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
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.lblCompanyCd)
            Me.Controls.Add(Me.popEmployeeExpNum)
            Me.Controls.Add(Me.btnRowAdd)
            Me.Controls.Add(Me.btnReqSale)
            Me.Controls.Add(Me.lblBillPeriodCd)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblTitle2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSB105"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle2, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.lblBillPeriodCd, 0)
            Me.Controls.SetChildIndex(Me.btnReqSale, 0)
            Me.Controls.SetChildIndex(Me.btnRowAdd, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeExpNum, 0)
            Me.Controls.SetChildIndex(Me.lblCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
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
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub



        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents btnRowAdd As System.Windows.Forms.Button
        Friend WithEvents btnReqSale As System.Windows.Forms.Button
        Friend WithEvents lblBillPeriodCd As System.Windows.Forms.Label
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblTitle2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents popEmployeeExpNum As ubiLease.CommonControls.pop
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents lblCompanyCd As System.Windows.Forms.Label
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
 
    End Class 
 
End Namespace 