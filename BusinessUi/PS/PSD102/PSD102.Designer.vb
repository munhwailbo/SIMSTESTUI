Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSD102 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSD102))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.lblSaleTypeCd_R = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
            Me.lblCustomerCode_R = New System.Windows.Forms.Label
            Me.popCustomerCode_R = New ubiLease.CommonControls.pop
            Me.lblReceiptDate1_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateFr_R = New ubiLease.CommonControls.dtp
            Me.lblReceiptDate2_R = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo_R = New ubiLease.CommonControls.dtp
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria.TabIndex = 6
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
            Me.grd_1.Location = New System.Drawing.Point(5, 92)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 543)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1859
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(12, 74)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(173, 12)
            Me.lblTitle1.TabIndex = 1861
            Me.lblTitle1.Text = "<업체 입금 전표 처리 대상>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.Lavender
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(5, 68)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(790, 26)
            Me.picTitle1.TabIndex = 1860
            Me.picTitle1.TabStop = False
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(18, 18)
            Me.lblSaleTypeCd_R.Name = "lblSaleTypeCd_R"
            Me.lblSaleTypeCd_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd_R.TabIndex = 1868
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "매출구분코드"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(115, 14)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(204, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1869
            Me.cboSaleTypeCd_R.Tag = "code(업체매출구분|전체);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'lblCustomerCode_R
            '
            Me.lblCustomerCode_R.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode_R.Location = New System.Drawing.Point(378, 18)
            Me.lblCustomerCode_R.Name = "lblCustomerCode_R"
            Me.lblCustomerCode_R.Size = New System.Drawing.Size(70, 12)
            Me.lblCustomerCode_R.TabIndex = 1866
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
            Me.popCustomerCode_R.Location = New System.Drawing.Point(448, 14)
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
            Me.popCustomerCode_R.TabIndex = 1867
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[4] popCustomerCode"
            Me.popCustomerCode_R.ToolTipText = "거래처코드"
            '
            'lblReceiptDate1_R
            '
            Me.lblReceiptDate1_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReceiptDate1_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblReceiptDate1_R.Location = New System.Drawing.Point(18, 44)
            Me.lblReceiptDate1_R.Name = "lblReceiptDate1_R"
            Me.lblReceiptDate1_R.Size = New System.Drawing.Size(95, 12)
            Me.lblReceiptDate1_R.TabIndex = 1862
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
            Me.dtpReceiptDateFr_R.Location = New System.Drawing.Point(115, 39)
            Me.dtpReceiptDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFr_R.MaxLength = 0
            Me.dtpReceiptDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFr_R.Name = "dtpReceiptDateFr_R"
            Me.dtpReceiptDateFr_R.ReadOnlys = False
            Me.dtpReceiptDateFr_R.SelectedText = ""
            Me.dtpReceiptDateFr_R.SelectionLength = 0
            Me.dtpReceiptDateFr_R.SelectionStart = 0
            Me.dtpReceiptDateFr_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateFr_R.TabIndex = 1863
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
            Me.lblReceiptDate2_R.Location = New System.Drawing.Point(210, 44)
            Me.lblReceiptDate2_R.Name = "lblReceiptDate2_R"
            Me.lblReceiptDate2_R.Size = New System.Drawing.Size(11, 12)
            Me.lblReceiptDate2_R.TabIndex = 1864
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
            Me.dtpReceiptDateTo_R.Location = New System.Drawing.Point(227, 39)
            Me.dtpReceiptDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo_R.MaxLength = 0
            Me.dtpReceiptDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo_R.Name = "dtpReceiptDateTo_R"
            Me.dtpReceiptDateTo_R.ReadOnlys = False
            Me.dtpReceiptDateTo_R.SelectedText = ""
            Me.dtpReceiptDateTo_R.SelectionLength = 0
            Me.dtpReceiptDateTo_R.SelectionStart = 0
            Me.dtpReceiptDateTo_R.Size = New System.Drawing.Size(92, 20)
            Me.dtpReceiptDateTo_R.TabIndex = 1865
            Me.dtpReceiptDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo_R.TextAlign = 0
            Me.dtpReceiptDateTo_R.TextValue = "[2]dtpReceiptDate2_R"
            Me.dtpReceiptDateTo_R.ToolTipText = "입금종료일자"
            '
            'PSD102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblSaleTypeCd_R)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.lblCustomerCode_R)
            Me.Controls.Add(Me.popCustomerCode_R)
            Me.Controls.Add(Me.lblReceiptDate1_R)
            Me.Controls.Add(Me.dtpReceiptDateFr_R)
            Me.Controls.Add(Me.lblReceiptDate2_R)
            Me.Controls.Add(Me.dtpReceiptDateTo_R)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSD102"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate2_R, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.lblReceiptDate1_R, 0)
            Me.Controls.SetChildIndex(Me.popCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode_R, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleTypeCd_R, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
 





        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblSaleTypeCd_R As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents lblCustomerCode_R As System.Windows.Forms.Label
        Friend WithEvents popCustomerCode_R As ubiLease.CommonControls.pop
        Friend WithEvents lblReceiptDate1_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblReceiptDate2_R As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo_R As ubiLease.CommonControls.dtp
 
    End Class 
 
End Namespace 