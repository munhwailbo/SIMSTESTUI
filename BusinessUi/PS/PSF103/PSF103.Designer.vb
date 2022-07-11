Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSF103 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSF103))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblDeduType_R = New System.Windows.Forms.Label
            Me.cboDeduType_R = New ubiLease.CommonControls.cbo
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpToColDt = New ubiLease.CommonControls.dtp
            Me.lblHahaha = New System.Windows.Forms.Label
            Me.dtpFromColDt = New ubiLease.CommonControls.dtp
            Me.lblColDt = New System.Windows.Forms.Label
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
            'lblDeduType_R
            '
            Me.lblDeduType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDeduType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblDeduType_R.Location = New System.Drawing.Point(364, 27)
            Me.lblDeduType_R.Name = "lblDeduType_R"
            Me.lblDeduType_R.Size = New System.Drawing.Size(95, 12)
            Me.lblDeduType_R.TabIndex = 14
            Me.lblDeduType_R.Text = "지원비항목"
            Me.lblDeduType_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboDeduType_R
            '
            Me.cboDeduType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboDeduType_R.CaptionName = "공제구분코드"
            Me.cboDeduType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboDeduType_R.ListCount = 0
            Me.cboDeduType_R.Location = New System.Drawing.Point(467, 22)
            Me.cboDeduType_R.MaxLength = 5
            Me.cboDeduType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboDeduType_R.Name = "cboDeduType_R"
            Me.cboDeduType_R.ReadOnlys = False
            Me.cboDeduType_R.Size = New System.Drawing.Size(191, 20)
            Me.cboDeduType_R.TabIndex = 15
            Me.cboDeduType_R.Tag = "code(판매매출 지원비구분);"
            Me.cboDeduType_R.TextValue = ""
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
            Me.grd_1.TabIndex = 18
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpToColDt
            '
            Me.dtpToColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpToColDt.BorderStyle = 2
            Me.dtpToColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToColDt.CaptionName = "입금일자"
            Me.dtpToColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToColDt.Location = New System.Drawing.Point(209, 22)
            Me.dtpToColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToColDt.MaxLength = 0
            Me.dtpToColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToColDt.Name = "dtpToColDt"
            Me.dtpToColDt.ReadOnlys = False
            Me.dtpToColDt.SelectedText = ""
            Me.dtpToColDt.SelectionLength = 0
            Me.dtpToColDt.SelectionStart = 0
            Me.dtpToColDt.Size = New System.Drawing.Size(95, 20)
            Me.dtpToColDt.TabIndex = 1712
            Me.dtpToColDt.TabStop = False
            Me.dtpToColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpToColDt.TextAlign = 0
            Me.dtpToColDt.TextValue = ""
            Me.dtpToColDt.ToolTipText = ""
            '
            'lblHahaha
            '
            Me.lblHahaha.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblHahaha.Location = New System.Drawing.Point(195, 25)
            Me.lblHahaha.Name = "lblHahaha"
            Me.lblHahaha.Size = New System.Drawing.Size(15, 15)
            Me.lblHahaha.TabIndex = 1714
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
            Me.dtpFromColDt.Location = New System.Drawing.Point(101, 22)
            Me.dtpFromColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromColDt.MaxLength = 0
            Me.dtpFromColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromColDt.Name = "dtpFromColDt"
            Me.dtpFromColDt.ReadOnlys = False
            Me.dtpFromColDt.SelectedText = ""
            Me.dtpFromColDt.SelectionLength = 0
            Me.dtpFromColDt.SelectionStart = 0
            Me.dtpFromColDt.Size = New System.Drawing.Size(95, 20)
            Me.dtpFromColDt.TabIndex = 1711
            Me.dtpFromColDt.TabStop = False
            Me.dtpFromColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpFromColDt.TextAlign = 0
            Me.dtpFromColDt.TextValue = ""
            Me.dtpFromColDt.ToolTipText = ""
            '
            'lblColDt
            '
            Me.lblColDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblColDt.Location = New System.Drawing.Point(30, 25)
            Me.lblColDt.Name = "lblColDt"
            Me.lblColDt.Size = New System.Drawing.Size(65, 15)
            Me.lblColDt.TabIndex = 1713
            Me.lblColDt.Text = "입금 일자"
            Me.lblColDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(11, 73)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(225, 12)
            Me.lblTitle1.TabIndex = 1868
            Me.lblTitle1.Text = "<기타비용 대체수납 전표 처리 대상>"
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
            Me.picTitle1.Size = New System.Drawing.Size(790, 27)
            Me.picTitle1.TabIndex = 1867
            Me.picTitle1.TabStop = False
            '
            'PSF103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.dtpToColDt)
            Me.Controls.Add(Me.lblHahaha)
            Me.Controls.Add(Me.dtpFromColDt)
            Me.Controls.Add(Me.lblColDt)
            Me.Controls.Add(Me.lblDeduType_R)
            Me.Controls.Add(Me.cboDeduType_R)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSF103"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.cboDeduType_R, 0)
            Me.Controls.SetChildIndex(Me.lblDeduType_R, 0)
            Me.Controls.SetChildIndex(Me.lblColDt, 0)
            Me.Controls.SetChildIndex(Me.dtpFromColDt, 0)
            Me.Controls.SetChildIndex(Me.lblHahaha, 0)
            Me.Controls.SetChildIndex(Me.dtpToColDt, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
 
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblDeduType_R As System.Windows.Forms.Label
        Friend WithEvents cboDeduType_R As ubiLease.CommonControls.cbo
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpToColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblHahaha As System.Windows.Forms.Label
        Friend WithEvents dtpFromColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblColDt As System.Windows.Forms.Label
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
 
    End Class 
 
End Namespace 