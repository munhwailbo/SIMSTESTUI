Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSA104 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSA104))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblSaleDateFr_R = New System.Windows.Forms.Label
            Me.dtpSaleDateFr_R = New ubiLease.CommonControls.dtp
            Me.lblSaleDateTo_R = New System.Windows.Forms.Label
            Me.dtpSaleDateTo_R = New ubiLease.CommonControls.dtp
            Me.Label7 = New System.Windows.Forms.Label
            Me.cboSaleTypeCd_R = New ubiLease.CommonControls.cbo
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
            Me.grd_1.Location = New System.Drawing.Point(5, 91)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 544)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 5
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblSaleDateFr_R
            '
            Me.lblSaleDateFr_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleDateFr_R.Location = New System.Drawing.Point(37, 42)
            Me.lblSaleDateFr_R.Name = "lblSaleDateFr_R"
            Me.lblSaleDateFr_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleDateFr_R.TabIndex = 45
            Me.lblSaleDateFr_R.Text = "기준일자"
            Me.lblSaleDateFr_R.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpSaleDateFr_R
            '
            Me.dtpSaleDateFr_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSaleDateFr_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpSaleDateFr_R.BorderStyle = 2
            Me.dtpSaleDateFr_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSaleDateFr_R.CaptionName = "매출시작일자"
            Me.dtpSaleDateFr_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSaleDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSaleDateFr_R.Location = New System.Drawing.Point(132, 37)
            Me.dtpSaleDateFr_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDateFr_R.MaxLength = 0
            Me.dtpSaleDateFr_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDateFr_R.Name = "dtpSaleDateFr_R"
            Me.dtpSaleDateFr_R.ReadOnlys = False
            Me.dtpSaleDateFr_R.SelectedText = ""
            Me.dtpSaleDateFr_R.SelectionLength = 0
            Me.dtpSaleDateFr_R.SelectionStart = 0
            Me.dtpSaleDateFr_R.Size = New System.Drawing.Size(108, 20)
            Me.dtpSaleDateFr_R.TabIndex = 46
            Me.dtpSaleDateFr_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDateFr_R.TextAlign = 0
            Me.dtpSaleDateFr_R.TextValue = "[1]dtpSaleDateFr_R"
            Me.dtpSaleDateFr_R.ToolTipText = "매출시작일자"
            '
            'lblSaleDateTo_R
            '
            Me.lblSaleDateTo_R.AutoSize = True
            Me.lblSaleDateTo_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleDateTo_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleDateTo_R.Location = New System.Drawing.Point(243, 42)
            Me.lblSaleDateTo_R.Name = "lblSaleDateTo_R"
            Me.lblSaleDateTo_R.Size = New System.Drawing.Size(14, 12)
            Me.lblSaleDateTo_R.TabIndex = 47
            Me.lblSaleDateTo_R.Text = "~"
            Me.lblSaleDateTo_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpSaleDateTo_R
            '
            Me.dtpSaleDateTo_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSaleDateTo_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpSaleDateTo_R.BorderStyle = 2
            Me.dtpSaleDateTo_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSaleDateTo_R.CaptionName = "매출종료일자"
            Me.dtpSaleDateTo_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSaleDateTo_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSaleDateTo_R.Location = New System.Drawing.Point(261, 37)
            Me.dtpSaleDateTo_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDateTo_R.MaxLength = 0
            Me.dtpSaleDateTo_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDateTo_R.Name = "dtpSaleDateTo_R"
            Me.dtpSaleDateTo_R.ReadOnlys = False
            Me.dtpSaleDateTo_R.SelectedText = ""
            Me.dtpSaleDateTo_R.SelectionLength = 0
            Me.dtpSaleDateTo_R.SelectionStart = 0
            Me.dtpSaleDateTo_R.Size = New System.Drawing.Size(108, 20)
            Me.dtpSaleDateTo_R.TabIndex = 48
            Me.dtpSaleDateTo_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDateTo_R.TextAlign = 0
            Me.dtpSaleDateTo_R.TextValue = "[2]dtpSaleDateTo_R"
            Me.dtpSaleDateTo_R.ToolTipText = "매출종료일자"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label7.Location = New System.Drawing.Point(37, 17)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(95, 12)
            Me.Label7.TabIndex = 1580
            Me.Label7.Text = "판매매출구분"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboSaleTypeCd_R
            '
            Me.cboSaleTypeCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSaleTypeCd_R.CaptionName = "판매매출구분"
            Me.cboSaleTypeCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSaleTypeCd_R.ListCount = 0
            Me.cboSaleTypeCd_R.Location = New System.Drawing.Point(132, 12)
            Me.cboSaleTypeCd_R.MaxLength = 10
            Me.cboSaleTypeCd_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSaleTypeCd_R.Name = "cboSaleTypeCd_R"
            Me.cboSaleTypeCd_R.ReadOnlys = False
            Me.cboSaleTypeCd_R.Size = New System.Drawing.Size(237, 20)
            Me.cboSaleTypeCd_R.TabIndex = 1581
            Me.cboSaleTypeCd_R.Tag = "code(판매매출구분);"
            Me.cboSaleTypeCd_R.TextValue = ""
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(16, 73)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(206, 12)
            Me.lblTitle1.TabIndex = 1583
            Me.lblTitle1.Text = "업체 매출(구독권) 기초 자료 내역"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.Location = New System.Drawing.Point(5, 68)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(790, 23)
            Me.picTitle1.TabIndex = 1582
            Me.picTitle1.TabStop = False
            '
            'PSA104
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cboSaleTypeCd_R)
            Me.Controls.Add(Me.lblSaleDateFr_R)
            Me.Controls.Add(Me.dtpSaleDateFr_R)
            Me.Controls.Add(Me.lblSaleDateTo_R)
            Me.Controls.Add(Me.dtpSaleDateTo_R)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSA104"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleDateTo_R, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.cboSaleTypeCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub





        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblSaleDateFr_R As System.Windows.Forms.Label
        Friend WithEvents dtpSaleDateFr_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblSaleDateTo_R As System.Windows.Forms.Label
        Friend WithEvents dtpSaleDateTo_R As ubiLease.CommonControls.dtp
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cboSaleTypeCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
 
    End Class 
 
End Namespace 