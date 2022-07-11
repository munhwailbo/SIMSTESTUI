Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSE104 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSE104))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpStYYmm_R = New ubiLease.CommonControls.dtp
            Me.lblDeliYYmm_R = New System.Windows.Forms.Label
            Me.lblDeliType_R = New System.Windows.Forms.Label
            Me.cboDeliType_R = New ubiLease.CommonControls.cbo
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
            Me.picCriteria.TabIndex = 8
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
            Me.grd_1.TabIndex = 7
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpStYYmm_R
            '
            Me.dtpStYYmm_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpStYYmm_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpStYYmm_R.BorderStyle = 2
            Me.dtpStYYmm_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpStYYmm_R.CaptionName = "발행년월"
            Me.dtpStYYmm_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpStYYmm_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpStYYmm_R.Location = New System.Drawing.Point(145, 25)
            Me.dtpStYYmm_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpStYYmm_R.MaxLength = 0
            Me.dtpStYYmm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpStYYmm_R.Name = "dtpStYYmm_R"
            Me.dtpStYYmm_R.ReadOnlys = False
            Me.dtpStYYmm_R.SelectedText = ""
            Me.dtpStYYmm_R.SelectionLength = 0
            Me.dtpStYYmm_R.SelectionStart = 0
            Me.dtpStYYmm_R.Size = New System.Drawing.Size(78, 20)
            Me.dtpStYYmm_R.TabIndex = 1603
            Me.dtpStYYmm_R.Tag = "format(&&&&-&&);"
            Me.dtpStYYmm_R.TextAlign = 0
            Me.dtpStYYmm_R.TextValue = "[1]dtpPubYYmm_R"
            Me.dtpStYYmm_R.ToolTipText = "발행년월"
            '
            'lblDeliYYmm_R
            '
            Me.lblDeliYYmm_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDeliYYmm_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblDeliYYmm_R.Location = New System.Drawing.Point(44, 30)
            Me.lblDeliYYmm_R.Name = "lblDeliYYmm_R"
            Me.lblDeliYYmm_R.Size = New System.Drawing.Size(95, 12)
            Me.lblDeliYYmm_R.TabIndex = 1600
            Me.lblDeliYYmm_R.Text = "정산년월"
            Me.lblDeliYYmm_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDeliType_R
            '
            Me.lblDeliType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDeliType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblDeliType_R.Location = New System.Drawing.Point(289, 30)
            Me.lblDeliType_R.Name = "lblDeliType_R"
            Me.lblDeliType_R.Size = New System.Drawing.Size(95, 12)
            Me.lblDeliType_R.TabIndex = 1601
            Me.lblDeliType_R.Text = "배달비 구분"
            Me.lblDeliType_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboDeliType_R
            '
            Me.cboDeliType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboDeliType_R.CaptionName = "배달비 구분"
            Me.cboDeliType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboDeliType_R.ListCount = 0
            Me.cboDeliType_R.Location = New System.Drawing.Point(389, 25)
            Me.cboDeliType_R.MaxLength = 5
            Me.cboDeliType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboDeliType_R.Name = "cboDeliType_R"
            Me.cboDeliType_R.ReadOnlys = False
            Me.cboDeliType_R.Size = New System.Drawing.Size(181, 20)
            Me.cboDeliType_R.TabIndex = 1602
            Me.cboDeliType_R.Tag = "code(업체매출구분);"
            Me.cboDeliType_R.TextValue = ""
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(12, 73)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(217, 12)
            Me.lblTitle1.TabIndex = 1866
            Me.lblTitle1.Text = "<가수금 대체 수납 전표 처리 대상>"
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
            Me.picTitle1.Size = New System.Drawing.Size(790, 28)
            Me.picTitle1.TabIndex = 1865
            Me.picTitle1.TabStop = False
            '
            'PSE104
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.dtpStYYmm_R)
            Me.Controls.Add(Me.lblDeliYYmm_R)
            Me.Controls.Add(Me.lblDeliType_R)
            Me.Controls.Add(Me.cboDeliType_R)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSE104"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.cboDeliType_R, 0)
            Me.Controls.SetChildIndex(Me.lblDeliType_R, 0)
            Me.Controls.SetChildIndex(Me.lblDeliYYmm_R, 0)
            Me.Controls.SetChildIndex(Me.dtpStYYmm_R, 0)
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
        Friend WithEvents dtpStYYmm_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblDeliYYmm_R As System.Windows.Forms.Label
        Friend WithEvents lblDeliType_R As System.Windows.Forms.Label
        Friend WithEvents cboDeliType_R As ubiLease.CommonControls.cbo
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
 
    End Class 
 
End Namespace 