Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSE102 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSE102))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.numWeekNum = New ubiLease.CommonControls.num
            Me.Label23 = New System.Windows.Forms.Label
            Me.dtpBaseYearMonths = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.txtBranchNm = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
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
            Me.picCriteria.TabIndex = 1
            Me.picCriteria.TabStop = False
            '
            'numWeekNum
            '
            Me.numWeekNum.BackColor = System.Drawing.SystemColors.Window
            Me.numWeekNum.BorderColor = System.Drawing.Color.Empty
            Me.numWeekNum.BorderStyle = 2
            Me.numWeekNum.CaptionName = "확장 주차"
            Me.numWeekNum.LengthPrecision = 15
            Me.numWeekNum.LengthScale = 0
            Me.numWeekNum.Location = New System.Drawing.Point(186, 14)
            Me.numWeekNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numWeekNum.MaxLength = 32767
            Me.numWeekNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numWeekNum.Name = "numWeekNum"
            Me.numWeekNum.ReadOnlys = False
            Me.numWeekNum.SelectedText = ""
            Me.numWeekNum.SelectionLength = 0
            Me.numWeekNum.SelectionStart = 1
            Me.numWeekNum.Size = New System.Drawing.Size(42, 20)
            Me.numWeekNum.TabIndex = 1632
            Me.numWeekNum.Tag = "init(1);"
            Me.numWeekNum.TextValue = "0"
            Me.numWeekNum.ToolTipText = ""
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label23.Location = New System.Drawing.Point(229, 17)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(29, 12)
            Me.Label23.TabIndex = 1639
            Me.Label23.Text = "주차"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBaseYearMonths
            '
            Me.dtpBaseYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYearMonths.BorderStyle = 2
            Me.dtpBaseYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYearMonths.CaptionName = "확장 년월"
            Me.dtpBaseYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYearMonths.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYearMonths.Location = New System.Drawing.Point(110, 14)
            Me.dtpBaseYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYearMonths.MaxLength = 0
            Me.dtpBaseYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYearMonths.Name = "dtpBaseYearMonths"
            Me.dtpBaseYearMonths.ReadOnlys = False
            Me.dtpBaseYearMonths.SelectedText = ""
            Me.dtpBaseYearMonths.SelectionLength = 0
            Me.dtpBaseYearMonths.SelectionStart = 0
            Me.dtpBaseYearMonths.Size = New System.Drawing.Size(74, 20)
            Me.dtpBaseYearMonths.TabIndex = 1635
            Me.dtpBaseYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpBaseYearMonths.TextAlign = 0
            Me.dtpBaseYearMonths.TextValue = ""
            Me.dtpBaseYearMonths.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(31, 19)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(74, 15)
            Me.Label3.TabIndex = 1638
            Me.Label3.Text = "확장 년월"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "영업사원 명"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 50
            Me.popEmployeeNumber.Enabled = False
            Me.popEmployeeNumber.Location = New System.Drawing.Point(110, 38)
            Me.popEmployeeNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeNumber.MaxLength = 6
            Me.popEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeNumber.Name = "popEmployeeNumber"
            Me.popEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeNumber.NameText = ""
            Me.popEmployeeNumber.ReadOnlys = False
            Me.popEmployeeNumber.SelectedText = ""
            Me.popEmployeeNumber.SelectionLength = 0
            Me.popEmployeeNumber.SelectionStart = 0
            Me.popEmployeeNumber.Size = New System.Drawing.Size(226, 20)
            Me.popEmployeeNumber.TabIndex = 1633
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'txtBranchNm
            '
            Me.txtBranchNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm.BorderStyle = 2
            Me.txtBranchNm.CaptionName = Nothing
            Me.txtBranchNm.Location = New System.Drawing.Point(424, 38)
            Me.txtBranchNm.MaxLength = 32767
            Me.txtBranchNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm.Multiline = False
            Me.txtBranchNm.Name = "txtBranchNm"
            Me.txtBranchNm.ReadOnlys = False
            Me.txtBranchNm.SelectedText = ""
            Me.txtBranchNm.SelectionLength = 0
            Me.txtBranchNm.SelectionStart = 0
            Me.txtBranchNm.Size = New System.Drawing.Size(209, 20)
            Me.txtBranchNm.TabIndex = 1634
            Me.txtBranchNm.Tag = Nothing
            Me.txtBranchNm.TextAlign = 0
            Me.txtBranchNm.TextValue = ""
            Me.txtBranchNm.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(360, 38)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 20)
            Me.Label2.TabIndex = 1637
            Me.Label2.Text = "지국명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label20.Location = New System.Drawing.Point(30, 38)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(74, 20)
            Me.Label20.TabIndex = 1636
            Me.Label20.Text = "영업담당자"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.lblTitle1.Size = New System.Drawing.Size(243, 12)
            Me.lblTitle1.TabIndex = 1864
            Me.lblTitle1.Text = "<지국확장비 비용 발생 전표 처리 대상>"
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
            'PSE102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.numWeekNum)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.dtpBaseYearMonths)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.txtBranchNm)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSE102"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label20, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.txtBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYearMonths, 0)
            Me.Controls.SetChildIndex(Me.Label23, 0)
            Me.Controls.SetChildIndex(Me.numWeekNum, 0)
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
        Friend WithEvents numWeekNum As ubiLease.CommonControls.num
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents txtBranchNm As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox

    End Class 
 
End Namespace 