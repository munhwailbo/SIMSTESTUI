Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSD106 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSD106))
            Me.Label3 = New System.Windows.Forms.Label
            Me.popReceiptNumber_R = New ubiLease.CommonControls.pop
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblCriteria = New System.Windows.Forms.Label
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.lblCustomerCode_R = New System.Windows.Forms.Label
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.lblReceiptDate1_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateFr_R = New ubiLease.CommonControls.dtp
            Me.lblReceiptDate2_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo_R = New ubiLease.CommonControls.dtp
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblPubYYmm = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpPubYYmm_R = New ubiLease.CommonControls.dtp
            Me.numPubSeq_R = New ubiLease.CommonControls.num
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(413, 40)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(70, 12)
            Me.Label3.TabIndex = 1861
            Me.Label3.Text = "입금번호"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.popReceiptNumber_R.Location = New System.Drawing.Point(485, 36)
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
            Me.popReceiptNumber_R.Size = New System.Drawing.Size(288, 20)
            Me.popReceiptNumber_R.TabIndex = 1860
            Me.popReceiptNumber_R.Tag = "code(PS입금번호);rtnvalue(numRtnValue1,numRtnValue2,txtRcRemark,popCustomerCode,dtpRe" & _
                "ceiptDate,txtReceiptSeq);"
            Me.popReceiptNumber_R.TextAlign = 0
            Me.popReceiptNumber_R.TextValue = "[1] popReceiptNumber"
            Me.popReceiptNumber_R.ToolTipText = "입금번호"
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
            Me.grd_1.Location = New System.Drawing.Point(5, 91)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 546)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1851
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.Lavender
            Me.lblCriteria.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria.Location = New System.Drawing.Point(134, 74)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria.TabIndex = 1857
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(12, 73)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(111, 12)
            Me.lblTitle1.TabIndex = 1856
            Me.lblTitle1.Text = "<업체 수납 내역>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.Lavender
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(5, 67)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(790, 26)
            Me.picTitle1.TabIndex = 1855
            Me.picTitle1.TabStop = False
            '
            'lblCustomerCode_R
            '
            Me.lblCustomerCode_R.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode_R.Location = New System.Drawing.Point(45, 15)
            Me.lblCustomerCode_R.Name = "lblCustomerCode_R"
            Me.lblCustomerCode_R.Size = New System.Drawing.Size(70, 12)
            Me.lblCustomerCode_R.TabIndex = 1853
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
            Me.popCustomerCode_R.Location = New System.Drawing.Point(115, 10)
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
            Me.popCustomerCode_R.Size = New System.Drawing.Size(241, 20)
            Me.popCustomerCode_R.TabIndex = 1854
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[4] popCustomerCode"
            Me.popCustomerCode_R.ToolTipText = "거래처코드"
            '
            'lblReceiptDate1_R
            '
            Me.lblReceiptDate1_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReceiptDate1_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate1_R.Location = New System.Drawing.Point(45, 41)
            Me.lblReceiptDate1_R.Name = "lblReceiptDate1_R"
            Me.lblReceiptDate1_R.Size = New System.Drawing.Size(70, 12)
            Me.lblReceiptDate1_R.TabIndex = 1847
            Me.lblReceiptDate1_R.Text = "수납일자"
            Me.lblReceiptDate1_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDateFr_R
            '
            Me.dtpReceiptDateFr_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateFr_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateFr_R.BorderStyle = 2
            Me.dtpReceiptDateFr_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateFr_R.CaptionName = "납수시작일자"
            Me.dtpReceiptDateFr_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpReceiptDateFr_R.Location = New System.Drawing.Point(115, 36)
            Me.dtpReceiptDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFr_R.MaxLength = 0
            Me.dtpReceiptDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFr_R.Name = "dtpReceiptDateFr_R"
            Me.dtpReceiptDateFr_R.ReadOnlys = False
            Me.dtpReceiptDateFr_R.SelectedText = ""
            Me.dtpReceiptDateFr_R.SelectionLength = 0
            Me.dtpReceiptDateFr_R.SelectionStart = 0
            Me.dtpReceiptDateFr_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateFr_R.TabIndex = 1848
            Me.dtpReceiptDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateFr_R.TextAlign = 0
            Me.dtpReceiptDateFr_R.TextValue = "[1]dtpEpReceiptDate1_R"
            Me.dtpReceiptDateFr_R.ToolTipText = "수납시작일자"
            '
            'lblReceiptDate2_R
            '
            Me.lblReceiptDate2_R.AutoSize = True
            Me.lblReceiptDate2_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReceiptDate2_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate2_R.Location = New System.Drawing.Point(210, 41)
            Me.lblReceiptDate2_R.Name = "lblReceiptDate2_R"
            Me.lblReceiptDate2_R.Size = New System.Drawing.Size(11, 12)
            Me.lblReceiptDate2_R.TabIndex = 1849
            Me.lblReceiptDate2_R.Text = "-"
            Me.lblReceiptDate2_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDateTo_R
            '
            Me.dtpReceiptDateTo_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateTo_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateTo_R.BorderStyle = 2
            Me.dtpReceiptDateTo_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateTo_R.CaptionName = "납수종료일자"
            Me.dtpReceiptDateTo_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateTo_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpReceiptDateTo_R.Location = New System.Drawing.Point(227, 36)
            Me.dtpReceiptDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo_R.MaxLength = 0
            Me.dtpReceiptDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo_R.Name = "dtpReceiptDateTo_R"
            Me.dtpReceiptDateTo_R.ReadOnlys = False
            Me.dtpReceiptDateTo_R.SelectedText = ""
            Me.dtpReceiptDateTo_R.SelectionLength = 0
            Me.dtpReceiptDateTo_R.SelectionStart = 0
            Me.dtpReceiptDateTo_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateTo_R.TabIndex = 1850
            Me.dtpReceiptDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo_R.TextAlign = 0
            Me.dtpReceiptDateTo_R.TextValue = "[2]dtpEpReceiptDate2_R"
            Me.dtpReceiptDateTo_R.ToolTipText = "수납종료일자"
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(790, 60)
            Me.picCriteria.TabIndex = 1852
            Me.picCriteria.TabStop = False
            '
            'lblPubYYmm
            '
            Me.lblPubYYmm.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPubYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblPubYYmm.Location = New System.Drawing.Point(414, 14)
            Me.lblPubYYmm.Name = "lblPubYYmm"
            Me.lblPubYYmm.Size = New System.Drawing.Size(65, 12)
            Me.lblPubYYmm.TabIndex = 1865
            Me.lblPubYYmm.Text = "계산서번호"
            Me.lblPubYYmm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Enabled = False
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(574, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(9, 12)
            Me.Label1.TabIndex = 1863
            Me.Label1.Text = "-"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.dtpPubYYmm_R.Location = New System.Drawing.Point(485, 10)
            Me.dtpPubYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm_R.MaxLength = 0
            Me.dtpPubYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm_R.Name = "dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ReadOnlys = False
            Me.dtpPubYYmm_R.SelectedText = ""
            Me.dtpPubYYmm_R.SelectionLength = 0
            Me.dtpPubYYmm_R.SelectionStart = 0
            Me.dtpPubYYmm_R.Size = New System.Drawing.Size(88, 20)
            Me.dtpPubYYmm_R.TabIndex = 1862
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
            Me.numPubSeq_R.Location = New System.Drawing.Point(586, 10)
            Me.numPubSeq_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPubSeq_R.MaxLength = 0
            Me.numPubSeq_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPubSeq_R.Name = "numPubSeq_R"
            Me.numPubSeq_R.ReadOnlys = False
            Me.numPubSeq_R.SelectedText = ""
            Me.numPubSeq_R.SelectionLength = 0
            Me.numPubSeq_R.SelectionStart = 1
            Me.numPubSeq_R.Size = New System.Drawing.Size(52, 20)
            Me.numPubSeq_R.TabIndex = 1864
            Me.numPubSeq_R.Tag = ""
            Me.numPubSeq_R.TextValue = "0"
            Me.numPubSeq_R.ToolTipText = "발행순번"
            '
            'PSD106
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblPubYYmm)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpPubYYmm_R)
            Me.Controls.Add(Me.numPubSeq_R)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popReceiptNumber_R)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblCriteria)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.lblCustomerCode_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.lblReceiptDate1_R)
            Me.Controls.Add(Me.dtpReceiptDateFr_R)
            Me.Controls.Add(Me.lblReceiptDate2_R)
            Me.Controls.Add(Me.dtpReceiptDateTo_R)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSD106"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate2_R, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate1_R, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.popReceiptNumber_R, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.numPubSeq_R, 0)
            Me.Controls.SetChildIndex(Me.dtpPubYYmm_R, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.lblPubYYmm, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents popReceiptNumber_R As ubiLease.CommonControls.pop
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblCriteria As System.Windows.Forms.Label
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblCustomerCode_R As System.Windows.Forms.Label
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents lblReceiptDate1_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblReceiptDate2_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblPubYYmm As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpPubYYmm_R As ubiLease.CommonControls.dtp
        Friend WithEvents numPubSeq_R As ubiLease.CommonControls.num
 






 
    End Class 
 
End Namespace 