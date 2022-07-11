Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSD104 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSD104))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picIo_3 = New System.Windows.Forms.PictureBox
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.lblEpReceiptDate = New System.Windows.Forms.Label
            Me.dtpEpReceiptDate = New ubiLease.CommonControls.dtp
            Me.lblEpReceiptSeq = New System.Windows.Forms.Label
            Me.txtEpReceiptSeq = New ubiLease.CommonControls.txt
            Me.lblPubYYmm = New System.Windows.Forms.Label
            Me.lblPubSeq = New System.Windows.Forms.Label
            Me.txtPubSeq = New ubiLease.CommonControls.txt
            Me.lblReceiptDate = New System.Windows.Forms.Label
            Me.dtpReceiptDate = New ubiLease.CommonControls.dtp
            Me.lblReceiptSeq = New System.Windows.Forms.Label
            Me.txtReceiptSeq = New ubiLease.CommonControls.txt
            Me.lblEpReceiptAmt = New System.Windows.Forms.Label
            Me.numEpReceiptAmt = New ubiLease.CommonControls.num
            Me.lblRemark = New System.Windows.Forms.Label
            Me.txtRemark = New ubiLease.CommonControls.txt
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblTitle3 = New System.Windows.Forms.Label
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            Me.popTaxNumber = New ubiLease.CommonControls.pop
            Me.lblTaxNumber = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpPubYYmm = New ubiLease.CommonControls.dtp
            Me.lblRecordState = New System.Windows.Forms.Label
            Me.popCustomerCode = New ubiLease.CommonControls.pop
            Me.lblCustomerCode = New System.Windows.Forms.Label
            Me.cboRcptAccNumCd = New ubiLease.CommonControls.cbo
            Me.lblAccountCode = New System.Windows.Forms.Label
            Me.lblManagementNum = New System.Windows.Forms.Label
            Me.txtManagementNum = New ubiLease.CommonControls.txt
            Me.lblReceiptAmt = New System.Windows.Forms.Label
            Me.numReceiptAmt = New ubiLease.CommonControls.num
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtRcRemark = New ubiLease.CommonControls.txt
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.numRtnValue1 = New ubiLease.CommonControls.num
            Me.numRtnValue2 = New ubiLease.CommonControls.num
            Me.lblCriteria = New System.Windows.Forms.Label
            Me.lblCriteria_2 = New System.Windows.Forms.Label
            Me.lblSaleTypeCd_R = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
            Me.Label1 = New System.Windows.Forms.Label
            Me.popReceiptNumber_R = New ubiLease.CommonControls.pop
            Me.lblCustomerCode_R = New System.Windows.Forms.Label
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.lblReceiptDate1_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateFr_R = New ubiLease.CommonControls.dtp
            Me.lblReceiptDate2_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo_R = New ubiLease.CommonControls.dtp
            Me.lblBillType_R = New System.Windows.Forms.Label
            Me.cboBillType_R = New ubiLease.CommonControls.cbo
            Me.cboBillType = New ubiLease.CommonControls.cbo
            Me.Label3 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(5, 89)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 176)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 15
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picIo_3
            '
            Me.picIo_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_3.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_3.Location = New System.Drawing.Point(4, 292)
            Me.picIo_3.Name = "picIo_3"
            Me.picIo_3.Size = New System.Drawing.Size(793, 126)
            Me.picIo_3.TabIndex = 24
            Me.picIo_3.TabStop = False
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_2.Location = New System.Drawing.Point(2, 441)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(793, 196)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 0
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblEpReceiptDate
            '
            Me.lblEpReceiptDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblEpReceiptDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEpReceiptDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblEpReceiptDate.Location = New System.Drawing.Point(52, 304)
            Me.lblEpReceiptDate.Name = "lblEpReceiptDate"
            Me.lblEpReceiptDate.Size = New System.Drawing.Size(76, 12)
            Me.lblEpReceiptDate.TabIndex = 22
            Me.lblEpReceiptDate.Text = "수납일자"
            Me.lblEpReceiptDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpEpReceiptDate
            '
            Me.dtpEpReceiptDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpEpReceiptDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpEpReceiptDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpEpReceiptDate.BorderStyle = 2
            Me.dtpEpReceiptDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpEpReceiptDate.CaptionName = "수납일자"
            Me.dtpEpReceiptDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpEpReceiptDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpEpReceiptDate.Location = New System.Drawing.Point(136, 300)
            Me.dtpEpReceiptDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpEpReceiptDate.MaxLength = 0
            Me.dtpEpReceiptDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpEpReceiptDate.Name = "dtpEpReceiptDate"
            Me.dtpEpReceiptDate.ReadOnlys = False
            Me.dtpEpReceiptDate.SelectedText = ""
            Me.dtpEpReceiptDate.SelectionLength = 0
            Me.dtpEpReceiptDate.SelectionStart = 0
            Me.dtpEpReceiptDate.Size = New System.Drawing.Size(96, 20)
            Me.dtpEpReceiptDate.TabIndex = 23
            Me.dtpEpReceiptDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpEpReceiptDate.TextAlign = 0
            Me.dtpEpReceiptDate.TextValue = "[1]dtpEpReceiptDate"
            Me.dtpEpReceiptDate.ToolTipText = "수납일자"
            '
            'lblEpReceiptSeq
            '
            Me.lblEpReceiptSeq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblEpReceiptSeq.AutoSize = True
            Me.lblEpReceiptSeq.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEpReceiptSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblEpReceiptSeq.Location = New System.Drawing.Point(235, 304)
            Me.lblEpReceiptSeq.Name = "lblEpReceiptSeq"
            Me.lblEpReceiptSeq.Size = New System.Drawing.Size(11, 12)
            Me.lblEpReceiptSeq.TabIndex = 24
            Me.lblEpReceiptSeq.Text = "-"
            Me.lblEpReceiptSeq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtEpReceiptSeq
            '
            Me.txtEpReceiptSeq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtEpReceiptSeq.BackColor = System.Drawing.SystemColors.Window
            Me.txtEpReceiptSeq.BorderColor = System.Drawing.Color.Empty
            Me.txtEpReceiptSeq.BorderStyle = 2
            Me.txtEpReceiptSeq.CaptionName = "수납순번"
            Me.txtEpReceiptSeq.Enabled = False
            Me.txtEpReceiptSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtEpReceiptSeq.Location = New System.Drawing.Point(250, 300)
            Me.txtEpReceiptSeq.MaxLength = 0
            Me.txtEpReceiptSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtEpReceiptSeq.Multiline = False
            Me.txtEpReceiptSeq.Name = "txtEpReceiptSeq"
            Me.txtEpReceiptSeq.ReadOnlys = False
            Me.txtEpReceiptSeq.SelectedText = ""
            Me.txtEpReceiptSeq.SelectionLength = 0
            Me.txtEpReceiptSeq.SelectionStart = 0
            Me.txtEpReceiptSeq.Size = New System.Drawing.Size(52, 20)
            Me.txtEpReceiptSeq.TabIndex = 25
            Me.txtEpReceiptSeq.Tag = Nothing
            Me.txtEpReceiptSeq.TextAlign = 2
            Me.txtEpReceiptSeq.TextValue = "[2] txtEpReceiptSeq"
            Me.txtEpReceiptSeq.ToolTipText = "수납순번"
            '
            'lblPubYYmm
            '
            Me.lblPubYYmm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblPubYYmm.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPubYYmm.Enabled = False
            Me.lblPubYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblPubYYmm.Location = New System.Drawing.Point(320, 304)
            Me.lblPubYYmm.Name = "lblPubYYmm"
            Me.lblPubYYmm.Size = New System.Drawing.Size(19, 12)
            Me.lblPubYYmm.TabIndex = 26
            Me.lblPubYYmm.Text = "계산서번호"
            Me.lblPubYYmm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblPubYYmm.Visible = False
            '
            'lblPubSeq
            '
            Me.lblPubSeq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblPubSeq.AutoSize = True
            Me.lblPubSeq.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPubSeq.Enabled = False
            Me.lblPubSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblPubSeq.Location = New System.Drawing.Point(374, 304)
            Me.lblPubSeq.Name = "lblPubSeq"
            Me.lblPubSeq.Size = New System.Drawing.Size(11, 12)
            Me.lblPubSeq.TabIndex = 28
            Me.lblPubSeq.Text = "-"
            Me.lblPubSeq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblPubSeq.Visible = False
            '
            'txtPubSeq
            '
            Me.txtPubSeq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtPubSeq.BackColor = System.Drawing.SystemColors.Window
            Me.txtPubSeq.BorderColor = System.Drawing.Color.Empty
            Me.txtPubSeq.BorderStyle = 2
            Me.txtPubSeq.CaptionName = "발행순번"
            Me.txtPubSeq.Enabled = False
            Me.txtPubSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtPubSeq.Location = New System.Drawing.Point(388, 300)
            Me.txtPubSeq.MaxLength = 0
            Me.txtPubSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPubSeq.Multiline = False
            Me.txtPubSeq.Name = "txtPubSeq"
            Me.txtPubSeq.ReadOnlys = False
            Me.txtPubSeq.SelectedText = ""
            Me.txtPubSeq.SelectionLength = 0
            Me.txtPubSeq.SelectionStart = 0
            Me.txtPubSeq.Size = New System.Drawing.Size(35, 20)
            Me.txtPubSeq.TabIndex = 29
            Me.txtPubSeq.Tag = Nothing
            Me.txtPubSeq.TextAlign = 2
            Me.txtPubSeq.TextValue = "[4] txtPubSeq"
            Me.txtPubSeq.ToolTipText = "발행순번"
            Me.txtPubSeq.Visible = False
            '
            'lblReceiptDate
            '
            Me.lblReceiptDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblReceiptDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate.Location = New System.Drawing.Point(423, 275)
            Me.lblReceiptDate.Name = "lblReceiptDate"
            Me.lblReceiptDate.Size = New System.Drawing.Size(76, 12)
            Me.lblReceiptDate.TabIndex = 17
            Me.lblReceiptDate.Text = "입금번호"
            Me.lblReceiptDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDate
            '
            Me.dtpReceiptDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpReceiptDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDate.BorderStyle = 2
            Me.dtpReceiptDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDate.CaptionName = "입금일자"
            Me.dtpReceiptDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDate.Enabled = False
            Me.dtpReceiptDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpReceiptDate.Location = New System.Drawing.Point(506, 271)
            Me.dtpReceiptDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDate.MaxLength = 0
            Me.dtpReceiptDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDate.Name = "dtpReceiptDate"
            Me.dtpReceiptDate.ReadOnlys = False
            Me.dtpReceiptDate.SelectedText = ""
            Me.dtpReceiptDate.SelectionLength = 0
            Me.dtpReceiptDate.SelectionStart = 0
            Me.dtpReceiptDate.Size = New System.Drawing.Size(103, 20)
            Me.dtpReceiptDate.TabIndex = 18
            Me.dtpReceiptDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDate.TextAlign = 0
            Me.dtpReceiptDate.TextValue = "[5]dtpReceiptDate"
            Me.dtpReceiptDate.ToolTipText = "입금일자"
            '
            'lblReceiptSeq
            '
            Me.lblReceiptSeq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblReceiptSeq.AutoSize = True
            Me.lblReceiptSeq.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptSeq.Location = New System.Drawing.Point(615, 275)
            Me.lblReceiptSeq.Name = "lblReceiptSeq"
            Me.lblReceiptSeq.Size = New System.Drawing.Size(11, 12)
            Me.lblReceiptSeq.TabIndex = 19
            Me.lblReceiptSeq.Text = "-"
            Me.lblReceiptSeq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtReceiptSeq
            '
            Me.txtReceiptSeq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtReceiptSeq.BackColor = System.Drawing.SystemColors.Window
            Me.txtReceiptSeq.BorderColor = System.Drawing.Color.Empty
            Me.txtReceiptSeq.BorderStyle = 2
            Me.txtReceiptSeq.CaptionName = "입금순번"
            Me.txtReceiptSeq.Enabled = False
            Me.txtReceiptSeq.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtReceiptSeq.Location = New System.Drawing.Point(635, 271)
            Me.txtReceiptSeq.MaxLength = 0
            Me.txtReceiptSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReceiptSeq.Multiline = False
            Me.txtReceiptSeq.Name = "txtReceiptSeq"
            Me.txtReceiptSeq.ReadOnlys = False
            Me.txtReceiptSeq.SelectedText = ""
            Me.txtReceiptSeq.SelectionLength = 0
            Me.txtReceiptSeq.SelectionStart = 0
            Me.txtReceiptSeq.Size = New System.Drawing.Size(64, 20)
            Me.txtReceiptSeq.TabIndex = 20
            Me.txtReceiptSeq.Tag = Nothing
            Me.txtReceiptSeq.TextAlign = 2
            Me.txtReceiptSeq.TextValue = "[6] txtReceiptSeq"
            Me.txtReceiptSeq.ToolTipText = "입금순번"
            '
            'lblEpReceiptAmt
            '
            Me.lblEpReceiptAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblEpReceiptAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEpReceiptAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblEpReceiptAmt.Location = New System.Drawing.Point(52, 349)
            Me.lblEpReceiptAmt.Name = "lblEpReceiptAmt"
            Me.lblEpReceiptAmt.Size = New System.Drawing.Size(76, 12)
            Me.lblEpReceiptAmt.TabIndex = 32
            Me.lblEpReceiptAmt.Text = "수납금액"
            Me.lblEpReceiptAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numEpReceiptAmt
            '
            Me.numEpReceiptAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numEpReceiptAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numEpReceiptAmt.BorderColor = System.Drawing.Color.Empty
            Me.numEpReceiptAmt.BorderStyle = 2
            Me.numEpReceiptAmt.CaptionName = "수납금액"
            Me.numEpReceiptAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numEpReceiptAmt.LengthPrecision = 15
            Me.numEpReceiptAmt.LengthScale = 0
            Me.numEpReceiptAmt.Location = New System.Drawing.Point(136, 345)
            Me.numEpReceiptAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numEpReceiptAmt.MaxLength = 19
            Me.numEpReceiptAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numEpReceiptAmt.Name = "numEpReceiptAmt"
            Me.numEpReceiptAmt.ReadOnlys = False
            Me.numEpReceiptAmt.SelectedText = ""
            Me.numEpReceiptAmt.SelectionLength = 0
            Me.numEpReceiptAmt.SelectionStart = 1
            Me.numEpReceiptAmt.Size = New System.Drawing.Size(123, 20)
            Me.numEpReceiptAmt.TabIndex = 33
            Me.numEpReceiptAmt.Tag = Nothing
            Me.numEpReceiptAmt.TextValue = "0"
            Me.numEpReceiptAmt.ToolTipText = "수납금액"
            '
            'lblRemark
            '
            Me.lblRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRemark.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRemark.Location = New System.Drawing.Point(52, 372)
            Me.lblRemark.Name = "lblRemark"
            Me.lblRemark.Size = New System.Drawing.Size(76, 12)
            Me.lblRemark.TabIndex = 34
            Me.lblRemark.Text = "적요"
            Me.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRemark
            '
            Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtRemark.BackColor = System.Drawing.SystemColors.Window
            Me.txtRemark.BorderColor = System.Drawing.Color.Empty
            Me.txtRemark.BorderStyle = 2
            Me.txtRemark.CaptionName = "적요"
            Me.txtRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtRemark.Location = New System.Drawing.Point(136, 368)
            Me.txtRemark.MaxLength = 200
            Me.txtRemark.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRemark.Multiline = False
            Me.txtRemark.Name = "txtRemark"
            Me.txtRemark.ReadOnlys = False
            Me.txtRemark.SelectedText = ""
            Me.txtRemark.SelectionLength = 0
            Me.txtRemark.SelectionStart = 0
            Me.txtRemark.Size = New System.Drawing.Size(288, 20)
            Me.txtRemark.TabIndex = 35
            Me.txtRemark.Tag = Nothing
            Me.txtRemark.TextAlign = 0
            Me.txtRemark.TextValue = "[8] txtRemark"
            Me.txtRemark.ToolTipText = "적요"
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(790, 60)
            Me.picCriteria.TabIndex = 1799
            Me.picCriteria.TabStop = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(11, 74)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 12)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "<입금 내역>"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 68)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(790, 23)
            Me.PictureBox1.TabIndex = 1811
            Me.PictureBox1.TabStop = False
            '
            'lblTitle3
            '
            Me.lblTitle3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTitle3.AutoSize = True
            Me.lblTitle3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle3.Location = New System.Drawing.Point(12, 426)
            Me.lblTitle3.Name = "lblTitle3"
            Me.lblTitle3.Size = New System.Drawing.Size(80, 12)
            Me.lblTitle3.TabIndex = 50
            Me.lblTitle3.Text = "<수금 내역>"
            Me.lblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox3
            '
            Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox3.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox3.Location = New System.Drawing.Point(2, 420)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(793, 23)
            Me.PictureBox3.TabIndex = 1813
            Me.PictureBox3.TabStop = False
            '
            'popTaxNumber
            '
            Me.popTaxNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.popTaxNumber.BorderColor = System.Drawing.Color.Empty
            Me.popTaxNumber.BorderStyle = 2
            Me.popTaxNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTaxNumber.CaptionName = "PS계산번호"
            Me.popTaxNumber.CausesValidation = False
            Me.popTaxNumber.CodeText = "[1] popTaxNumber"
            Me.popTaxNumber.CodeWidth = 95
            Me.popTaxNumber.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popTaxNumber.Location = New System.Drawing.Point(136, 323)
            Me.popTaxNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popTaxNumber.MaxLength = 12
            Me.popTaxNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popTaxNumber.Name = "popTaxNumber"
            Me.popTaxNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popTaxNumber.NameText = ""
            Me.popTaxNumber.ReadOnlys = False
            Me.popTaxNumber.SelectedText = ""
            Me.popTaxNumber.SelectionLength = 0
            Me.popTaxNumber.SelectionStart = 0
            Me.popTaxNumber.Size = New System.Drawing.Size(288, 20)
            Me.popTaxNumber.TabIndex = 31
            Me.popTaxNumber.Tag = "code(PS계산서번호);rtnvalue(numRtnValue1,numRtnValue2,txtRcRemark,popCustomerCode,dtpP" & _
                "ubYYmm,txtPubSeq);"
            Me.popTaxNumber.TextAlign = 0
            Me.popTaxNumber.TextValue = "[1] popTaxNumber"
            Me.popTaxNumber.ToolTipText = "계산서번호"
            '
            'lblTaxNumber
            '
            Me.lblTaxNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTaxNumber.BackColor = System.Drawing.Color.GhostWhite
            Me.lblTaxNumber.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTaxNumber.Location = New System.Drawing.Point(52, 327)
            Me.lblTaxNumber.Name = "lblTaxNumber"
            Me.lblTaxNumber.Size = New System.Drawing.Size(76, 12)
            Me.lblTaxNumber.TabIndex = 30
            Me.lblTaxNumber.Text = "계산서번호"
            Me.lblTaxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.Location = New System.Drawing.Point(9, 275)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(111, 12)
            Me.Label4.TabIndex = 16
            Me.Label4.Text = "<수금 상세 내역>"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPubYYmm
            '
            Me.dtpPubYYmm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpPubYYmm.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPubYYmm.BorderColor = System.Drawing.Color.Empty
            Me.dtpPubYYmm.BorderStyle = 2
            Me.dtpPubYYmm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPubYYmm.CaptionName = "계산서발행년월"
            Me.dtpPubYYmm.DateTimeFormatText = "yyyy-MM"
            Me.dtpPubYYmm.Enabled = False
            Me.dtpPubYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPubYYmm.Location = New System.Drawing.Point(346, 300)
            Me.dtpPubYYmm.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm.MaxLength = 0
            Me.dtpPubYYmm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm.Name = "dtpPubYYmm"
            Me.dtpPubYYmm.ReadOnlys = False
            Me.dtpPubYYmm.SelectedText = ""
            Me.dtpPubYYmm.SelectionLength = 0
            Me.dtpPubYYmm.SelectionStart = 0
            Me.dtpPubYYmm.Size = New System.Drawing.Size(24, 20)
            Me.dtpPubYYmm.TabIndex = 27
            Me.dtpPubYYmm.Tag = "format(&&&&-&&);"
            Me.dtpPubYYmm.TextAlign = 0
            Me.dtpPubYYmm.TextValue = "[5]dtpPubYYmm"
            Me.dtpPubYYmm.ToolTipText = "계산서발행년월"
            Me.dtpPubYYmm.Visible = False
            '
            'lblRecordState
            '
            Me.lblRecordState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblRecordState.BackColor = System.Drawing.Color.LightGray
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.lblRecordState.Location = New System.Drawing.Point(706, 275)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 21
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popCustomerCode
            '
            Me.popCustomerCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.popCustomerCode.BorderColor = System.Drawing.Color.Empty
            Me.popCustomerCode.BorderStyle = 2
            Me.popCustomerCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCustomerCode.CaptionName = "경리거래처코드"
            Me.popCustomerCode.CausesValidation = False
            Me.popCustomerCode.CodeText = "[1]popCustomerCode"
            Me.popCustomerCode.CodeWidth = 70
            Me.popCustomerCode.Enabled = False
            Me.popCustomerCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCustomerCode.Location = New System.Drawing.Point(556, 300)
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
            Me.popCustomerCode.Size = New System.Drawing.Size(220, 20)
            Me.popCustomerCode.TabIndex = 41
            Me.popCustomerCode.Tag = "code(경리거래처코드);"
            Me.popCustomerCode.TextAlign = 0
            Me.popCustomerCode.TextValue = "[1]popCustomerCode"
            Me.popCustomerCode.ToolTipText = "경리거래처코드"
            '
            'lblCustomerCode
            '
            Me.lblCustomerCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblCustomerCode.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode.Enabled = False
            Me.lblCustomerCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode.Location = New System.Drawing.Point(481, 304)
            Me.lblCustomerCode.Name = "lblCustomerCode"
            Me.lblCustomerCode.Size = New System.Drawing.Size(71, 12)
            Me.lblCustomerCode.TabIndex = 40
            Me.lblCustomerCode.Text = "거래처코드"
            Me.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboRcptAccNumCd
            '
            Me.cboRcptAccNumCd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboRcptAccNumCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboRcptAccNumCd.CaptionName = "계좌코드"
            Me.cboRcptAccNumCd.Enabled = False
            Me.cboRcptAccNumCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboRcptAccNumCd.ListCount = 0
            Me.cboRcptAccNumCd.Location = New System.Drawing.Point(556, 323)
            Me.cboRcptAccNumCd.MaxLength = 5
            Me.cboRcptAccNumCd.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboRcptAccNumCd.Name = "cboRcptAccNumCd"
            Me.cboRcptAccNumCd.ReadOnlys = False
            Me.cboRcptAccNumCd.Size = New System.Drawing.Size(220, 20)
            Me.cboRcptAccNumCd.TabIndex = 43
            Me.cboRcptAccNumCd.Tag = "code(입금계좌코드| );read();"
            Me.cboRcptAccNumCd.Text = "cboRcptAccNumCd"
            Me.cboRcptAccNumCd.TextValue = ""
            '
            'lblAccountCode
            '
            Me.lblAccountCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblAccountCode.BackColor = System.Drawing.Color.GhostWhite
            Me.lblAccountCode.Enabled = False
            Me.lblAccountCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblAccountCode.Location = New System.Drawing.Point(481, 327)
            Me.lblAccountCode.Name = "lblAccountCode"
            Me.lblAccountCode.Size = New System.Drawing.Size(71, 12)
            Me.lblAccountCode.TabIndex = 42
            Me.lblAccountCode.Text = "계좌코드"
            Me.lblAccountCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblManagementNum
            '
            Me.lblManagementNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblManagementNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblManagementNum.Enabled = False
            Me.lblManagementNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblManagementNum.Location = New System.Drawing.Point(481, 350)
            Me.lblManagementNum.Name = "lblManagementNum"
            Me.lblManagementNum.Size = New System.Drawing.Size(71, 12)
            Me.lblManagementNum.TabIndex = 44
            Me.lblManagementNum.Text = "어음번호"
            Me.lblManagementNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtManagementNum
            '
            Me.txtManagementNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtManagementNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtManagementNum.BorderColor = System.Drawing.Color.Empty
            Me.txtManagementNum.BorderStyle = 2
            Me.txtManagementNum.CaptionName = "어음번호"
            Me.txtManagementNum.Enabled = False
            Me.txtManagementNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtManagementNum.Location = New System.Drawing.Point(556, 346)
            Me.txtManagementNum.MaxLength = 30
            Me.txtManagementNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtManagementNum.Multiline = False
            Me.txtManagementNum.Name = "txtManagementNum"
            Me.txtManagementNum.ReadOnlys = False
            Me.txtManagementNum.SelectedText = ""
            Me.txtManagementNum.SelectionLength = 0
            Me.txtManagementNum.SelectionStart = 0
            Me.txtManagementNum.Size = New System.Drawing.Size(220, 20)
            Me.txtManagementNum.TabIndex = 45
            Me.txtManagementNum.Tag = Nothing
            Me.txtManagementNum.TextAlign = 0
            Me.txtManagementNum.TextValue = "[6] txtManagementNum"
            Me.txtManagementNum.ToolTipText = "어음번호"
            '
            'lblReceiptAmt
            '
            Me.lblReceiptAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblReceiptAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblReceiptAmt.Enabled = False
            Me.lblReceiptAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptAmt.Location = New System.Drawing.Point(481, 372)
            Me.lblReceiptAmt.Name = "lblReceiptAmt"
            Me.lblReceiptAmt.Size = New System.Drawing.Size(71, 12)
            Me.lblReceiptAmt.TabIndex = 46
            Me.lblReceiptAmt.Text = "입금액"
            Me.lblReceiptAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numReceiptAmt
            '
            Me.numReceiptAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numReceiptAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numReceiptAmt.BorderColor = System.Drawing.Color.Empty
            Me.numReceiptAmt.BorderStyle = 2
            Me.numReceiptAmt.CaptionName = "입금액"
            Me.numReceiptAmt.Enabled = False
            Me.numReceiptAmt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numReceiptAmt.LengthPrecision = 15
            Me.numReceiptAmt.LengthScale = 0
            Me.numReceiptAmt.Location = New System.Drawing.Point(556, 368)
            Me.numReceiptAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numReceiptAmt.MaxLength = 19
            Me.numReceiptAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numReceiptAmt.Name = "numReceiptAmt"
            Me.numReceiptAmt.ReadOnlys = False
            Me.numReceiptAmt.SelectedText = ""
            Me.numReceiptAmt.SelectionLength = 0
            Me.numReceiptAmt.SelectionStart = 1
            Me.numReceiptAmt.Size = New System.Drawing.Size(220, 20)
            Me.numReceiptAmt.TabIndex = 47
            Me.numReceiptAmt.Tag = Nothing
            Me.numReceiptAmt.TextValue = "0"
            Me.numReceiptAmt.ToolTipText = "입금액"
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Enabled = False
            Me.Label5.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label5.Location = New System.Drawing.Point(481, 395)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(71, 12)
            Me.Label5.TabIndex = 48
            Me.Label5.Text = "입금적요"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRcRemark
            '
            Me.txtRcRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtRcRemark.BackColor = System.Drawing.SystemColors.Window
            Me.txtRcRemark.BorderColor = System.Drawing.Color.Empty
            Me.txtRcRemark.BorderStyle = 2
            Me.txtRcRemark.CaptionName = "적요"
            Me.txtRcRemark.Enabled = False
            Me.txtRcRemark.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtRcRemark.Location = New System.Drawing.Point(556, 391)
            Me.txtRcRemark.MaxLength = 200
            Me.txtRcRemark.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRcRemark.Multiline = False
            Me.txtRcRemark.Name = "txtRcRemark"
            Me.txtRcRemark.ReadOnlys = False
            Me.txtRcRemark.SelectedText = ""
            Me.txtRcRemark.SelectionLength = 0
            Me.txtRcRemark.SelectionStart = 0
            Me.txtRcRemark.Size = New System.Drawing.Size(220, 20)
            Me.txtRcRemark.TabIndex = 49
            Me.txtRcRemark.Tag = Nothing
            Me.txtRcRemark.TextAlign = 0
            Me.txtRcRemark.TextValue = "[9] txtRemark"
            Me.txtRcRemark.ToolTipText = "적요"
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox2.Location = New System.Drawing.Point(4, 268)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(793, 23)
            Me.PictureBox2.TabIndex = 1832
            Me.PictureBox2.TabStop = False
            '
            'numRtnValue1
            '
            Me.numRtnValue1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numRtnValue1.BackColor = System.Drawing.SystemColors.Window
            Me.numRtnValue1.BorderColor = System.Drawing.Color.Empty
            Me.numRtnValue1.BorderStyle = 2
            Me.numRtnValue1.CaptionName = "입금액"
            Me.numRtnValue1.Enabled = False
            Me.numRtnValue1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numRtnValue1.LengthPrecision = 15
            Me.numRtnValue1.LengthScale = 0
            Me.numRtnValue1.Location = New System.Drawing.Point(322, 391)
            Me.numRtnValue1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numRtnValue1.MaxLength = 19
            Me.numRtnValue1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numRtnValue1.Name = "numRtnValue1"
            Me.numRtnValue1.ReadOnlys = False
            Me.numRtnValue1.SelectedText = ""
            Me.numRtnValue1.SelectionLength = 0
            Me.numRtnValue1.SelectionStart = 1
            Me.numRtnValue1.Size = New System.Drawing.Size(48, 20)
            Me.numRtnValue1.TabIndex = 38
            Me.numRtnValue1.Tag = Nothing
            Me.numRtnValue1.TextValue = "0"
            Me.numRtnValue1.ToolTipText = "입금액"
            Me.numRtnValue1.Visible = False
            '
            'numRtnValue2
            '
            Me.numRtnValue2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numRtnValue2.BackColor = System.Drawing.SystemColors.Window
            Me.numRtnValue2.BorderColor = System.Drawing.Color.Empty
            Me.numRtnValue2.BorderStyle = 2
            Me.numRtnValue2.CaptionName = "입금액"
            Me.numRtnValue2.Enabled = False
            Me.numRtnValue2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numRtnValue2.LengthPrecision = 15
            Me.numRtnValue2.LengthScale = 0
            Me.numRtnValue2.Location = New System.Drawing.Point(376, 391)
            Me.numRtnValue2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numRtnValue2.MaxLength = 19
            Me.numRtnValue2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numRtnValue2.Name = "numRtnValue2"
            Me.numRtnValue2.ReadOnlys = False
            Me.numRtnValue2.SelectedText = ""
            Me.numRtnValue2.SelectionLength = 0
            Me.numRtnValue2.SelectionStart = 1
            Me.numRtnValue2.Size = New System.Drawing.Size(48, 20)
            Me.numRtnValue2.TabIndex = 39
            Me.numRtnValue2.Tag = Nothing
            Me.numRtnValue2.TextValue = "0"
            Me.numRtnValue2.ToolTipText = "입금액"
            Me.numRtnValue2.Visible = False
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.LightGray
            Me.lblCriteria.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria.Location = New System.Drawing.Point(154, 74)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria.TabIndex = 14
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCriteria_2
            '
            Me.lblCriteria_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblCriteria_2.BackColor = System.Drawing.Color.LightGray
            Me.lblCriteria_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria_2.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria_2.Location = New System.Drawing.Point(121, 426)
            Me.lblCriteria_2.Name = "lblCriteria_2"
            Me.lblCriteria_2.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria_2.TabIndex = 51
            Me.lblCriteria_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(19, 17)
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
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(116, 13)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(204, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1
            Me.cboSaleTypeCd_R.Tag = "code(업체매출구분|전체);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(333, 44)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(70, 12)
            Me.Label1.TabIndex = 11
            Me.Label1.Text = "입금번호"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popReceiptNumber_R
            '
            Me.popReceiptNumber_R.BorderColor = System.Drawing.Color.Empty
            Me.popReceiptNumber_R.BorderStyle = 2
            Me.popReceiptNumber_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popReceiptNumber_R.CaptionName = "입금번호"
            Me.popReceiptNumber_R.CausesValidation = False
            Me.popReceiptNumber_R.CodeText = "[1] popReceiptNumber"
            Me.popReceiptNumber_R.CodeWidth = 95
            Me.popReceiptNumber_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popReceiptNumber_R.Location = New System.Drawing.Point(405, 40)
            Me.popReceiptNumber_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popReceiptNumber_R.MaxLength = 14
            Me.popReceiptNumber_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popReceiptNumber_R.Name = "popReceiptNumber_R"
            Me.popReceiptNumber_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popReceiptNumber_R.NameText = ""
            Me.popReceiptNumber_R.ReadOnlys = False
            Me.popReceiptNumber_R.SelectedText = ""
            Me.popReceiptNumber_R.SelectionLength = 0
            Me.popReceiptNumber_R.SelectionStart = 0
            Me.popReceiptNumber_R.Size = New System.Drawing.Size(284, 20)
            Me.popReceiptNumber_R.TabIndex = 12
            Me.popReceiptNumber_R.Tag = "code(PS입금번호);rtnvalue(numRtnValue1,numRtnValue2,txtRcRemark,popCustomerCode,dtpRe" & _
                "ceiptDate,txtReceiptSeq);"
            Me.popReceiptNumber_R.TextAlign = 0
            Me.popReceiptNumber_R.TextValue = "[1] popReceiptNumber"
            Me.popReceiptNumber_R.ToolTipText = "입금번호"
            '
            'lblCustomerCode_R
            '
            Me.lblCustomerCode_R.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode_R.Location = New System.Drawing.Point(335, 22)
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
            Me.popCustomerCode_R.Location = New System.Drawing.Point(405, 17)
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
            Me.popCustomerCode_R.Size = New System.Drawing.Size(284, 20)
            Me.popCustomerCode_R.TabIndex = 3
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[4] popCustomerCode"
            Me.popCustomerCode_R.ToolTipText = "거래처코드"
            '
            'lblReceiptDate1_R
            '
            Me.lblReceiptDate1_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReceiptDate1_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate1_R.Location = New System.Drawing.Point(46, 45)
            Me.lblReceiptDate1_R.Name = "lblReceiptDate1_R"
            Me.lblReceiptDate1_R.Size = New System.Drawing.Size(70, 12)
            Me.lblReceiptDate1_R.TabIndex = 6
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
            Me.dtpReceiptDateFr_R.Location = New System.Drawing.Point(116, 40)
            Me.dtpReceiptDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFr_R.MaxLength = 0
            Me.dtpReceiptDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFr_R.Name = "dtpReceiptDateFr_R"
            Me.dtpReceiptDateFr_R.ReadOnlys = False
            Me.dtpReceiptDateFr_R.SelectedText = ""
            Me.dtpReceiptDateFr_R.SelectionLength = 0
            Me.dtpReceiptDateFr_R.SelectionStart = 0
            Me.dtpReceiptDateFr_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateFr_R.TabIndex = 7
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
            Me.lblReceiptDate2_R.Location = New System.Drawing.Point(211, 45)
            Me.lblReceiptDate2_R.Name = "lblReceiptDate2_R"
            Me.lblReceiptDate2_R.Size = New System.Drawing.Size(11, 12)
            Me.lblReceiptDate2_R.TabIndex = 8
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
            Me.dtpReceiptDateTo_R.Location = New System.Drawing.Point(228, 40)
            Me.dtpReceiptDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo_R.MaxLength = 0
            Me.dtpReceiptDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo_R.Name = "dtpReceiptDateTo_R"
            Me.dtpReceiptDateTo_R.ReadOnlys = False
            Me.dtpReceiptDateTo_R.SelectedText = ""
            Me.dtpReceiptDateTo_R.SelectionLength = 0
            Me.dtpReceiptDateTo_R.SelectionStart = 0
            Me.dtpReceiptDateTo_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateTo_R.TabIndex = 10
            Me.dtpReceiptDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo_R.TextAlign = 0
            Me.dtpReceiptDateTo_R.TextValue = "[2]dtpReceiptDate2_R"
            Me.dtpReceiptDateTo_R.ToolTipText = "입금종료일자"
            '
            'lblBillType_R
            '
            Me.lblBillType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBillType_R.Location = New System.Drawing.Point(701, 21)
            Me.lblBillType_R.Name = "lblBillType_R"
            Me.lblBillType_R.Size = New System.Drawing.Size(71, 12)
            Me.lblBillType_R.TabIndex = 4
            Me.lblBillType_R.Text = "청구 유형"
            Me.lblBillType_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBillType_R
            '
            Me.cboBillType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboBillType_R.CaptionName = "청구유형명"
            Me.cboBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBillType_R.ListCount = 0
            Me.cboBillType_R.Location = New System.Drawing.Point(778, 17)
            Me.cboBillType_R.MaxLength = 5
            Me.cboBillType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboBillType_R.Name = "cboBillType_R"
            Me.cboBillType_R.ReadOnlys = False
            Me.cboBillType_R.Size = New System.Drawing.Size(116, 20)
            Me.cboBillType_R.TabIndex = 5
            Me.cboBillType_R.Tag = "code(청구유형명|전체);"
            Me.cboBillType_R.TextValue = ""
            '
            'cboBillType
            '
            Me.cboBillType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboBillType.BackColor = System.Drawing.SystemColors.Window
            Me.cboBillType.CaptionName = "청구유형명"
            Me.cboBillType.Enabled = False
            Me.cboBillType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBillType.ListCount = 0
            Me.cboBillType.Location = New System.Drawing.Point(136, 391)
            Me.cboBillType.MaxLength = 5
            Me.cboBillType.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboBillType.Name = "cboBillType"
            Me.cboBillType.ReadOnlys = False
            Me.cboBillType.Size = New System.Drawing.Size(144, 20)
            Me.cboBillType.TabIndex = 37
            Me.cboBillType.Tag = "code(청구유형명|선택하세요);read();"
            Me.cboBillType.TextValue = ""
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(52, 395)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(76, 12)
            Me.Label3.TabIndex = 36
            Me.Label3.Text = "청구유형"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PSD104
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboBillType)
            Me.Controls.Add(Me.lblBillType_R)
            Me.Controls.Add(Me.cboBillType_R)
            Me.Controls.Add(Me.lblSaleTypeCd_R)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popReceiptNumber_R)
            Me.Controls.Add(Me.lblCustomerCode_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.lblReceiptDate1_R)
            Me.Controls.Add(Me.dtpReceiptDateFr_R)
            Me.Controls.Add(Me.lblReceiptDate2_R)
            Me.Controls.Add(Me.dtpReceiptDateTo_R)
            Me.Controls.Add(Me.lblCriteria_2)
            Me.Controls.Add(Me.lblCriteria)
            Me.Controls.Add(Me.numRtnValue2)
            Me.Controls.Add(Me.numRtnValue1)
            Me.Controls.Add(Me.cboRcptAccNumCd)
            Me.Controls.Add(Me.lblAccountCode)
            Me.Controls.Add(Me.lblManagementNum)
            Me.Controls.Add(Me.txtManagementNum)
            Me.Controls.Add(Me.lblReceiptAmt)
            Me.Controls.Add(Me.numReceiptAmt)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtRcRemark)
            Me.Controls.Add(Me.popCustomerCode)
            Me.Controls.Add(Me.lblCustomerCode)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.dtpPubYYmm)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.lblTaxNumber)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.popTaxNumber)
            Me.Controls.Add(Me.lblTitle3)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.lblEpReceiptDate)
            Me.Controls.Add(Me.dtpEpReceiptDate)
            Me.Controls.Add(Me.lblEpReceiptSeq)
            Me.Controls.Add(Me.txtEpReceiptSeq)
            Me.Controls.Add(Me.lblPubYYmm)
            Me.Controls.Add(Me.lblPubSeq)
            Me.Controls.Add(Me.txtPubSeq)
            Me.Controls.Add(Me.lblReceiptDate)
            Me.Controls.Add(Me.dtpReceiptDate)
            Me.Controls.Add(Me.lblReceiptSeq)
            Me.Controls.Add(Me.txtReceiptSeq)
            Me.Controls.Add(Me.lblEpReceiptAmt)
            Me.Controls.Add(Me.numEpReceiptAmt)
            Me.Controls.Add(Me.lblRemark)
            Me.Controls.Add(Me.txtRemark)
            Me.Controls.Add(Me.picIo_3)
            Me.Controls.Add(Me.PictureBox2)
            Me.Name = "PSD104"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.picIo_3, 0)
            Me.Controls.SetChildIndex(Me.txtRemark, 0)
            Me.Controls.SetChildIndex(Me.lblRemark, 0)
            Me.Controls.SetChildIndex(Me.numEpReceiptAmt, 0)
            Me.Controls.SetChildIndex(Me.lblEpReceiptAmt, 0)
            Me.Controls.SetChildIndex(Me.txtReceiptSeq, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptSeq, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDate, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate, 0)
            Me.Controls.SetChildIndex(Me.txtPubSeq, 0)
            Me.Controls.SetChildIndex(Me.lblPubSeq, 0)
            Me.Controls.SetChildIndex(Me.lblPubYYmm, 0)
            Me.Controls.SetChildIndex(Me.txtEpReceiptSeq, 0)
            Me.Controls.SetChildIndex(Me.lblEpReceiptSeq, 0)
            Me.Controls.SetChildIndex(Me.dtpEpReceiptDate, 0)
            Me.Controls.SetChildIndex(Me.lblEpReceiptDate, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.PictureBox3, 0)
            Me.Controls.SetChildIndex(Me.lblTitle3, 0)
            Me.Controls.SetChildIndex(Me.popTaxNumber, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.lblTaxNumber, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.dtpPubYYmm, 0)
            Me.Controls.SetChildIndex(Me.lblRecordState, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode, 0)
            Me.Controls.SetChildIndex(Me.txtRcRemark, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.numReceiptAmt, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptAmt, 0)
            Me.Controls.SetChildIndex(Me.txtManagementNum, 0)
            Me.Controls.SetChildIndex(Me.lblManagementNum, 0)
            Me.Controls.SetChildIndex(Me.lblAccountCode, 0)
            Me.Controls.SetChildIndex(Me.cboRcptAccNumCd, 0)
            Me.Controls.SetChildIndex(Me.numRtnValue1, 0)
            Me.Controls.SetChildIndex(Me.numRtnValue2, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria_2, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate2_R, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate1_R, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.popReceiptNumber_R, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.cboBillType_R, 0)
            Me.Controls.SetChildIndex(Me.lblBillType_R, 0)
            Me.Controls.SetChildIndex(Me.cboBillType, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblEpReceiptDate As System.Windows.Forms.Label
        Friend WithEvents dtpEpReceiptDate As ubiLease.CommonControls.dtp
        Friend WithEvents lblEpReceiptSeq As System.Windows.Forms.Label
        Friend WithEvents txtEpReceiptSeq As ubiLease.CommonControls.txt
        Friend WithEvents lblPubYYmm As System.Windows.Forms.Label
        Friend WithEvents lblPubSeq As System.Windows.Forms.Label
        Friend WithEvents txtPubSeq As ubiLease.CommonControls.txt
        Friend WithEvents lblReceiptDate As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDate As ubiLease.CommonControls.dtp
        Friend WithEvents lblReceiptSeq As System.Windows.Forms.Label
        Friend WithEvents txtReceiptSeq As ubiLease.CommonControls.txt
        Friend WithEvents lblEpReceiptAmt As System.Windows.Forms.Label
        Friend WithEvents numEpReceiptAmt As ubiLease.CommonControls.num
        Friend WithEvents lblRemark As System.Windows.Forms.Label
        Friend WithEvents txtRemark As ubiLease.CommonControls.txt






        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picIo_3 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle3 As System.Windows.Forms.Label
        Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Friend WithEvents popTaxNumber As ubiLease.CommonControls.pop
        Friend WithEvents lblTaxNumber As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpPubYYmm As ubiLease.CommonControls.dtp
        Friend WithEvents lblRecordState As System.Windows.Forms.Label
        Friend WithEvents popCustomerCode As ubiLease.CommonControls.pop
        Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
        Friend WithEvents cboRcptAccNumCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblAccountCode As System.Windows.Forms.Label
        Friend WithEvents lblManagementNum As System.Windows.Forms.Label
        Friend WithEvents txtManagementNum As ubiLease.CommonControls.txt
        Friend WithEvents lblReceiptAmt As System.Windows.Forms.Label
        Friend WithEvents numReceiptAmt As ubiLease.CommonControls.num
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtRcRemark As ubiLease.CommonControls.txt
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents numRtnValue1 As ubiLease.CommonControls.num
        Friend WithEvents numRtnValue2 As ubiLease.CommonControls.num
        Friend WithEvents lblCriteria As System.Windows.Forms.Label
        Friend WithEvents lblCriteria_2 As System.Windows.Forms.Label
        Friend WithEvents lblSaleTypeCd_R As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popReceiptNumber_R As ubiLease.CommonControls.pop
        Friend WithEvents lblCustomerCode_R As System.Windows.Forms.Label
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents lblReceiptDate1_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblReceiptDate2_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblBillType_R As System.Windows.Forms.Label
        Friend WithEvents cboBillType_R As ubiLease.CommonControls.cbo
        Friend WithEvents cboBillType As ubiLease.CommonControls.cbo
        Friend WithEvents Label3 As System.Windows.Forms.Label

 
    End Class 
 
End Namespace 