Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSB101 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSB101))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picIo_2_1 = New System.Windows.Forms.PictureBox
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.lblPubYYmm = New System.Windows.Forms.Label
            Me.dtpPubYYmm = New ubiLease.CommonControls.dtp
            Me.numPubSeq = New ubiLease.CommonControls.num
            Me.lblSaleTypeCd = New System.Windows.Forms.Label
            Me.cboSaleTypeCd = New ubiLease.CommonControls.cbo
            Me.lblPubDate = New System.Windows.Forms.Label
            Me.dtpPubDate = New ubiLease.CommonControls.dtp
            Me.lblTaxTypeCd = New System.Windows.Forms.Label
            Me.cboTaxTypeCd = New ubiLease.CommonControls.cbo
            Me.lblSupplyAmt = New System.Windows.Forms.Label
            Me.numSupplyAmt = New ubiLease.CommonControls.num
            Me.chkElectYesOrNo = New ubiLease.CommonControls.chk
            Me.lblASPBizCd = New System.Windows.Forms.Label
            Me.popASPBizCd = New ubiLease.CommonControls.pop
            Me.lblRemark = New System.Windows.Forms.Label
            Me.txtRemark = New ubiLease.CommonControls.txt
            Me.lblBizNum = New System.Windows.Forms.Label
            Me.txtBizNum = New ubiLease.CommonControls.txt
            Me.lblAccSlipNum = New System.Windows.Forms.Label
            Me.txtAccSlipNum = New ubiLease.CommonControls.txt
            Me.lblCustomerCode = New System.Windows.Forms.Label
            Me.chkDelYesOrNo = New ubiLease.CommonControls.chk
            Me.lblSaleTypeCd_R = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
            Me.popCustomerCode = New ubiLease.CommonControls.pop
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblTaxNumber = New System.Windows.Forms.Label
            Me.lblTitle3 = New System.Windows.Forms.Label
            Me.picIo_2_2 = New System.Windows.Forms.PictureBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpSaleDateFr_R = New ubiLease.CommonControls.dtp
            Me.dtpSaleDateTo_R = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtFirmName = New ubiLease.CommonControls.txt
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtOwnerName = New ubiLease.CommonControls.txt
            Me.btnReqSale = New System.Windows.Forms.Button
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpPubDateTo_R = New ubiLease.CommonControls.dtp
            Me.dtpPubDateFr_R = New ubiLease.CommonControls.dtp
            Me.btnSave = New System.Windows.Forms.Button
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            Me.lblRecordState = New System.Windows.Forms.Label
            Me.btnDelRow = New System.Windows.Forms.Button
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.dtpPubYYmm_R = New ubiLease.CommonControls.dtp
            Me.numPubSeq_R = New ubiLease.CommonControls.num
            Me.Label9 = New System.Windows.Forms.Label
            Me.lblCriteria = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria.Size = New System.Drawing.Size(790, 61)
            Me.picCriteria.TabIndex = 48
            Me.picCriteria.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 442)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 194)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 47
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picIo_2_1
            '
            Me.picIo_2_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_1.Location = New System.Drawing.Point(10, 94)
            Me.picIo_2_1.Name = "picIo_2_1"
            Me.picIo_2_1.Size = New System.Drawing.Size(781, 109)
            Me.picIo_2_1.TabIndex = 46
            Me.picIo_2_1.TabStop = False
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
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(10, 238)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(781, 132)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 45
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblPubYYmm
            '
            Me.lblPubYYmm.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPubYYmm.Enabled = False
            Me.lblPubYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblPubYYmm.Location = New System.Drawing.Point(237, 108)
            Me.lblPubYYmm.Name = "lblPubYYmm"
            Me.lblPubYYmm.Size = New System.Drawing.Size(65, 12)
            Me.lblPubYYmm.TabIndex = 1
            Me.lblPubYYmm.Text = "계산서번호"
            Me.lblPubYYmm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPubYYmm
            '
            Me.dtpPubYYmm.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubYYmm.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubYYmm.BorderStyle = 2
            Me.dtpPubYYmm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubYYmm.CaptionName = "계산서발행년월"
            Me.dtpPubYYmm.DateTimeFormatText = "yyyy-MM"
            Me.dtpPubYYmm.Enabled = False
            Me.dtpPubYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubYYmm.Location = New System.Drawing.Point(304, 104)
            Me.dtpPubYYmm.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm.MaxLength = 0
            Me.dtpPubYYmm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm.Name = "dtpPubYYmm"
            Me.dtpPubYYmm.ReadOnlys = False
            Me.dtpPubYYmm.SelectedText = ""
            Me.dtpPubYYmm.SelectionLength = 0
            Me.dtpPubYYmm.SelectionStart = 0
            Me.dtpPubYYmm.Size = New System.Drawing.Size(88, 20)
            Me.dtpPubYYmm.TabIndex = 2
            Me.dtpPubYYmm.Tag = "format(&&&&-&&);"
            Me.dtpPubYYmm.TextAlign = 0
            Me.dtpPubYYmm.TextValue = "[1]dtpPubYYmm"
            Me.dtpPubYYmm.ToolTipText = "계산서발행년월"
            '
            'numPubSeq
            '
            Me.numPubSeq.BackColor = System.Drawing.SystemColors.Window
            Me.numPubSeq.BorderColor = System.Drawing.Color.Empty
            Me.numPubSeq.BorderStyle = 2
            Me.numPubSeq.CaptionName = "발행순번"
            Me.numPubSeq.Enabled = False
            Me.numPubSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numPubSeq.LengthPrecision = 15
            Me.numPubSeq.LengthScale = 0
            Me.numPubSeq.Location = New System.Drawing.Point(398, 104)
            Me.numPubSeq.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPubSeq.MaxLength = 0
            Me.numPubSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPubSeq.Name = "numPubSeq"
            Me.numPubSeq.ReadOnlys = False
            Me.numPubSeq.SelectedText = ""
            Me.numPubSeq.SelectionLength = 0
            Me.numPubSeq.SelectionStart = 1
            Me.numPubSeq.Size = New System.Drawing.Size(55, 20)
            Me.numPubSeq.TabIndex = 4
            Me.numPubSeq.Tag = "read();"
            Me.numPubSeq.TextValue = "0"
            Me.numPubSeq.ToolTipText = "발행순번"
            '
            'lblSaleTypeCd
            '
            Me.lblSaleTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblSaleTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblSaleTypeCd.Location = New System.Drawing.Point(474, 108)
            Me.lblSaleTypeCd.Name = "lblSaleTypeCd"
            Me.lblSaleTypeCd.Size = New System.Drawing.Size(90, 12)
            Me.lblSaleTypeCd.TabIndex = 5
            Me.lblSaleTypeCd.Text = "매출구분코드"
            Me.lblSaleTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd
            '
            Me.cboSaleTypeCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd.ListCount = 0
            Me.cboSaleTypeCd.Location = New System.Drawing.Point(575, 104)
            Me.cboSaleTypeCd.MaxLength = 5
            Me.cboSaleTypeCd.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd.Name = "cboSaleTypeCd"
            Me.cboSaleTypeCd.ReadOnlys = False
            Me.cboSaleTypeCd.Size = New System.Drawing.Size(195, 20)
            Me.cboSaleTypeCd.TabIndex = 6
            Me.cboSaleTypeCd.Tag = "code(판매매출구분);"
            Me.cboSaleTypeCd.TextValue = ""
            '
            'lblPubDate
            '
            Me.lblPubDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPubDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblPubDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblPubDate.Location = New System.Drawing.Point(25, 108)
            Me.lblPubDate.Name = "lblPubDate"
            Me.lblPubDate.Size = New System.Drawing.Size(71, 12)
            Me.lblPubDate.TabIndex = 7
            Me.lblPubDate.Text = "발행일자"
            Me.lblPubDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPubDate
            '
            Me.dtpPubDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubDate.BorderStyle = 2
            Me.dtpPubDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubDate.CaptionName = "발행일자"
            Me.dtpPubDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpPubDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubDate.Location = New System.Drawing.Point(100, 104)
            Me.dtpPubDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDate.MaxLength = 0
            Me.dtpPubDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDate.Name = "dtpPubDate"
            Me.dtpPubDate.ReadOnlys = False
            Me.dtpPubDate.SelectedText = ""
            Me.dtpPubDate.SelectionLength = 0
            Me.dtpPubDate.SelectionStart = 0
            Me.dtpPubDate.Size = New System.Drawing.Size(122, 20)
            Me.dtpPubDate.TabIndex = 8
            Me.dtpPubDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDate.TextAlign = 0
            Me.dtpPubDate.TextValue = "[4]dtpPubDate"
            Me.dtpPubDate.ToolTipText = "발행일자"
            '
            'lblTaxTypeCd
            '
            Me.lblTaxTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblTaxTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTaxTypeCd.Location = New System.Drawing.Point(38, 180)
            Me.lblTaxTypeCd.Name = "lblTaxTypeCd"
            Me.lblTaxTypeCd.Size = New System.Drawing.Size(14, 12)
            Me.lblTaxTypeCd.TabIndex = 9
            Me.lblTaxTypeCd.Text = "계산서구분코드"
            Me.lblTaxTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblTaxTypeCd.Visible = False
            '
            'cboTaxTypeCd
            '
            Me.cboTaxTypeCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboTaxTypeCd.CaptionName = "계산서구분코드"
            Me.cboTaxTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboTaxTypeCd.ListCount = 0
            Me.cboTaxTypeCd.Location = New System.Drawing.Point(56, 179)
            Me.cboTaxTypeCd.MaxLength = 5
            Me.cboTaxTypeCd.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboTaxTypeCd.Name = "cboTaxTypeCd"
            Me.cboTaxTypeCd.ReadOnlys = False
            Me.cboTaxTypeCd.Size = New System.Drawing.Size(24, 20)
            Me.cboTaxTypeCd.TabIndex = 10
            Me.cboTaxTypeCd.Tag = "code();"
            Me.cboTaxTypeCd.TextValue = ""
            Me.cboTaxTypeCd.Visible = False
            '
            'lblSupplyAmt
            '
            Me.lblSupplyAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblSupplyAmt.Enabled = False
            Me.lblSupplyAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSupplyAmt.Location = New System.Drawing.Point(571, 387)
            Me.lblSupplyAmt.Name = "lblSupplyAmt"
            Me.lblSupplyAmt.Size = New System.Drawing.Size(71, 12)
            Me.lblSupplyAmt.TabIndex = 11
            Me.lblSupplyAmt.Text = "공급가액"
            Me.lblSupplyAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numSupplyAmt
            '
            Me.numSupplyAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numSupplyAmt.BorderColor = System.Drawing.Color.Empty
            Me.numSupplyAmt.BorderStyle = 2
            Me.numSupplyAmt.CaptionName = "공급가액"
            Me.numSupplyAmt.Enabled = False
            Me.numSupplyAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numSupplyAmt.LengthPrecision = 15
            Me.numSupplyAmt.LengthScale = 0
            Me.numSupplyAmt.Location = New System.Drawing.Point(646, 383)
            Me.numSupplyAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numSupplyAmt.MaxLength = 19
            Me.numSupplyAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numSupplyAmt.Name = "numSupplyAmt"
            Me.numSupplyAmt.ReadOnlys = False
            Me.numSupplyAmt.SelectedText = ""
            Me.numSupplyAmt.SelectionLength = 0
            Me.numSupplyAmt.SelectionStart = 1
            Me.numSupplyAmt.Size = New System.Drawing.Size(124, 20)
            Me.numSupplyAmt.TabIndex = 12
            Me.numSupplyAmt.Tag = Nothing
            Me.numSupplyAmt.TextValue = "0"
            Me.numSupplyAmt.ToolTipText = "공급가액"
            '
            'chkElectYesOrNo
            '
            Me.chkElectYesOrNo.BackColor = System.Drawing.SystemColors.Window
            Me.chkElectYesOrNo.CaptionName = "전자여부"
            Me.chkElectYesOrNo.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkElectYesOrNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.chkElectYesOrNo.Location = New System.Drawing.Point(484, 158)
            Me.chkElectYesOrNo.Name = "chkElectYesOrNo"
            Me.chkElectYesOrNo.ReadOnlys = False
            Me.chkElectYesOrNo.Size = New System.Drawing.Size(80, 16)
            Me.chkElectYesOrNo.TabIndex = 18
            Me.chkElectYesOrNo.Tag = Nothing
            Me.chkElectYesOrNo.Text = "전자여부"
            Me.chkElectYesOrNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkElectYesOrNo.TextValue = "0"
            Me.chkElectYesOrNo.UseVisualStyleBackColor = False
            '
            'lblASPBizCd
            '
            Me.lblASPBizCd.AutoSize = True
            Me.lblASPBizCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblASPBizCd.Font = New System.Drawing.Font("굴림", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblASPBizCd.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.lblASPBizCd.Location = New System.Drawing.Point(573, 180)
            Me.lblASPBizCd.Name = "lblASPBizCd"
            Me.lblASPBizCd.Size = New System.Drawing.Size(210, 10)
            Me.lblASPBizCd.TabIndex = 19
            Me.lblASPBizCd.Text = "전자계산서일때는 ASP업체를 선택하세요"
            Me.lblASPBizCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popASPBizCd
            '
            Me.popASPBizCd.BorderColor = System.Drawing.Color.Empty
            Me.popASPBizCd.BorderStyle = 2
            Me.popASPBizCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popASPBizCd.CaptionName = "ASP업체코드"
            Me.popASPBizCd.CodeText = "[10] popASPBizCd"
            Me.popASPBizCd.CodeWidth = 50
            Me.popASPBizCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popASPBizCd.Location = New System.Drawing.Point(575, 156)
            Me.popASPBizCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popASPBizCd.MaxLength = 5
            Me.popASPBizCd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popASPBizCd.Name = "popASPBizCd"
            Me.popASPBizCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popASPBizCd.NameText = ""
            Me.popASPBizCd.ReadOnlys = False
            Me.popASPBizCd.SelectedText = ""
            Me.popASPBizCd.SelectionLength = 0
            Me.popASPBizCd.SelectionStart = 0
            Me.popASPBizCd.Size = New System.Drawing.Size(193, 20)
            Me.popASPBizCd.TabIndex = 20
            Me.popASPBizCd.Tag = "code(ASP 업체 명);"
            Me.popASPBizCd.TextAlign = 0
            Me.popASPBizCd.TextValue = "[10] popASPBizCd"
            Me.popASPBizCd.ToolTipText = "ASP업체코드"
            '
            'lblRemark
            '
            Me.lblRemark.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRemark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblRemark.Location = New System.Drawing.Point(29, 161)
            Me.lblRemark.Name = "lblRemark"
            Me.lblRemark.Size = New System.Drawing.Size(65, 10)
            Me.lblRemark.TabIndex = 21
            Me.lblRemark.Text = "적요"
            Me.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRemark
            '
            Me.txtRemark.BackColor = System.Drawing.SystemColors.Window
            Me.txtRemark.BorderColor = System.Drawing.Color.Empty
            Me.txtRemark.BorderStyle = 2
            Me.txtRemark.CaptionName = "적요"
            Me.txtRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtRemark.Location = New System.Drawing.Point(100, 156)
            Me.txtRemark.MaxLength = 200
            Me.txtRemark.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRemark.Multiline = False
            Me.txtRemark.Name = "txtRemark"
            Me.txtRemark.ReadOnlys = False
            Me.txtRemark.SelectedText = ""
            Me.txtRemark.SelectionLength = 0
            Me.txtRemark.SelectionStart = 0
            Me.txtRemark.Size = New System.Drawing.Size(353, 20)
            Me.txtRemark.TabIndex = 22
            Me.txtRemark.Tag = Nothing
            Me.txtRemark.TextAlign = 0
            Me.txtRemark.TextValue = "[11] txtRemark"
            Me.txtRemark.ToolTipText = "적요"
            '
            'lblBizNum
            '
            Me.lblBizNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblBizNum.Enabled = False
            Me.lblBizNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBizNum.Location = New System.Drawing.Point(484, 134)
            Me.lblBizNum.Name = "lblBizNum"
            Me.lblBizNum.Size = New System.Drawing.Size(80, 12)
            Me.lblBizNum.TabIndex = 23
            Me.lblBizNum.Text = "사업자/주민번호"
            Me.lblBizNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBizNum
            '
            Me.txtBizNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtBizNum.BorderColor = System.Drawing.Color.Empty
            Me.txtBizNum.BorderStyle = 2
            Me.txtBizNum.CaptionName = "사업자번호"
            Me.txtBizNum.Enabled = False
            Me.txtBizNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBizNum.Location = New System.Drawing.Point(575, 130)
            Me.txtBizNum.MaxLength = 13
            Me.txtBizNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBizNum.Multiline = False
            Me.txtBizNum.Name = "txtBizNum"
            Me.txtBizNum.ReadOnlys = False
            Me.txtBizNum.SelectedText = ""
            Me.txtBizNum.SelectionLength = 0
            Me.txtBizNum.SelectionStart = 0
            Me.txtBizNum.Size = New System.Drawing.Size(193, 20)
            Me.txtBizNum.TabIndex = 24
            Me.txtBizNum.Tag = Nothing
            Me.txtBizNum.TextAlign = 0
            Me.txtBizNum.TextValue = "[12] txtBizNum"
            Me.txtBizNum.ToolTipText = "사업자번호"
            '
            'lblAccSlipNum
            '
            Me.lblAccSlipNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblAccSlipNum.Enabled = False
            Me.lblAccSlipNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblAccSlipNum.Location = New System.Drawing.Point(222, 184)
            Me.lblAccSlipNum.Name = "lblAccSlipNum"
            Me.lblAccSlipNum.Size = New System.Drawing.Size(80, 12)
            Me.lblAccSlipNum.TabIndex = 35
            Me.lblAccSlipNum.Text = "회계전표번호"
            Me.lblAccSlipNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAccSlipNum
            '
            Me.txtAccSlipNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtAccSlipNum.BorderColor = System.Drawing.Color.Empty
            Me.txtAccSlipNum.BorderStyle = 2
            Me.txtAccSlipNum.CaptionName = "회계전표번호"
            Me.txtAccSlipNum.Enabled = False
            Me.txtAccSlipNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtAccSlipNum.Location = New System.Drawing.Point(304, 180)
            Me.txtAccSlipNum.MaxLength = 30
            Me.txtAccSlipNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAccSlipNum.Multiline = False
            Me.txtAccSlipNum.Name = "txtAccSlipNum"
            Me.txtAccSlipNum.ReadOnlys = False
            Me.txtAccSlipNum.SelectedText = ""
            Me.txtAccSlipNum.SelectionLength = 0
            Me.txtAccSlipNum.SelectionStart = 0
            Me.txtAccSlipNum.Size = New System.Drawing.Size(149, 20)
            Me.txtAccSlipNum.TabIndex = 36
            Me.txtAccSlipNum.Tag = Nothing
            Me.txtAccSlipNum.TextAlign = 0
            Me.txtAccSlipNum.TextValue = "[18] txtAccSlipNum"
            Me.txtAccSlipNum.ToolTipText = "회계전표번호"
            '
            'lblCustomerCode
            '
            Me.lblCustomerCode.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblCustomerCode.Location = New System.Drawing.Point(25, 134)
            Me.lblCustomerCode.Name = "lblCustomerCode"
            Me.lblCustomerCode.Size = New System.Drawing.Size(71, 12)
            Me.lblCustomerCode.TabIndex = 37
            Me.lblCustomerCode.Text = "거래처코드"
            Me.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'chkDelYesOrNo
            '
            Me.chkDelYesOrNo.BackColor = System.Drawing.SystemColors.Window
            Me.chkDelYesOrNo.CaptionName = "삭제여부"
            Me.chkDelYesOrNo.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkDelYesOrNo.Location = New System.Drawing.Point(16, 178)
            Me.chkDelYesOrNo.Name = "chkDelYesOrNo"
            Me.chkDelYesOrNo.ReadOnlys = False
            Me.chkDelYesOrNo.Size = New System.Drawing.Size(13, 14)
            Me.chkDelYesOrNo.TabIndex = 40
            Me.chkDelYesOrNo.Tag = Nothing
            Me.chkDelYesOrNo.Text = "삭제여부"
            Me.chkDelYesOrNo.TextValue = "0"
            Me.chkDelYesOrNo.UseVisualStyleBackColor = False
            Me.chkDelYesOrNo.Visible = False
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(27, 17)
            Me.lblSaleTypeCd_R.Name = "lblSaleTypeCd_R"
            Me.lblSaleTypeCd_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd_R.TabIndex = 43
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(124, 12)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(268, 20)
            Me.cboSaleTypeCd_R.TabIndex = 44
            Me.cboSaleTypeCd_R.Tag = "code(판매매출구분);init(02);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'popCustomerCode
            '
            Me.popCustomerCode.BorderColor = System.Drawing.Color.Empty
            Me.popCustomerCode.BorderStyle = 2
            Me.popCustomerCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCustomerCode.CaptionName = "경리거래처코드"
            Me.popCustomerCode.CausesValidation = False
            Me.popCustomerCode.CodeText = "[1] pop경리거래처코드"
            Me.popCustomerCode.CodeWidth = 70
            Me.popCustomerCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCustomerCode.Location = New System.Drawing.Point(100, 130)
            Me.popCustomerCode.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCustomerCode.MaxLength = 7
            Me.popCustomerCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popCustomerCode.Name = "popCustomerCode"
            Me.popCustomerCode.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCustomerCode.NameText = ""
            Me.popCustomerCode.ReadOnlys = False
            Me.popCustomerCode.SelectedText = ""
            Me.popCustomerCode.SelectionLength = 0
            Me.popCustomerCode.SelectionStart = 0
            Me.popCustomerCode.Size = New System.Drawing.Size(353, 20)
            Me.popCustomerCode.TabIndex = 1568
            Me.popCustomerCode.Tag = "code(경리거래처코드);rtnvalue(txtBizNum,txtFirmName);"
            Me.popCustomerCode.TextAlign = 0
            Me.popCustomerCode.TextValue = "[1] pop경리거래처코드"
            Me.popCustomerCode.ToolTipText = "경리거래처코드"
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.LightGray
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(17, 423)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(124, 12)
            Me.lblTitle1.TabIndex = 1570
            Me.lblTitle1.Text = "<계산서 발행 내역>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(5, 418)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(790, 25)
            Me.picTitle1.TabIndex = 1569
            Me.picTitle1.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 67)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(790, 349)
            Me.PictureBox1.TabIndex = 1571
            Me.PictureBox1.TabStop = False
            '
            'lblTaxNumber
            '
            Me.lblTaxNumber.AutoSize = True
            Me.lblTaxNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTaxNumber.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTaxNumber.Location = New System.Drawing.Point(15, 79)
            Me.lblTaxNumber.Name = "lblTaxNumber"
            Me.lblTaxNumber.Size = New System.Drawing.Size(93, 12)
            Me.lblTaxNumber.TabIndex = 1572
            Me.lblTaxNumber.Text = "<계산서 번호>"
            Me.lblTaxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle3
            '
            Me.lblTitle3.AutoSize = True
            Me.lblTitle3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle3.Location = New System.Drawing.Point(12, 211)
            Me.lblTitle3.Name = "lblTitle3"
            Me.lblTitle3.Size = New System.Drawing.Size(167, 12)
            Me.lblTitle3.TabIndex = 1573
            Me.lblTitle3.Text = "<계산서 상세 / 매출 내역>"
            Me.lblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picIo_2_2
            '
            Me.picIo_2_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_2.Location = New System.Drawing.Point(9, 374)
            Me.picIo_2_2.Name = "picIo_2_2"
            Me.picIo_2_2.Size = New System.Drawing.Size(781, 36)
            Me.picIo_2_2.TabIndex = 1575
            Me.picIo_2_2.TabStop = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(195, 216)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(71, 12)
            Me.Label2.TabIndex = 1576
            Me.Label2.Text = "발행일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.dtpSaleDateFr_R.Location = New System.Drawing.Point(270, 212)
            Me.dtpSaleDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDateFr_R.MaxLength = 0
            Me.dtpSaleDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDateFr_R.Name = "dtpSaleDateFr_R"
            Me.dtpSaleDateFr_R.ReadOnlys = False
            Me.dtpSaleDateFr_R.SelectedText = ""
            Me.dtpSaleDateFr_R.SelectionLength = 0
            Me.dtpSaleDateFr_R.SelectionStart = 0
            Me.dtpSaleDateFr_R.Size = New System.Drawing.Size(102, 20)
            Me.dtpSaleDateFr_R.TabIndex = 1577
            Me.dtpSaleDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDateFr_R.TextAlign = 0
            Me.dtpSaleDateFr_R.TextValue = "[4]dtpSaleDateFr_R"
            Me.dtpSaleDateFr_R.ToolTipText = "발행일자"
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
            Me.dtpSaleDateTo_R.Location = New System.Drawing.Point(390, 212)
            Me.dtpSaleDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDateTo_R.MaxLength = 0
            Me.dtpSaleDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDateTo_R.Name = "dtpSaleDateTo_R"
            Me.dtpSaleDateTo_R.ReadOnlys = False
            Me.dtpSaleDateTo_R.SelectedText = ""
            Me.dtpSaleDateTo_R.SelectionLength = 0
            Me.dtpSaleDateTo_R.SelectionStart = 0
            Me.dtpSaleDateTo_R.Size = New System.Drawing.Size(102, 20)
            Me.dtpSaleDateTo_R.TabIndex = 1578
            Me.dtpSaleDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDateTo_R.TextAlign = 0
            Me.dtpSaleDateTo_R.TextValue = "[4]dtpSaleDateTo_R"
            Me.dtpSaleDateTo_R.ToolTipText = "발행일자"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(376, 216)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(11, 12)
            Me.Label3.TabIndex = 1579
            Me.Label3.Text = "~"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Enabled = False
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.Location = New System.Drawing.Point(33, 387)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(65, 12)
            Me.Label4.TabIndex = 1580
            Me.Label4.Text = "상호"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtFirmName
            '
            Me.txtFirmName.BackColor = System.Drawing.SystemColors.Window
            Me.txtFirmName.BorderColor = System.Drawing.Color.Empty
            Me.txtFirmName.BorderStyle = 2
            Me.txtFirmName.CaptionName = "상호"
            Me.txtFirmName.Enabled = False
            Me.txtFirmName.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtFirmName.Location = New System.Drawing.Point(100, 383)
            Me.txtFirmName.MaxLength = 200
            Me.txtFirmName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtFirmName.Multiline = False
            Me.txtFirmName.Name = "txtFirmName"
            Me.txtFirmName.ReadOnlys = False
            Me.txtFirmName.SelectedText = ""
            Me.txtFirmName.SelectionLength = 0
            Me.txtFirmName.SelectionStart = 0
            Me.txtFirmName.Size = New System.Drawing.Size(220, 20)
            Me.txtFirmName.TabIndex = 1581
            Me.txtFirmName.Tag = Nothing
            Me.txtFirmName.TextAlign = 0
            Me.txtFirmName.TextValue = "[11] txtFirmName"
            Me.txtFirmName.ToolTipText = "상"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Enabled = False
            Me.Label5.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label5.Location = New System.Drawing.Point(325, 387)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(80, 12)
            Me.Label5.TabIndex = 1582
            Me.Label5.Text = "대표자"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtOwnerName
            '
            Me.txtOwnerName.BackColor = System.Drawing.SystemColors.Window
            Me.txtOwnerName.BorderColor = System.Drawing.Color.Empty
            Me.txtOwnerName.BorderStyle = 2
            Me.txtOwnerName.CaptionName = "명대표자"
            Me.txtOwnerName.Enabled = False
            Me.txtOwnerName.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtOwnerName.Location = New System.Drawing.Point(411, 383)
            Me.txtOwnerName.MaxLength = 200
            Me.txtOwnerName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOwnerName.Multiline = False
            Me.txtOwnerName.Name = "txtOwnerName"
            Me.txtOwnerName.ReadOnlys = False
            Me.txtOwnerName.SelectedText = ""
            Me.txtOwnerName.SelectionLength = 0
            Me.txtOwnerName.SelectionStart = 0
            Me.txtOwnerName.Size = New System.Drawing.Size(153, 20)
            Me.txtOwnerName.TabIndex = 1583
            Me.txtOwnerName.Tag = Nothing
            Me.txtOwnerName.TextAlign = 0
            Me.txtOwnerName.TextValue = "[11] txtOwnerName"
            Me.txtOwnerName.ToolTipText = "대표자명"
            '
            'btnReqSale
            '
            Me.btnReqSale.Location = New System.Drawing.Point(499, 207)
            Me.btnReqSale.Name = "btnReqSale"
            Me.btnReqSale.Size = New System.Drawing.Size(121, 28)
            Me.btnReqSale.TabIndex = 1584
            Me.btnReqSale.Text = "매출기초자료 조회"
            Me.btnReqSale.UseVisualStyleBackColor = True
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
            Me.popCustomerCode_R.Location = New System.Drawing.Point(124, 38)
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
            Me.popCustomerCode_R.TabIndex = 1588
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[1] pop경리거래처코드"
            Me.popCustomerCode_R.ToolTipText = "경리거래처코드"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(49, 42)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 12)
            Me.Label1.TabIndex = 1587
            Me.Label1.Text = "거래처코드"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(628, 42)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(11, 12)
            Me.Label6.TabIndex = 1603
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
            Me.dtpPubDateTo_R.Location = New System.Drawing.Point(641, 38)
            Me.dtpPubDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateTo_R.MaxLength = 0
            Me.dtpPubDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateTo_R.Name = "dtpPubDateTo_R"
            Me.dtpPubDateTo_R.ReadOnlys = False
            Me.dtpPubDateTo_R.SelectedText = ""
            Me.dtpPubDateTo_R.SelectionLength = 0
            Me.dtpPubDateTo_R.SelectionStart = 0
            Me.dtpPubDateTo_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateTo_R.TabIndex = 1602
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
            Me.dtpPubDateFr_R.Location = New System.Drawing.Point(522, 38)
            Me.dtpPubDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateFr_R.MaxLength = 0
            Me.dtpPubDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateFr_R.Name = "dtpPubDateFr_R"
            Me.dtpPubDateFr_R.ReadOnlys = False
            Me.dtpPubDateFr_R.SelectedText = ""
            Me.dtpPubDateFr_R.SelectionLength = 0
            Me.dtpPubDateFr_R.SelectionStart = 0
            Me.dtpPubDateFr_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateFr_R.TabIndex = 1601
            Me.dtpPubDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDateFr_R.TextAlign = 0
            Me.dtpPubDateFr_R.TextValue = "[4]dtpPubDate_Fr"
            Me.dtpPubDateFr_R.ToolTipText = "발행일자"
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(630, 207)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(90, 28)
            Me.btnSave.TabIndex = 1604
            Me.btnSave.Text = "계산서 등록"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox2.Location = New System.Drawing.Point(10, 205)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(781, 34)
            Me.PictureBox2.TabIndex = 1605
            Me.PictureBox2.TabStop = False
            '
            'PictureBox3
            '
            Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox3.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox3.Location = New System.Drawing.Point(10, 73)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(781, 23)
            Me.PictureBox3.TabIndex = 1606
            Me.PictureBox3.TabStop = False
            '
            'lblRecordState
            '
            Me.lblRecordState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblRecordState.BackColor = System.Drawing.Color.LightGray
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.lblRecordState.Location = New System.Drawing.Point(699, 80)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 1750
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnDelRow
            '
            Me.btnDelRow.Location = New System.Drawing.Point(726, 207)
            Me.btnDelRow.Name = "btnDelRow"
            Me.btnDelRow.Size = New System.Drawing.Size(57, 28)
            Me.btnDelRow.TabIndex = 1751
            Me.btnDelRow.Text = "행삭제"
            Me.btnDelRow.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.GhostWhite
            Me.Label7.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label7.Location = New System.Drawing.Point(452, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(65, 12)
            Me.Label7.TabIndex = 1842
            Me.Label7.Text = "계산서번호"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.GhostWhite
            Me.Label8.Enabled = False
            Me.Label8.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label8.Location = New System.Drawing.Point(612, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(9, 12)
            Me.Label8.TabIndex = 1840
            Me.Label8.Text = "-"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.dtpPubYYmm_R.Location = New System.Drawing.Point(522, 12)
            Me.dtpPubYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm_R.MaxLength = 0
            Me.dtpPubYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm_R.Name = "dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ReadOnlys = False
            Me.dtpPubYYmm_R.SelectedText = ""
            Me.dtpPubYYmm_R.SelectionLength = 0
            Me.dtpPubYYmm_R.SelectionStart = 0
            Me.dtpPubYYmm_R.Size = New System.Drawing.Size(88, 20)
            Me.dtpPubYYmm_R.TabIndex = 1839
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
            Me.numPubSeq_R.Location = New System.Drawing.Point(624, 12)
            Me.numPubSeq_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPubSeq_R.MaxLength = 0
            Me.numPubSeq_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPubSeq_R.Name = "numPubSeq_R"
            Me.numPubSeq_R.ReadOnlys = False
            Me.numPubSeq_R.SelectedText = ""
            Me.numPubSeq_R.SelectionLength = 0
            Me.numPubSeq_R.SelectionStart = 1
            Me.numPubSeq_R.Size = New System.Drawing.Size(52, 20)
            Me.numPubSeq_R.TabIndex = 1841
            Me.numPubSeq_R.Tag = ""
            Me.numPubSeq_R.TextValue = "0"
            Me.numPubSeq_R.ToolTipText = "발행순번"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.GhostWhite
            Me.Label9.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label9.Location = New System.Drawing.Point(451, 42)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(65, 12)
            Me.Label9.TabIndex = 1843
            Me.Label9.Text = "발행일자"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.LightGray
            Me.lblCriteria.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria.Location = New System.Drawing.Point(148, 424)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria.TabIndex = 1844
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PSB101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblCriteria)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.dtpPubYYmm_R)
            Me.Controls.Add(Me.numPubSeq_R)
            Me.Controls.Add(Me.btnDelRow)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpPubDateTo_R)
            Me.Controls.Add(Me.dtpPubDateFr_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnReqSale)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtOwnerName)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtFirmName)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpSaleDateTo_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpSaleDateFr_R)
            Me.Controls.Add(Me.lblTitle3)
            Me.Controls.Add(Me.lblTaxNumber)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.popCustomerCode)
            Me.Controls.Add(Me.lblPubYYmm)
            Me.Controls.Add(Me.dtpPubYYmm)
            Me.Controls.Add(Me.numPubSeq)
            Me.Controls.Add(Me.lblSaleTypeCd)
            Me.Controls.Add(Me.cboSaleTypeCd)
            Me.Controls.Add(Me.lblPubDate)
            Me.Controls.Add(Me.dtpPubDate)
            Me.Controls.Add(Me.lblTaxTypeCd)
            Me.Controls.Add(Me.cboTaxTypeCd)
            Me.Controls.Add(Me.lblSupplyAmt)
            Me.Controls.Add(Me.numSupplyAmt)
            Me.Controls.Add(Me.chkElectYesOrNo)
            Me.Controls.Add(Me.lblASPBizCd)
            Me.Controls.Add(Me.popASPBizCd)
            Me.Controls.Add(Me.lblRemark)
            Me.Controls.Add(Me.txtRemark)
            Me.Controls.Add(Me.lblBizNum)
            Me.Controls.Add(Me.txtBizNum)
            Me.Controls.Add(Me.lblAccSlipNum)
            Me.Controls.Add(Me.txtAccSlipNum)
            Me.Controls.Add(Me.lblCustomerCode)
            Me.Controls.Add(Me.chkDelYesOrNo)
            Me.Controls.Add(Me.lblSaleTypeCd_R)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.picIo_2_2)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.picIo_2_1)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PSB101"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.PictureBox3, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.picIo_2_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.picIo_2_2, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.chkDelYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode, 0)
            Me.Controls.SetChildIndex(Me.txtAccSlipNum, 0)
            Me.Controls.SetChildIndex(Me.lblAccSlipNum, 0)
            Me.Controls.SetChildIndex(Me.txtBizNum, 0)
            Me.Controls.SetChildIndex(Me.lblBizNum, 0)
            Me.Controls.SetChildIndex(Me.txtRemark, 0)
            Me.Controls.SetChildIndex(Me.lblRemark, 0)
            Me.Controls.SetChildIndex(Me.popASPBizCd, 0)
            Me.Controls.SetChildIndex(Me.lblASPBizCd, 0)
            Me.Controls.SetChildIndex(Me.chkElectYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.numSupplyAmt, 0)
            Me.Controls.SetChildIndex(Me.lblSupplyAmt, 0)
            Me.Controls.SetChildIndex(Me.cboTaxTypeCd, 0)
            Me.Controls.SetChildIndex(Me.lblTaxTypeCd, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDate, 0)
            Me.Controls.SetChildIndex(Me.lblPubDate, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd, 0)
            Me.Controls.SetChildIndex(Me.numPubSeq, 0)
            Me.Controls.SetChildIndex(Me.dtpPubYYmm, 0)
            Me.Controls.SetChildIndex(Me.lblPubYYmm, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTaxNumber, 0)
            Me.Controls.SetChildIndex(Me.lblTitle3, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.txtFirmName, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.txtOwnerName, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.btnReqSale, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.btnSave, 0)
            Me.Controls.SetChildIndex(Me.lblRecordState, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.btnDelRow, 0)
            Me.Controls.SetChildIndex(Me.numPubSeq_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubYYmm_R, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblPubYYmm As System.Windows.Forms.Label
        Friend WithEvents dtpPubYYmm As ubiLease.CommonControls.dtp

        Friend WithEvents numPubSeq As ubiLease.CommonControls.num
        Friend WithEvents lblSaleTypeCd As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblPubDate As System.Windows.Forms.Label
        Friend WithEvents dtpPubDate As ubiLease.CommonControls.dtp
        Friend WithEvents lblTaxTypeCd As System.Windows.Forms.Label
        Friend WithEvents cboTaxTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblSupplyAmt As System.Windows.Forms.Label
        Friend WithEvents numSupplyAmt As ubiLease.CommonControls.num
        Friend WithEvents chkElectYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents lblASPBizCd As System.Windows.Forms.Label
        Friend WithEvents popASPBizCd As ubiLease.CommonControls.pop
        Friend WithEvents lblRemark As System.Windows.Forms.Label
        Friend WithEvents txtRemark As ubiLease.CommonControls.txt
        Friend WithEvents lblBizNum As System.Windows.Forms.Label
        Friend WithEvents txtBizNum As ubiLease.CommonControls.txt
        Friend WithEvents lblAccSlipNum As System.Windows.Forms.Label
        Friend WithEvents txtAccSlipNum As ubiLease.CommonControls.txt
        Friend WithEvents lblCustomerCode As System.Windows.Forms.Label

        Friend WithEvents chkDelYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents lblSaleTypeCd_R As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picIo_2_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents popCustomerCode As ubiLease.CommonControls.pop
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTaxNumber As System.Windows.Forms.Label
        Friend WithEvents lblTitle3 As System.Windows.Forms.Label
        Friend WithEvents picIo_2_2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpSaleDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents dtpSaleDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtFirmName As ubiLease.CommonControls.txt
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtOwnerName As ubiLease.CommonControls.txt
        Friend WithEvents btnReqSale As System.Windows.Forms.Button
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpPubDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents dtpPubDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Friend WithEvents lblRecordState As System.Windows.Forms.Label
        Friend WithEvents btnDelRow As System.Windows.Forms.Button
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dtpPubYYmm_R As ubiLease.CommonControls.dtp
        Friend WithEvents numPubSeq_R As ubiLease.CommonControls.num
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblCriteria As System.Windows.Forms.Label

    End Class 
 
End Namespace 