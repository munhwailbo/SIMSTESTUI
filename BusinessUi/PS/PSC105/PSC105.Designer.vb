﻿Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSC105 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSC105))
            Me.lblCriteria = New System.Windows.Forms.Label
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picTitle1 = New System.Windows.Forms.PictureBox
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
            Me.chkSumView = New System.Windows.Forms.CheckBox
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.Lavender
            Me.lblCriteria.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria.Location = New System.Drawing.Point(131, 76)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria.TabIndex = 1840
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(12, 75)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(111, 12)
            Me.lblTitle1.TabIndex = 1839
            Me.lblTitle1.Text = "<판매 매출 내역>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_1.Location = New System.Drawing.Point(4, 93)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(792, 543)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1837
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.Lavender
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(4, 68)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(792, 26)
            Me.picTitle1.TabIndex = 1838
            Me.picTitle1.TabStop = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(629, 42)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(11, 12)
            Me.Label6.TabIndex = 1836
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
            Me.dtpPubDateTo_R.Location = New System.Drawing.Point(642, 38)
            Me.dtpPubDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateTo_R.MaxLength = 0
            Me.dtpPubDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateTo_R.Name = "dtpPubDateTo_R"
            Me.dtpPubDateTo_R.ReadOnlys = False
            Me.dtpPubDateTo_R.SelectedText = ""
            Me.dtpPubDateTo_R.SelectionLength = 0
            Me.dtpPubDateTo_R.SelectionStart = 0
            Me.dtpPubDateTo_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateTo_R.TabIndex = 1835
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
            Me.dtpPubDateFr_R.Location = New System.Drawing.Point(523, 38)
            Me.dtpPubDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubDateFr_R.MaxLength = 0
            Me.dtpPubDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubDateFr_R.Name = "dtpPubDateFr_R"
            Me.dtpPubDateFr_R.ReadOnlys = False
            Me.dtpPubDateFr_R.SelectedText = ""
            Me.dtpPubDateFr_R.SelectionLength = 0
            Me.dtpPubDateFr_R.SelectionStart = 0
            Me.dtpPubDateFr_R.Size = New System.Drawing.Size(103, 20)
            Me.dtpPubDateFr_R.TabIndex = 1834
            Me.dtpPubDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpPubDateFr_R.TextAlign = 0
            Me.dtpPubDateFr_R.TextValue = "[4]dtpPubDate_Fr"
            Me.dtpPubDateFr_R.ToolTipText = "발행일자"
            '
            'optGb2
            '
            Me.optGb2.AutoSize = True
            Me.optGb2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGb2.Checked = True
            Me.optGb2.Location = New System.Drawing.Point(445, 40)
            Me.optGb2.Name = "optGb2"
            Me.optGb2.Size = New System.Drawing.Size(71, 16)
            Me.optGb2.TabIndex = 1833
            Me.optGb2.TabStop = True
            Me.optGb2.Text = "기준일자"
            Me.optGb2.UseVisualStyleBackColor = False
            '
            'optGb1
            '
            Me.optGb1.AutoSize = True
            Me.optGb1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGb1.Location = New System.Drawing.Point(445, 15)
            Me.optGb1.Name = "optGb1"
            Me.optGb1.Size = New System.Drawing.Size(71, 16)
            Me.optGb1.TabIndex = 1832
            Me.optGb1.Text = "기준년월"
            Me.optGb1.UseVisualStyleBackColor = False
            Me.optGb1.Visible = False
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
            Me.dtpPubYYmm_R.Location = New System.Drawing.Point(523, 12)
            Me.dtpPubYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPubYYmm_R.MaxLength = 0
            Me.dtpPubYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPubYYmm_R.Name = "dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ReadOnlys = False
            Me.dtpPubYYmm_R.SelectedText = ""
            Me.dtpPubYYmm_R.SelectionLength = 0
            Me.dtpPubYYmm_R.SelectionStart = 0
            Me.dtpPubYYmm_R.Size = New System.Drawing.Size(78, 20)
            Me.dtpPubYYmm_R.TabIndex = 1831
            Me.dtpPubYYmm_R.Tag = "format(&&&&-&&);"
            Me.dtpPubYYmm_R.TextAlign = 0
            Me.dtpPubYYmm_R.TextValue = "[1]dtpPubYYmm_R"
            Me.dtpPubYYmm_R.ToolTipText = "발행년월"
            Me.dtpPubYYmm_R.Visible = False
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
            Me.popCustomerCode_R.Location = New System.Drawing.Point(125, 38)
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
            Me.popCustomerCode_R.TabIndex = 1830
            Me.popCustomerCode_R.Tag = "code(경리거래처코드);"
            Me.popCustomerCode_R.TextAlign = 0
            Me.popCustomerCode_R.TextValue = "[1] pop경리거래처코드"
            Me.popCustomerCode_R.ToolTipText = "경리거래처코드"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(50, 42)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 12)
            Me.Label1.TabIndex = 1829
            Me.Label1.Text = "거래처코드"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSaleTypeCd_R
            '
            Me.lblSaleTypeCd_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleTypeCd_R.Location = New System.Drawing.Point(28, 17)
            Me.lblSaleTypeCd_R.Name = "lblSaleTypeCd_R"
            Me.lblSaleTypeCd_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleTypeCd_R.TabIndex = 1827
            Me.lblSaleTypeCd_R.Text = "매출구분코드"
            Me.lblSaleTypeCd_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "판매매출구분"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(125, 12)
            Me.cboSaleTypeCd_R.MaxLength = 5
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(268, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1828
            Me.cboSaleTypeCd_R.Tag = "code(판매매출구분|전체);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(4, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(792, 60)
            Me.picCriteria.TabIndex = 1826
            Me.picCriteria.TabStop = False
            '
            'chkSumView
            '
            Me.chkSumView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkSumView.AutoSize = True
            Me.chkSumView.BackColor = System.Drawing.Color.Lavender
            Me.chkSumView.Location = New System.Drawing.Point(711, 74)
            Me.chkSumView.Name = "chkSumView"
            Me.chkSumView.Size = New System.Drawing.Size(72, 16)
            Me.chkSumView.TabIndex = 1841
            Me.chkSumView.Text = "합계표시"
            Me.chkSumView.UseVisualStyleBackColor = False
            '
            'PSC105
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkSumView)
            Me.Controls.Add(Me.lblCriteria)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.grd_1)
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
            Me.Name = "PSC105"
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
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria, 0)
            Me.Controls.SetChildIndex(Me.chkSumView, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblCriteria As System.Windows.Forms.Label
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
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
        Friend WithEvents chkSumView As System.Windows.Forms.CheckBox
 

 
    End Class 
 
End Namespace 