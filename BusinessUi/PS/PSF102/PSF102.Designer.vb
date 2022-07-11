Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSF102 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSF102))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.popChargeEmpNum_R = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpToColDt = New ubiLease.CommonControls.dtp
            Me.lblHahaha = New System.Windows.Forms.Label
            Me.dtpFromColDt = New ubiLease.CommonControls.dtp
            Me.lblColDt = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblCriteria = New System.Windows.Forms.Label
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
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
            Me.picCriteria.TabIndex = 1
            Me.picCriteria.TabStop = False
            '
            'popBranchCd_R
            '
            Me.popBranchCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd_R.BorderStyle = 2
            Me.popBranchCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd_R.CaptionName = "지국 코드"
            Me.popBranchCd_R.CodeText = ""
            Me.popBranchCd_R.CodeWidth = 65
            Me.popBranchCd_R.Location = New System.Drawing.Point(593, 26)
            Me.popBranchCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd_R.MaxLength = 9
            Me.popBranchCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd_R.Name = "popBranchCd_R"
            Me.popBranchCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd_R.NameText = ""
            Me.popBranchCd_R.ReadOnlys = False
            Me.popBranchCd_R.SelectedText = ""
            Me.popBranchCd_R.SelectionLength = 0
            Me.popBranchCd_R.SelectionStart = 0
            Me.popBranchCd_R.Size = New System.Drawing.Size(176, 20)
            Me.popBranchCd_R.TabIndex = 1708
            Me.popBranchCd_R.Tag = "code(지국번호);"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            Me.popBranchCd_R.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(530, 29)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 14)
            Me.Label2.TabIndex = 1712
            Me.Label2.Text = "지국번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Visible = False
            '
            'popChargeEmpNum_R
            '
            Me.popChargeEmpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_R.BorderStyle = 2
            Me.popChargeEmpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_R.CaptionName = "담당자"
            Me.popChargeEmpNum_R.CodeText = ""
            Me.popChargeEmpNum_R.CodeWidth = 55
            Me.popChargeEmpNum_R.Location = New System.Drawing.Point(360, 26)
            Me.popChargeEmpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum_R.MaxLength = 6
            Me.popChargeEmpNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum_R.Name = "popChargeEmpNum_R"
            Me.popChargeEmpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_R.NameText = ""
            Me.popChargeEmpNum_R.ReadOnlys = False
            Me.popChargeEmpNum_R.SelectedText = ""
            Me.popChargeEmpNum_R.SelectionLength = 0
            Me.popChargeEmpNum_R.SelectionStart = 0
            Me.popChargeEmpNum_R.Size = New System.Drawing.Size(152, 20)
            Me.popChargeEmpNum_R.TabIndex = 1707
            Me.popChargeEmpNum_R.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_R.TextAlign = 0
            Me.popChargeEmpNum_R.TextValue = ""
            Me.popChargeEmpNum_R.ToolTipText = ""
            Me.popChargeEmpNum_R.Visible = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(305, 29)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 15)
            Me.Label1.TabIndex = 1711
            Me.Label1.Text = "담당자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label1.Visible = False
            '
            'dtpToColDt
            '
            Me.dtpToColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpToColDt.BorderStyle = 2
            Me.dtpToColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToColDt.CaptionName = "입금일자"
            Me.dtpToColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToColDt.Location = New System.Drawing.Point(202, 26)
            Me.dtpToColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToColDt.MaxLength = 0
            Me.dtpToColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToColDt.Name = "dtpToColDt"
            Me.dtpToColDt.ReadOnlys = False
            Me.dtpToColDt.SelectedText = ""
            Me.dtpToColDt.SelectionLength = 0
            Me.dtpToColDt.SelectionStart = 0
            Me.dtpToColDt.Size = New System.Drawing.Size(95, 20)
            Me.dtpToColDt.TabIndex = 1706
            Me.dtpToColDt.TabStop = False
            Me.dtpToColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpToColDt.TextAlign = 0
            Me.dtpToColDt.TextValue = ""
            Me.dtpToColDt.ToolTipText = ""
            '
            'lblHahaha
            '
            Me.lblHahaha.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblHahaha.Location = New System.Drawing.Point(188, 29)
            Me.lblHahaha.Name = "lblHahaha"
            Me.lblHahaha.Size = New System.Drawing.Size(15, 15)
            Me.lblHahaha.TabIndex = 1710
            Me.lblHahaha.Text = "~"
            Me.lblHahaha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpFromColDt
            '
            Me.dtpFromColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromColDt.BorderStyle = 2
            Me.dtpFromColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromColDt.CaptionName = "접수년"
            Me.dtpFromColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromColDt.Location = New System.Drawing.Point(94, 26)
            Me.dtpFromColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromColDt.MaxLength = 0
            Me.dtpFromColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromColDt.Name = "dtpFromColDt"
            Me.dtpFromColDt.ReadOnlys = False
            Me.dtpFromColDt.SelectedText = ""
            Me.dtpFromColDt.SelectionLength = 0
            Me.dtpFromColDt.SelectionStart = 0
            Me.dtpFromColDt.Size = New System.Drawing.Size(95, 20)
            Me.dtpFromColDt.TabIndex = 1705
            Me.dtpFromColDt.TabStop = False
            Me.dtpFromColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpFromColDt.TextAlign = 0
            Me.dtpFromColDt.TextValue = ""
            Me.dtpFromColDt.ToolTipText = ""
            '
            'lblColDt
            '
            Me.lblColDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblColDt.Location = New System.Drawing.Point(23, 29)
            Me.lblColDt.Name = "lblColDt"
            Me.lblColDt.Size = New System.Drawing.Size(65, 15)
            Me.lblColDt.TabIndex = 1709
            Me.lblColDt.Text = "입금 일자"
            Me.lblColDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_1.Location = New System.Drawing.Point(5, 93)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 542)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1713
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.Lavender
            Me.lblCriteria.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.lblCriteria.Location = New System.Drawing.Point(235, 74)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(95, 12)
            Me.lblCriteria.TabIndex = 1845
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(12, 74)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(212, 12)
            Me.lblTitle1.TabIndex = 1844
            Me.lblTitle1.Text = "<확장비 대체수납 전표 처리 대상>"
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
            Me.picTitle1.Size = New System.Drawing.Size(790, 29)
            Me.picTitle1.TabIndex = 1843
            Me.picTitle1.TabStop = False
            '
            'PSF102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblCriteria)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.popChargeEmpNum_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpToColDt)
            Me.Controls.Add(Me.lblHahaha)
            Me.Controls.Add(Me.dtpFromColDt)
            Me.Controls.Add(Me.lblColDt)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSF102"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.lblColDt, 0)
            Me.Controls.SetChildIndex(Me.dtpFromColDt, 0)
            Me.Controls.SetChildIndex(Me.lblHahaha, 0)
            Me.Controls.SetChildIndex(Me.dtpToColDt, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum_R, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd_R, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
 
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpToColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblHahaha As System.Windows.Forms.Label
        Friend WithEvents dtpFromColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblColDt As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblCriteria As System.Windows.Forms.Label
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
 
    End Class 
 
End Namespace 