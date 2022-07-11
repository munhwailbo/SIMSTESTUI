Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSA101 
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSA101))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblSaleDateFr_R = New System.Windows.Forms.Label
            Me.dtpCalYearMonths_R = New ubiLease.CommonControls.dtp
            Me.lblChargeEmpNum_R = New System.Windows.Forms.Label
            Me.popChargeEmpNum_R = New ubiLease.CommonControls.pop
            Me.lblTitle = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.btnApply = New System.Windows.Forms.Button
            Me.dtpSaleDate = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
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
            Me.picCriteria.Location = New System.Drawing.Point(3, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(792, 60)
            Me.picCriteria.TabIndex = 9
            Me.picCriteria.TabStop = False
            '
            'lblSaleDateFr_R
            '
            Me.lblSaleDateFr_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaleDateFr_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSaleDateFr_R.Location = New System.Drawing.Point(18, 30)
            Me.lblSaleDateFr_R.Name = "lblSaleDateFr_R"
            Me.lblSaleDateFr_R.Size = New System.Drawing.Size(95, 12)
            Me.lblSaleDateFr_R.TabIndex = 1
            Me.lblSaleDateFr_R.Text = "청구년월"
            Me.lblSaleDateFr_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths_R
            '
            Me.dtpCalYearMonths_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths_R.BorderStyle = 2
            Me.dtpCalYearMonths_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths_R.CaptionName = "월청구년"
            Me.dtpCalYearMonths_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpCalYearMonths_R.Location = New System.Drawing.Point(116, 25)
            Me.dtpCalYearMonths_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths_R.MaxLength = 0
            Me.dtpCalYearMonths_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths_R.Name = "dtpCalYearMonths_R"
            Me.dtpCalYearMonths_R.ReadOnlys = False
            Me.dtpCalYearMonths_R.SelectedText = ""
            Me.dtpCalYearMonths_R.SelectionLength = 0
            Me.dtpCalYearMonths_R.SelectionStart = 0
            Me.dtpCalYearMonths_R.Size = New System.Drawing.Size(108, 20)
            Me.dtpCalYearMonths_R.TabIndex = 2
            Me.dtpCalYearMonths_R.Tag = "format(&&&&-&&);"
            Me.dtpCalYearMonths_R.TextAlign = 0
            Me.dtpCalYearMonths_R.TextValue = "[1]dtpCalYearMonths_R"
            Me.dtpCalYearMonths_R.ToolTipText = "청구년월"
            '
            'lblChargeEmpNum_R
            '
            Me.lblChargeEmpNum_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblChargeEmpNum_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblChargeEmpNum_R.Location = New System.Drawing.Point(297, 27)
            Me.lblChargeEmpNum_R.Name = "lblChargeEmpNum_R"
            Me.lblChargeEmpNum_R.Size = New System.Drawing.Size(95, 12)
            Me.lblChargeEmpNum_R.TabIndex = 5
            Me.lblChargeEmpNum_R.Text = "영업담당자"
            Me.lblChargeEmpNum_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popChargeEmpNum_R
            '
            Me.popChargeEmpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_R.BorderStyle = 2
            Me.popChargeEmpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_R.CaptionName = "영업사원 명"
            Me.popChargeEmpNum_R.CodeText = "[3] popChargeEmpNum_R"
            Me.popChargeEmpNum_R.CodeWidth = 50
            Me.popChargeEmpNum_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popChargeEmpNum_R.Location = New System.Drawing.Point(392, 22)
            Me.popChargeEmpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum_R.MaxLength = 6
            Me.popChargeEmpNum_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popChargeEmpNum_R.Name = "popChargeEmpNum_R"
            Me.popChargeEmpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_R.NameText = ""
            Me.popChargeEmpNum_R.ReadOnlys = False
            Me.popChargeEmpNum_R.SelectedText = ""
            Me.popChargeEmpNum_R.SelectionLength = 0
            Me.popChargeEmpNum_R.SelectionStart = 0
            Me.popChargeEmpNum_R.Size = New System.Drawing.Size(162, 20)
            Me.popChargeEmpNum_R.TabIndex = 6
            Me.popChargeEmpNum_R.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_R.TextAlign = 0
            Me.popChargeEmpNum_R.TextValue = "[3] popChargeEmpNum_R"
            Me.popChargeEmpNum_R.ToolTipText = "영업담당자"
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle.Location = New System.Drawing.Point(10, 75)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(173, 12)
            Me.lblTitle.TabIndex = 15
            Me.lblTitle.Text = "<지대 매출 기초 자료 내역>"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_1.Location = New System.Drawing.Point(3, 102)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(792, 532)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 13
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(3, 70)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(792, 33)
            Me.picTitle1.TabIndex = 14
            Me.picTitle1.TabStop = False
            '
            'btnApply
            '
            Me.btnApply.Location = New System.Drawing.Point(392, 74)
            Me.btnApply.Name = "btnApply"
            Me.btnApply.Size = New System.Drawing.Size(70, 26)
            Me.btnApply.TabIndex = 27
            Me.btnApply.Text = "적용"
            Me.btnApply.UseVisualStyleBackColor = True
            '
            'dtpSaleDate
            '
            Me.dtpSaleDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSaleDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpSaleDate.BorderStyle = 2
            Me.dtpSaleDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSaleDate.CaptionName = "매출시작일자"
            Me.dtpSaleDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSaleDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSaleDate.Location = New System.Drawing.Point(278, 77)
            Me.dtpSaleDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSaleDate.MaxLength = 0
            Me.dtpSaleDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSaleDate.Name = "dtpSaleDate"
            Me.dtpSaleDate.ReadOnlys = False
            Me.dtpSaleDate.SelectedText = ""
            Me.dtpSaleDate.SelectionLength = 0
            Me.dtpSaleDate.SelectionStart = 0
            Me.dtpSaleDate.Size = New System.Drawing.Size(108, 20)
            Me.dtpSaleDate.TabIndex = 28
            Me.dtpSaleDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpSaleDate.TextAlign = 0
            Me.dtpSaleDate.TextValue = "[1]dtpSaleDateFr_R"
            Me.dtpSaleDate.ToolTipText = "매출시작일자"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(222, 81)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 12)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "매출일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PSA101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpSaleDate)
            Me.Controls.Add(Me.btnApply)
            Me.Controls.Add(Me.lblTitle)
            Me.Controls.Add(Me.picTitle1)
            Me.Controls.Add(Me.lblSaleDateFr_R)
            Me.Controls.Add(Me.dtpCalYearMonths_R)
            Me.Controls.Add(Me.lblChargeEmpNum_R)
            Me.Controls.Add(Me.popChargeEmpNum_R)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PSA101"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum_R, 0)
            Me.Controls.SetChildIndex(Me.lblChargeEmpNum_R, 0)
            Me.Controls.SetChildIndex(Me.dtpCalYearMonths_R, 0)
            Me.Controls.SetChildIndex(Me.lblSaleDateFr_R, 0)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle, 0)
            Me.Controls.SetChildIndex(Me.btnApply, 0)
            Me.Controls.SetChildIndex(Me.dtpSaleDate, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblSaleDateFr_R As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths_R As ubiLease.CommonControls.dtp
        Friend WithEvents lblChargeEmpNum_R As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum_R As ubiLease.CommonControls.pop

        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents btnApply As System.Windows.Forms.Button
        Friend WithEvents dtpSaleDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label

    End Class 
 
End Namespace 