Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSD101 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSD101))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblReceiptDate = New System.Windows.Forms.Label
            Me.dtpReceiptDate = New ubiLease.CommonControls.dtp
            Me.lblReceiptSeq = New System.Windows.Forms.Label
            Me.txtReceiptSeq = New ubiLease.CommonControls.txt
            Me.lblReceiptType = New System.Windows.Forms.Label
            Me.cboReceiptType = New ubiLease.CommonControls.cbo
            Me.lblCustomerCode = New System.Windows.Forms.Label
            Me.popCustomerCode = New ubiLease.CommonControls.pop
            Me.lblAccountCode = New System.Windows.Forms.Label
            Me.lblManagementNum = New System.Windows.Forms.Label
            Me.txtManagementNum = New ubiLease.CommonControls.txt
            Me.lblReceiptAmt = New System.Windows.Forms.Label
            Me.numReceiptAmt = New ubiLease.CommonControls.num
            Me.lblReceiptFeeAmt = New System.Windows.Forms.Label
            Me.numReceiptFeeAmt = New ubiLease.CommonControls.num
            Me.lblRemark = New System.Windows.Forms.Label
            Me.txtRemark = New ubiLease.CommonControls.txt
            Me.lblAccSlipNum = New System.Windows.Forms.Label
            Me.txtAccSlipNum = New ubiLease.CommonControls.txt
            Me.lblReceiptDate1_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateFr_R = New ubiLease.CommonControls.dtp
            Me.lblReceiptDate2_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo_R = New ubiLease.CommonControls.dtp
            Me.lblTaxNumber = New System.Windows.Forms.Label
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblASPBizCd = New System.Windows.Forms.Label
            Me.lblRecordState = New System.Windows.Forms.Label
            Me.lblCustomerCode_R = New System.Windows.Forms.Label
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.cboRcptAccNumCd = New ubiLease.CommonControls.cbo
            Me.lblSaleTypeCd_R = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
            Me.lblSaleTypeCd = New System.Windows.Forms.Label
            Me.cboSaleTypeCd = New ubiLease.CommonControls.cbo
            Me.lblBillType_R = New System.Windows.Forms.Label
            Me.cboBillType_R = New ubiLease.CommonControls.cbo
            Me.lblBillType = New System.Windows.Forms.Label
            Me.cboBillType = New ubiLease.CommonControls.cbo
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria.Size = New System.Drawing.Size(790, 62)
            Me.picCriteria.TabIndex = 27
            Me.picCriteria.TabStop = False
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(5, 93)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(790, 147)
            Me.picIo_2.TabIndex = 26
            Me.picIo_2.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 264)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 373)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 39
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblReceiptDate
            '
            Me.lblReceiptDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate.Location = New System.Drawing.Point(37, 113)
            Me.lblReceiptDate.Name = "lblReceiptDate"
            Me.lblReceiptDate.Size = New System.Drawing.Size(78, 12)
            Me.lblReceiptDate.TabIndex = 13
            Me.lblReceiptDate.Text = "입금일자"
            Me.lblReceiptDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDate
            '
            Me.dtpReceiptDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDate.BorderStyle = 2
            Me.dtpReceiptDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDate.CaptionName = "입금일자"
            Me.dtpReceiptDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpReceiptDate.Location = New System.Drawing.Point(115, 108)
            Me.dtpReceiptDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDate.MaxLength = 0
            Me.dtpReceiptDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDate.Name = "dtpReceiptDate"
            Me.dtpReceiptDate.ReadOnlys = False
            Me.dtpReceiptDate.SelectedText = ""
            Me.dtpReceiptDate.SelectionLength = 0
            Me.dtpReceiptDate.SelectionStart = 0
            Me.dtpReceiptDate.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDate.TabIndex = 14
            Me.dtpReceiptDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDate.TextAlign = 0
            Me.dtpReceiptDate.TextValue = "[1]dtpReceiptDate"
            Me.dtpReceiptDate.ToolTipText = "입금일자"
            '
            'lblReceiptSeq
            '
            Me.lblReceiptSeq.AutoSize = True
            Me.lblReceiptSeq.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptSeq.Location = New System.Drawing.Point(206, 113)
            Me.lblReceiptSeq.Name = "lblReceiptSeq"
            Me.lblReceiptSeq.Size = New System.Drawing.Size(11, 12)
            Me.lblReceiptSeq.TabIndex = 15
            Me.lblReceiptSeq.Text = "-"
            Me.lblReceiptSeq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReceiptSeq
            '
            Me.txtReceiptSeq.BackColor = System.Drawing.SystemColors.Window
            Me.txtReceiptSeq.BorderColor = System.Drawing.Color.Empty
            Me.txtReceiptSeq.BorderStyle = 2
            Me.txtReceiptSeq.CaptionName = "입금순번"
            Me.txtReceiptSeq.Enabled = False
            Me.txtReceiptSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtReceiptSeq.Location = New System.Drawing.Point(219, 108)
            Me.txtReceiptSeq.MaxLength = 0
            Me.txtReceiptSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReceiptSeq.Multiline = False
            Me.txtReceiptSeq.Name = "txtReceiptSeq"
            Me.txtReceiptSeq.ReadOnlys = False
            Me.txtReceiptSeq.SelectedText = ""
            Me.txtReceiptSeq.SelectionLength = 0
            Me.txtReceiptSeq.SelectionStart = 0
            Me.txtReceiptSeq.Size = New System.Drawing.Size(62, 20)
            Me.txtReceiptSeq.TabIndex = 16
            Me.txtReceiptSeq.Tag = Nothing
            Me.txtReceiptSeq.TextAlign = 2
            Me.txtReceiptSeq.TextValue = "[2] txtReceiptSeq"
            Me.txtReceiptSeq.ToolTipText = "입금순번"
            '
            'lblReceiptType
            '
            Me.lblReceiptType.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptType.Location = New System.Drawing.Point(37, 136)
            Me.lblReceiptType.Name = "lblReceiptType"
            Me.lblReceiptType.Size = New System.Drawing.Size(78, 12)
            Me.lblReceiptType.TabIndex = 19
            Me.lblReceiptType.Text = "입금구분"
            Me.lblReceiptType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboReceiptType
            '
            Me.cboReceiptType.BackColor = System.Drawing.SystemColors.Window
            Me.cboReceiptType.CaptionName = "입금시제코드"
            Me.cboReceiptType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboReceiptType.ListCount = 0
            Me.cboReceiptType.Location = New System.Drawing.Point(115, 132)
            Me.cboReceiptType.MaxLength = 5
            Me.cboReceiptType.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboReceiptType.Name = "cboReceiptType"
            Me.cboReceiptType.ReadOnlys = False
            Me.cboReceiptType.Size = New System.Drawing.Size(166, 20)
            Me.cboReceiptType.TabIndex = 20
            Me.cboReceiptType.Tag = "code(PS입금구분);"
            Me.cboReceiptType.TextValue = ""
            '
            'lblCustomerCode
            '
            Me.lblCustomerCode.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode.Location = New System.Drawing.Point(298, 110)
            Me.lblCustomerCode.Name = "lblCustomerCode"
            Me.lblCustomerCode.Size = New System.Drawing.Size(70, 12)
            Me.lblCustomerCode.TabIndex = 17
            Me.lblCustomerCode.Text = "거래처코드"
            Me.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popCustomerCode
            '
            Me.popCustomerCode.BorderColor = System.Drawing.Color.Empty
            Me.popCustomerCode.BorderStyle = 2
            Me.popCustomerCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCustomerCode.CaptionName = "거래처코드"
            Me.popCustomerCode.CodeText = "[4] popCustomerCode"
            Me.popCustomerCode.CodeWidth = 60
            Me.popCustomerCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCustomerCode.Location = New System.Drawing.Point(371, 105)
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
            Me.popCustomerCode.Size = New System.Drawing.Size(413, 20)
            Me.popCustomerCode.TabIndex = 18
            Me.popCustomerCode.Tag = "code(경리거래처코드);"
            Me.popCustomerCode.TextAlign = 0
            Me.popCustomerCode.TextValue = "[4] popCustomerCode"
            Me.popCustomerCode.ToolTipText = "거래처코드"
            '
            'lblAccountCode
            '
            Me.lblAccountCode.BackColor = System.Drawing.Color.GhostWhite
            Me.lblAccountCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblAccountCode.Location = New System.Drawing.Point(298, 136)
            Me.lblAccountCode.Name = "lblAccountCode"
            Me.lblAccountCode.Size = New System.Drawing.Size(70, 12)
            Me.lblAccountCode.TabIndex = 21
            Me.lblAccountCode.Text = "계좌코드"
            Me.lblAccountCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblManagementNum
            '
            Me.lblManagementNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblManagementNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblManagementNum.Location = New System.Drawing.Point(576, 136)
            Me.lblManagementNum.Name = "lblManagementNum"
            Me.lblManagementNum.Size = New System.Drawing.Size(62, 12)
            Me.lblManagementNum.TabIndex = 23
            Me.lblManagementNum.Text = "어음번호"
            Me.lblManagementNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtManagementNum
            '
            Me.txtManagementNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtManagementNum.BorderColor = System.Drawing.Color.Empty
            Me.txtManagementNum.BorderStyle = 2
            Me.txtManagementNum.CaptionName = "어음번호"
            Me.txtManagementNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtManagementNum.Location = New System.Drawing.Point(641, 132)
            Me.txtManagementNum.MaxLength = 30
            Me.txtManagementNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtManagementNum.Multiline = False
            Me.txtManagementNum.Name = "txtManagementNum"
            Me.txtManagementNum.ReadOnlys = False
            Me.txtManagementNum.SelectedText = ""
            Me.txtManagementNum.SelectionLength = 0
            Me.txtManagementNum.SelectionStart = 0
            Me.txtManagementNum.Size = New System.Drawing.Size(143, 20)
            Me.txtManagementNum.TabIndex = 24
            Me.txtManagementNum.Tag = Nothing
            Me.txtManagementNum.TextAlign = 0
            Me.txtManagementNum.TextValue = "[6] txtManagementNum"
            Me.txtManagementNum.ToolTipText = "어음번호"
            '
            'lblReceiptAmt
            '
            Me.lblReceiptAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptAmt.Location = New System.Drawing.Point(37, 159)
            Me.lblReceiptAmt.Name = "lblReceiptAmt"
            Me.lblReceiptAmt.Size = New System.Drawing.Size(78, 12)
            Me.lblReceiptAmt.TabIndex = 25
            Me.lblReceiptAmt.Text = "입금액"
            Me.lblReceiptAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numReceiptAmt
            '
            Me.numReceiptAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numReceiptAmt.BorderColor = System.Drawing.Color.Empty
            Me.numReceiptAmt.BorderStyle = 2
            Me.numReceiptAmt.CaptionName = "입금액"
            Me.numReceiptAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numReceiptAmt.LengthPrecision = 15
            Me.numReceiptAmt.LengthScale = 0
            Me.numReceiptAmt.Location = New System.Drawing.Point(115, 155)
            Me.numReceiptAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numReceiptAmt.MaxLength = 19
            Me.numReceiptAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numReceiptAmt.Name = "numReceiptAmt"
            Me.numReceiptAmt.ReadOnlys = False
            Me.numReceiptAmt.SelectedText = ""
            Me.numReceiptAmt.SelectionLength = 0
            Me.numReceiptAmt.SelectionStart = 1
            Me.numReceiptAmt.Size = New System.Drawing.Size(166, 20)
            Me.numReceiptAmt.TabIndex = 26
            Me.numReceiptAmt.Tag = Nothing
            Me.numReceiptAmt.TextValue = "0"
            Me.numReceiptAmt.ToolTipText = "입금액"
            '
            'lblReceiptFeeAmt
            '
            Me.lblReceiptFeeAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptFeeAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptFeeAmt.Location = New System.Drawing.Point(298, 159)
            Me.lblReceiptFeeAmt.Name = "lblReceiptFeeAmt"
            Me.lblReceiptFeeAmt.Size = New System.Drawing.Size(70, 12)
            Me.lblReceiptFeeAmt.TabIndex = 27
            Me.lblReceiptFeeAmt.Text = "수수료금액"
            Me.lblReceiptFeeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numReceiptFeeAmt
            '
            Me.numReceiptFeeAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numReceiptFeeAmt.BorderColor = System.Drawing.Color.Empty
            Me.numReceiptFeeAmt.BorderStyle = 2
            Me.numReceiptFeeAmt.CaptionName = "수수료금액"
            Me.numReceiptFeeAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numReceiptFeeAmt.LengthPrecision = 15
            Me.numReceiptFeeAmt.LengthScale = 0
            Me.numReceiptFeeAmt.Location = New System.Drawing.Point(371, 155)
            Me.numReceiptFeeAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numReceiptFeeAmt.MaxLength = 19
            Me.numReceiptFeeAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numReceiptFeeAmt.Name = "numReceiptFeeAmt"
            Me.numReceiptFeeAmt.ReadOnlys = False
            Me.numReceiptFeeAmt.SelectedText = ""
            Me.numReceiptFeeAmt.SelectionLength = 0
            Me.numReceiptFeeAmt.SelectionStart = 1
            Me.numReceiptFeeAmt.Size = New System.Drawing.Size(166, 20)
            Me.numReceiptFeeAmt.TabIndex = 28
            Me.numReceiptFeeAmt.Tag = Nothing
            Me.numReceiptFeeAmt.TextValue = "0"
            Me.numReceiptFeeAmt.ToolTipText = "수수료금액"
            '
            'lblRemark
            '
            Me.lblRemark.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRemark.Location = New System.Drawing.Point(37, 212)
            Me.lblRemark.Name = "lblRemark"
            Me.lblRemark.Size = New System.Drawing.Size(78, 12)
            Me.lblRemark.TabIndex = 34
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
            Me.txtRemark.Location = New System.Drawing.Point(115, 208)
            Me.txtRemark.MaxLength = 200
            Me.txtRemark.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRemark.Multiline = False
            Me.txtRemark.Name = "txtRemark"
            Me.txtRemark.ReadOnlys = False
            Me.txtRemark.SelectedText = ""
            Me.txtRemark.SelectionLength = 0
            Me.txtRemark.SelectionStart = 0
            Me.txtRemark.Size = New System.Drawing.Size(429, 20)
            Me.txtRemark.TabIndex = 35
            Me.txtRemark.Tag = Nothing
            Me.txtRemark.TextAlign = 0
            Me.txtRemark.TextValue = "[9] txtRemark"
            Me.txtRemark.ToolTipText = "적요"
            '
            'lblAccSlipNum
            '
            Me.lblAccSlipNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblAccSlipNum.Enabled = False
            Me.lblAccSlipNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblAccSlipNum.Location = New System.Drawing.Point(554, 212)
            Me.lblAccSlipNum.Name = "lblAccSlipNum"
            Me.lblAccSlipNum.Size = New System.Drawing.Size(84, 12)
            Me.lblAccSlipNum.TabIndex = 36
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
            Me.txtAccSlipNum.Location = New System.Drawing.Point(641, 208)
            Me.txtAccSlipNum.MaxLength = 30
            Me.txtAccSlipNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAccSlipNum.Multiline = False
            Me.txtAccSlipNum.Name = "txtAccSlipNum"
            Me.txtAccSlipNum.ReadOnlys = False
            Me.txtAccSlipNum.SelectedText = ""
            Me.txtAccSlipNum.SelectionLength = 0
            Me.txtAccSlipNum.SelectionStart = 0
            Me.txtAccSlipNum.Size = New System.Drawing.Size(143, 20)
            Me.txtAccSlipNum.TabIndex = 37
            Me.txtAccSlipNum.Tag = Nothing
            Me.txtAccSlipNum.TextAlign = 0
            Me.txtAccSlipNum.TextValue = "[10] txtAccSlipNum"
            Me.txtAccSlipNum.ToolTipText = "회계전표번호"
            '
            'lblReceiptDate1_R
            '
            Me.lblReceiptDate1_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReceiptDate1_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate1_R.Location = New System.Drawing.Point(18, 45)
            Me.lblReceiptDate1_R.Name = "lblReceiptDate1_R"
            Me.lblReceiptDate1_R.Size = New System.Drawing.Size(95, 12)
            Me.lblReceiptDate1_R.TabIndex = 5
            Me.lblReceiptDate1_R.Text = "입금일자"
            Me.lblReceiptDate1_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDateFr_R
            '
            Me.dtpReceiptDateFr_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateFr_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateFr_R.BorderStyle = 2
            Me.dtpReceiptDateFr_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateFr_R.CaptionName = "입금시작일자"
            Me.dtpReceiptDateFr_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpReceiptDateFr_R.Location = New System.Drawing.Point(115, 40)
            Me.dtpReceiptDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFr_R.MaxLength = 0
            Me.dtpReceiptDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFr_R.Name = "dtpReceiptDateFr_R"
            Me.dtpReceiptDateFr_R.ReadOnlys = False
            Me.dtpReceiptDateFr_R.SelectedText = ""
            Me.dtpReceiptDateFr_R.SelectionLength = 0
            Me.dtpReceiptDateFr_R.SelectionStart = 0
            Me.dtpReceiptDateFr_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateFr_R.TabIndex = 6
            Me.dtpReceiptDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateFr_R.TextAlign = 0
            Me.dtpReceiptDateFr_R.TextValue = "[1]dtpReceiptDate1_R"
            Me.dtpReceiptDateFr_R.ToolTipText = "입금시작일자"
            '
            'lblReceiptDate2_R
            '
            Me.lblReceiptDate2_R.AutoSize = True
            Me.lblReceiptDate2_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReceiptDate2_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate2_R.Location = New System.Drawing.Point(210, 45)
            Me.lblReceiptDate2_R.Name = "lblReceiptDate2_R"
            Me.lblReceiptDate2_R.Size = New System.Drawing.Size(11, 12)
            Me.lblReceiptDate2_R.TabIndex = 7
            Me.lblReceiptDate2_R.Text = "-"
            Me.lblReceiptDate2_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDateTo_R
            '
            Me.dtpReceiptDateTo_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateTo_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateTo_R.BorderStyle = 2
            Me.dtpReceiptDateTo_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateTo_R.CaptionName = "입금종료일자"
            Me.dtpReceiptDateTo_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateTo_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpReceiptDateTo_R.Location = New System.Drawing.Point(227, 40)
            Me.dtpReceiptDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo_R.MaxLength = 0
            Me.dtpReceiptDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo_R.Name = "dtpReceiptDateTo_R"
            Me.dtpReceiptDateTo_R.ReadOnlys = False
            Me.dtpReceiptDateTo_R.SelectedText = ""
            Me.dtpReceiptDateTo_R.SelectionLength = 0
            Me.dtpReceiptDateTo_R.SelectionStart = 0
            Me.dtpReceiptDateTo_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateTo_R.TabIndex = 8
            Me.dtpReceiptDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo_R.TextAlign = 0
            Me.dtpReceiptDateTo_R.TextValue = "[2]dtpReceiptDate2_R"
            Me.dtpReceiptDateTo_R.ToolTipText = "입금종료일자"
            '
            'lblTaxNumber
            '
            Me.lblTaxNumber.AutoSize = True
            Me.lblTaxNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTaxNumber.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTaxNumber.Location = New System.Drawing.Point(15, 249)
            Me.lblTaxNumber.Name = "lblTaxNumber"
            Me.lblTaxNumber.Size = New System.Drawing.Size(111, 12)
            Me.lblTaxNumber.TabIndex = 38
            Me.lblTaxNumber.Text = "<업체 입금 목록>"
            Me.lblTaxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox3
            '
            Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox3.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox3.Location = New System.Drawing.Point(5, 243)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(790, 23)
            Me.PictureBox3.TabIndex = 1608
            Me.PictureBox3.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(11, 76)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(111, 12)
            Me.Label1.TabIndex = 11
            Me.Label1.Text = "<입금 상세 내역>"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox1.Location = New System.Drawing.Point(5, 70)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(790, 24)
            Me.PictureBox1.TabIndex = 1610
            Me.PictureBox1.TabStop = False
            '
            'lblASPBizCd
            '
            Me.lblASPBizCd.AutoSize = True
            Me.lblASPBizCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblASPBizCd.Font = New System.Drawing.Font("굴림", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblASPBizCd.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.lblASPBizCd.Location = New System.Drawing.Point(116, 179)
            Me.lblASPBizCd.Name = "lblASPBizCd"
            Me.lblASPBizCd.Size = New System.Drawing.Size(219, 10)
            Me.lblASPBizCd.TabIndex = 31
            Me.lblASPBizCd.Text = "입금액은 수수료금액을 포함한 금액입니다."
            Me.lblASPBizCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblRecordState
            '
            Me.lblRecordState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblRecordState.BackColor = System.Drawing.Color.LightGray
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.lblRecordState.Location = New System.Drawing.Point(713, 77)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 12
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCustomerCode_R
            '
            Me.lblCustomerCode_R.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode_R.Location = New System.Drawing.Point(378, 19)
            Me.lblCustomerCode_R.Name = "lblCustomerCode_R"
            Me.lblCustomerCode_R.Size = New System.Drawing.Size(70, 12)
            Me.lblCustomerCode_R.TabIndex = 2
            Me.lblCustomerCode_R.Text = "거래처코드"
            Me.lblCustomerCode_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popCustomerCode_R
            '
            Me.popCustomerCode_R.BorderColor = System.Drawing.Color.Empty
            Me.popCustomerCode_R.BorderStyle = 2
            Me.popCustomerCode_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCustomerCode_R.CaptionName = "거래처코드"
            Me.popCustomerCode_R.CodeText = "[4] popCustomerCode"
            Me.popCustomerCode_R.CodeWidth = 60
            Me.popCustomerCode_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCustomerCode_R.Location = New System.Drawing.Point(448, 15)
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
            Me.popCustomerCode_R.Size = New System.Drawing.Size(317, 20)
            Me.popCustomerCode_R.TabIndex = 4
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[4] popCustomerCode"
            Me.popCustomerCode_R.ToolTipText = "거래처코드"
            '
            'cboRcptAccNumCd
            '
            Me.cboRcptAccNumCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboRcptAccNumCd.CaptionName = "계좌코드"
            Me.cboRcptAccNumCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboRcptAccNumCd.ListCount = 0
            Me.cboRcptAccNumCd.Location = New System.Drawing.Point(371, 132)
            Me.cboRcptAccNumCd.MaxLength = 5
            Me.cboRcptAccNumCd.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboRcptAccNumCd.Name = "cboRcptAccNumCd"
            Me.cboRcptAccNumCd.ReadOnlys = False
            Me.cboRcptAccNumCd.Size = New System.Drawing.Size(198, 20)
            Me.cboRcptAccNumCd.TabIndex = 22
            Me.cboRcptAccNumCd.Tag = "code(입금계좌코드| );"
            Me.cboRcptAccNumCd.Text = "cboRcptAccNumCd"
            Me.cboRcptAccNumCd.TextValue = ""
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(18, 19)
            Me.lblSaleTypeCd_R.Name = "lblSaleTypeCd_R"
            Me.lblSaleTypeCd_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd_R.TabIndex = 0
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(115, 15)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(204, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1
            Me.cboSaleTypeCd_R.Tag = "code(업체매출구분|전체);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'lblSaleTypeCd
            '
            Me.lblSaleTypeCd.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd.Location = New System.Drawing.Point(543, 159)
            Me.lblSaleTypeCd.Name = "lblSaleTypeCd"
            Me.lblSaleTypeCd.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd.TabIndex = 29
            Me.lblSaleTypeCd.Text = "매출구분코드"
            Me.lblSaleTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd
            '
            Me.cboSaleTypeCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd.ListCount = 0
            Me.cboSaleTypeCd.Location = New System.Drawing.Point(641, 155)
            Me.cboSaleTypeCd.MaxLength = 5
            Me.cboSaleTypeCd.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd.Name = "cboSaleTypeCd"
            Me.cboSaleTypeCd.ReadOnlys = False
            Me.cboSaleTypeCd.Size = New System.Drawing.Size(143, 20)
            Me.cboSaleTypeCd.TabIndex = 30
            Me.cboSaleTypeCd.Tag = "code(업체매출구분| );"
            Me.cboSaleTypeCd.TextValue = ""
            '
            'lblBillType_R
            '
            Me.lblBillType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBillType_R.Location = New System.Drawing.Point(369, 41)
            Me.lblBillType_R.Name = "lblBillType_R"
            Me.lblBillType_R.Size = New System.Drawing.Size(73, 12)
            Me.lblBillType_R.TabIndex = 9
            Me.lblBillType_R.Text = "청구 유형"
            Me.lblBillType_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBillType_R
            '
            Me.cboBillType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboBillType_R.CaptionName = "청구유형명"
            Me.cboBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBillType_R.ListCount = 0
            Me.cboBillType_R.Location = New System.Drawing.Point(448, 37)
            Me.cboBillType_R.MaxLength = 5
            Me.cboBillType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboBillType_R.Name = "cboBillType_R"
            Me.cboBillType_R.ReadOnlys = False
            Me.cboBillType_R.Size = New System.Drawing.Size(190, 20)
            Me.cboBillType_R.TabIndex = 10
            Me.cboBillType_R.Tag = "code(청구유형명|전체);"
            Me.cboBillType_R.TextValue = ""
            '
            'lblBillType
            '
            Me.lblBillType.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBillType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBillType.Location = New System.Drawing.Point(565, 186)
            Me.lblBillType.Name = "lblBillType"
            Me.lblBillType.Size = New System.Drawing.Size(73, 12)
            Me.lblBillType.TabIndex = 32
            Me.lblBillType.Text = "청구 유형"
            Me.lblBillType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBillType
            '
            Me.cboBillType.BackColor = System.Drawing.SystemColors.Window
            Me.cboBillType.CaptionName = "청구유형명"
            Me.cboBillType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBillType.ListCount = 0
            Me.cboBillType.Location = New System.Drawing.Point(641, 182)
            Me.cboBillType.MaxLength = 5
            Me.cboBillType.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboBillType.Name = "cboBillType"
            Me.cboBillType.ReadOnlys = False
            Me.cboBillType.Size = New System.Drawing.Size(143, 20)
            Me.cboBillType.TabIndex = 33
            Me.cboBillType.Tag = "code(청구유형명|선택하세요);"
            Me.cboBillType.TextValue = ""
            '
            'PSD101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblBillType)
            Me.Controls.Add(Me.cboBillType)
            Me.Controls.Add(Me.lblBillType_R)
            Me.Controls.Add(Me.cboBillType_R)
            Me.Controls.Add(Me.lblSaleTypeCd)
            Me.Controls.Add(Me.cboSaleTypeCd)
            Me.Controls.Add(Me.lblSaleTypeCd_R)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.cboRcptAccNumCd)
            Me.Controls.Add(Me.lblCustomerCode_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblASPBizCd)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblTaxNumber)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.lblReceiptDate)
            Me.Controls.Add(Me.dtpReceiptDate)
            Me.Controls.Add(Me.lblReceiptSeq)
            Me.Controls.Add(Me.txtReceiptSeq)
            Me.Controls.Add(Me.lblReceiptType)
            Me.Controls.Add(Me.cboReceiptType)
            Me.Controls.Add(Me.lblCustomerCode)
            Me.Controls.Add(Me.popCustomerCode)
            Me.Controls.Add(Me.lblAccountCode)
            Me.Controls.Add(Me.lblManagementNum)
            Me.Controls.Add(Me.txtManagementNum)
            Me.Controls.Add(Me.lblReceiptAmt)
            Me.Controls.Add(Me.numReceiptAmt)
            Me.Controls.Add(Me.lblReceiptFeeAmt)
            Me.Controls.Add(Me.numReceiptFeeAmt)
            Me.Controls.Add(Me.lblRemark)
            Me.Controls.Add(Me.txtRemark)
            Me.Controls.Add(Me.lblAccSlipNum)
            Me.Controls.Add(Me.txtAccSlipNum)
            Me.Controls.Add(Me.lblReceiptDate1_R)
            Me.Controls.Add(Me.dtpReceiptDateFr_R)
            Me.Controls.Add(Me.lblReceiptDate2_R)
            Me.Controls.Add(Me.dtpReceiptDateTo_R)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PSD101"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.picIo_2, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate2_R, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate1_R, 0)
            Me.Controls.SetChildIndex(Me.txtAccSlipNum, 0)
            Me.Controls.SetChildIndex(Me.lblAccSlipNum, 0)
            Me.Controls.SetChildIndex(Me.txtRemark, 0)
            Me.Controls.SetChildIndex(Me.lblRemark, 0)
            Me.Controls.SetChildIndex(Me.numReceiptFeeAmt, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptFeeAmt, 0)
            Me.Controls.SetChildIndex(Me.numReceiptAmt, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptAmt, 0)
            Me.Controls.SetChildIndex(Me.txtManagementNum, 0)
            Me.Controls.SetChildIndex(Me.lblManagementNum, 0)
            Me.Controls.SetChildIndex(Me.lblAccountCode, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode, 0)
            Me.Controls.SetChildIndex(Me.cboReceiptType, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptType, 0)
            Me.Controls.SetChildIndex(Me.txtReceiptSeq, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptSeq, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDate, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate, 0)
            Me.Controls.SetChildIndex(Me.PictureBox3, 0)
            Me.Controls.SetChildIndex(Me.lblTaxNumber, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.lblASPBizCd, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblRecordState, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.cboRcptAccNumCd, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd, 0)
            Me.Controls.SetChildIndex(Me.cboBillType_R, 0)
            Me.Controls.SetChildIndex(Me.lblBillType_R, 0)
            Me.Controls.SetChildIndex(Me.cboBillType, 0)
            Me.Controls.SetChildIndex(Me.lblBillType, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblReceiptDate As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDate As ubiLease.CommonControls.dtp
        Friend WithEvents lblReceiptSeq As System.Windows.Forms.Label
        Friend WithEvents txtReceiptSeq As ubiLease.CommonControls.txt
        Friend WithEvents lblReceiptType As System.Windows.Forms.Label
        Friend WithEvents cboReceiptType As ubiLease.CommonControls.cbo
        Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
        Friend WithEvents popCustomerCode As ubiLease.CommonControls.pop
        Friend WithEvents lblAccountCode As System.Windows.Forms.Label
        Friend WithEvents lblManagementNum As System.Windows.Forms.Label
        Friend WithEvents txtManagementNum As ubiLease.CommonControls.txt
        Friend WithEvents lblReceiptAmt As System.Windows.Forms.Label
        Friend WithEvents numReceiptAmt As ubiLease.CommonControls.num
        Friend WithEvents lblReceiptFeeAmt As System.Windows.Forms.Label
        Friend WithEvents numReceiptFeeAmt As ubiLease.CommonControls.num
        Friend WithEvents lblRemark As System.Windows.Forms.Label
        Friend WithEvents txtRemark As ubiLease.CommonControls.txt
        Friend WithEvents lblAccSlipNum As System.Windows.Forms.Label
        Friend WithEvents txtAccSlipNum As ubiLease.CommonControls.txt
        Friend WithEvents lblReceiptDate1_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblReceiptDate2_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblTaxNumber As System.Windows.Forms.Label
        Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblASPBizCd As System.Windows.Forms.Label
        Friend WithEvents lblRecordState As System.Windows.Forms.Label
        Friend WithEvents lblCustomerCode_R As System.Windows.Forms.Label
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents cboRcptAccNumCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblSaleTypeCd_R As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents lblSaleTypeCd As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblBillType_R As System.Windows.Forms.Label
        Friend WithEvents cboBillType_R As ubiLease.CommonControls.cbo
        Friend WithEvents lblBillType As System.Windows.Forms.Label
        Friend WithEvents cboBillType As ubiLease.CommonControls.cbo
 
    End Class 
 
End Namespace 