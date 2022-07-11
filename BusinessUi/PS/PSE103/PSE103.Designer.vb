Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSE103 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSE103))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblDeduType_R = New System.Windows.Forms.Label
            Me.cboDeduType_R = New ubiLease.CommonControls.cbo
            Me.popChargeEmpNum_R = New ubiLease.CommonControls.pop
            Me.Label20 = New System.Windows.Forms.Label
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpDeduYYmm = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
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
            'lblDeduType_R
            '
            Me.lblDeduType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDeduType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblDeduType_R.Location = New System.Drawing.Point(371, 17)
            Me.lblDeduType_R.Name = "lblDeduType_R"
            Me.lblDeduType_R.Size = New System.Drawing.Size(81, 12)
            Me.lblDeduType_R.TabIndex = 3
            Me.lblDeduType_R.Text = "지원비항목"
            Me.lblDeduType_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboDeduType_R
            '
            Me.cboDeduType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboDeduType_R.CaptionName = "공제구분코드"
            Me.cboDeduType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboDeduType_R.ListCount = 0
            Me.cboDeduType_R.Location = New System.Drawing.Point(455, 12)
            Me.cboDeduType_R.MaxLength = 5
            Me.cboDeduType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboDeduType_R.Name = "cboDeduType_R"
            Me.cboDeduType_R.ReadOnlys = False
            Me.cboDeduType_R.Size = New System.Drawing.Size(231, 20)
            Me.cboDeduType_R.TabIndex = 4
            Me.cboDeduType_R.Tag = "code(판매매출 지원비구분);"
            Me.cboDeduType_R.TextValue = ""
            '
            'popChargeEmpNum_R
            '
            Me.popChargeEmpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_R.BorderStyle = 2
            Me.popChargeEmpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_R.CaptionName = "영업사원 명"
            Me.popChargeEmpNum_R.CodeText = ""
            Me.popChargeEmpNum_R.CodeWidth = 50
            Me.popChargeEmpNum_R.Location = New System.Drawing.Point(125, 38)
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
            Me.popChargeEmpNum_R.Size = New System.Drawing.Size(226, 20)
            Me.popChargeEmpNum_R.TabIndex = 11
            Me.popChargeEmpNum_R.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_R.TextAlign = 0
            Me.popChargeEmpNum_R.TextValue = ""
            Me.popChargeEmpNum_R.ToolTipText = ""
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label20.Location = New System.Drawing.Point(45, 38)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(74, 20)
            Me.Label20.TabIndex = 15
            Me.Label20.Text = "영업담당자"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBranchCd_R
            '
            Me.popBranchCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd_R.BorderStyle = 2
            Me.popBranchCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd_R.CaptionName = "지국 명"
            Me.popBranchCd_R.CodeText = ""
            Me.popBranchCd_R.CodeWidth = 60
            Me.popBranchCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popBranchCd_R.Location = New System.Drawing.Point(455, 38)
            Me.popBranchCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd_R.MaxLength = 7
            Me.popBranchCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd_R.Name = "popBranchCd_R"
            Me.popBranchCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd_R.NameText = ""
            Me.popBranchCd_R.ReadOnlys = False
            Me.popBranchCd_R.SelectedText = ""
            Me.popBranchCd_R.SelectionLength = 0
            Me.popBranchCd_R.SelectionStart = 0
            Me.popBranchCd_R.Size = New System.Drawing.Size(231, 20)
            Me.popBranchCd_R.TabIndex = 12
            Me.popBranchCd_R.Tag = "code(지국코드);"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(371, 41)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(81, 15)
            Me.Label2.TabIndex = 16
            Me.Label2.Text = "지국 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpDeduYYmm
            '
            Me.dtpDeduYYmm.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDeduYYmm.BorderColor = System.Drawing.Color.Empty
            Me.dtpDeduYYmm.BorderStyle = 2
            Me.dtpDeduYYmm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDeduYYmm.CaptionName = "기준 년월"
            Me.dtpDeduYYmm.DateTimeFormatText = "yyyy-MM"
            Me.dtpDeduYYmm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpDeduYYmm.Location = New System.Drawing.Point(125, 14)
            Me.dtpDeduYYmm.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDeduYYmm.MaxLength = 0
            Me.dtpDeduYYmm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDeduYYmm.Name = "dtpDeduYYmm"
            Me.dtpDeduYYmm.ReadOnlys = False
            Me.dtpDeduYYmm.SelectedText = ""
            Me.dtpDeduYYmm.SelectionLength = 0
            Me.dtpDeduYYmm.SelectionStart = 0
            Me.dtpDeduYYmm.Size = New System.Drawing.Size(100, 20)
            Me.dtpDeduYYmm.TabIndex = 9
            Me.dtpDeduYYmm.Tag = "format(&&&&-&&);"
            Me.dtpDeduYYmm.TextAlign = 0
            Me.dtpDeduYYmm.TextValue = ""
            Me.dtpDeduYYmm.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(55, 17)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(64, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 13
            Me.lblCodeDivisionHangulName.Text = "기준 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
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
            Me.grd_1.TabIndex = 1862
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(12, 74)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(204, 12)
            Me.lblTitle1.TabIndex = 1864
            Me.lblTitle1.Text = "<기타 비용 발생 전표 처리 대상>"
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
            Me.picTitle1.TabIndex = 1863
            Me.picTitle1.TabStop = False
            '
            'PSE103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.popChargeEmpNum_R)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDeduYYmm)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.lblDeduType_R)
            Me.Controls.Add(Me.cboDeduType_R)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSE103"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.cboDeduType_R, 0)
            Me.Controls.SetChildIndex(Me.lblDeduType_R, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpDeduYYmm, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label20, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum_R, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub



        Friend WithEvents lblDeduType_R As System.Windows.Forms.Label
        Friend WithEvents cboDeduType_R As ubiLease.CommonControls.cbo
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents popChargeEmpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpDeduYYmm As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
 
    End Class 
 
End Namespace 