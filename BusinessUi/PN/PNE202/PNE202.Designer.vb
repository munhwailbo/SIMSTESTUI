Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE202
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE202))
            Me.btnCreateSale = New ubiLease.CommonControls.btn
            Me.dtpPayYearMonths = New ubiLease.CommonControls.dtp
            Me.lblCollect = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.popTrAdEmployeeNum = New ubiLease.CommonControls.pop
            Me.Label17 = New System.Windows.Forms.Label
            Me.dtpToPayYearMonths = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpFromPayYearMonths = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.popDeptName = New ubiLease.CommonControls.pop
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnApplyClose = New ubiLease.CommonControls.btn
            Me.btnCancelClose = New ubiLease.CommonControls.btn
            Me.dtpReversionYearMonth = New ubiLease.CommonControls.dtp
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreateSale
            '
            Me.btnCreateSale.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreateSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreateSale.Location = New System.Drawing.Point(473, 16)
            Me.btnCreateSale.Name = "btnCreateSale"
            Me.btnCreateSale.Size = New System.Drawing.Size(114, 26)
            Me.btnCreateSale.TabIndex = 6
            Me.btnCreateSale.Text = "사원 확장비 생성"
            Me.btnCreateSale.UseVisualStyleBackColor = True
            '
            'dtpPayYearMonths
            '
            Me.dtpPayYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPayYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpPayYearMonths.BorderStyle = 2
            Me.dtpPayYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPayYearMonths.CaptionName = "지급년월"
            Me.dtpPayYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpPayYearMonths.Location = New System.Drawing.Point(371, 19)
            Me.dtpPayYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPayYearMonths.MaxLength = 0
            Me.dtpPayYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPayYearMonths.Name = "dtpPayYearMonths"
            Me.dtpPayYearMonths.ReadOnlys = False
            Me.dtpPayYearMonths.SelectedText = ""
            Me.dtpPayYearMonths.SelectionLength = 0
            Me.dtpPayYearMonths.SelectionStart = 0
            Me.dtpPayYearMonths.Size = New System.Drawing.Size(96, 20)
            Me.dtpPayYearMonths.TabIndex = 5
            Me.dtpPayYearMonths.TabStop = False
            Me.dtpPayYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpPayYearMonths.TextAlign = 0
            Me.dtpPayYearMonths.TextValue = ""
            Me.dtpPayYearMonths.ToolTipText = ""
            '
            'lblCollect
            '
            Me.lblCollect.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCollect.Location = New System.Drawing.Point(18, 22)
            Me.lblCollect.Name = "lblCollect"
            Me.lblCollect.Size = New System.Drawing.Size(65, 15)
            Me.lblCollect.TabIndex = 1623
            Me.lblCollect.Text = "확장년월"
            Me.lblCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 84)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 558)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1622
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 74)
            Me.picCriteria_1.TabIndex = 1621
            Me.picCriteria_1.TabStop = False
            '
            'popTrAdEmployeeNum
            '
            Me.popTrAdEmployeeNum.BorderColor = System.Drawing.Color.Empty
            Me.popTrAdEmployeeNum.BorderStyle = 2
            Me.popTrAdEmployeeNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTrAdEmployeeNum.CaptionName = "권유자 코드"
            Me.popTrAdEmployeeNum.CodeText = ""
            Me.popTrAdEmployeeNum.CodeWidth = 60
            Me.popTrAdEmployeeNum.Location = New System.Drawing.Point(89, 45)
            Me.popTrAdEmployeeNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popTrAdEmployeeNum.MaxLength = 6
            Me.popTrAdEmployeeNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popTrAdEmployeeNum.Name = "popTrAdEmployeeNum"
            Me.popTrAdEmployeeNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popTrAdEmployeeNum.NameText = ""
            Me.popTrAdEmployeeNum.ReadOnlys = False
            Me.popTrAdEmployeeNum.SelectedText = ""
            Me.popTrAdEmployeeNum.SelectionLength = 0
            Me.popTrAdEmployeeNum.SelectionStart = 0
            Me.popTrAdEmployeeNum.Size = New System.Drawing.Size(216, 20)
            Me.popTrAdEmployeeNum.TabIndex = 3
            Me.popTrAdEmployeeNum.Tag = "code(사원 명);rtnValue(popTrAdEmployeeDeptCd);"
            Me.popTrAdEmployeeNum.TextAlign = 0
            Me.popTrAdEmployeeNum.TextValue = ""
            Me.popTrAdEmployeeNum.ToolTipText = ""
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label17.Location = New System.Drawing.Point(30, 48)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(54, 17)
            Me.Label17.TabIndex = 1627
            Me.Label17.Text = "권유자명"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpToPayYearMonths
            '
            Me.dtpToPayYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToPayYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpToPayYearMonths.BorderStyle = 2
            Me.dtpToPayYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToPayYearMonths.CaptionName = "지급년월"
            Me.dtpToPayYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpToPayYearMonths.Location = New System.Drawing.Point(209, 19)
            Me.dtpToPayYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToPayYearMonths.MaxLength = 0
            Me.dtpToPayYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToPayYearMonths.Name = "dtpToPayYearMonths"
            Me.dtpToPayYearMonths.ReadOnlys = False
            Me.dtpToPayYearMonths.SelectedText = ""
            Me.dtpToPayYearMonths.SelectionLength = 0
            Me.dtpToPayYearMonths.SelectionStart = 0
            Me.dtpToPayYearMonths.Size = New System.Drawing.Size(96, 20)
            Me.dtpToPayYearMonths.TabIndex = 2
            Me.dtpToPayYearMonths.TabStop = False
            Me.dtpToPayYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpToPayYearMonths.TextAlign = 0
            Me.dtpToPayYearMonths.TextValue = ""
            Me.dtpToPayYearMonths.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(187, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(16, 20)
            Me.Label1.TabIndex = 1629
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpFromPayYearMonths
            '
            Me.dtpFromPayYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromPayYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromPayYearMonths.BorderStyle = 2
            Me.dtpFromPayYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromPayYearMonths.CaptionName = "지급년월"
            Me.dtpFromPayYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpFromPayYearMonths.Location = New System.Drawing.Point(89, 19)
            Me.dtpFromPayYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromPayYearMonths.MaxLength = 0
            Me.dtpFromPayYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromPayYearMonths.Name = "dtpFromPayYearMonths"
            Me.dtpFromPayYearMonths.ReadOnlys = False
            Me.dtpFromPayYearMonths.SelectedText = ""
            Me.dtpFromPayYearMonths.SelectionLength = 0
            Me.dtpFromPayYearMonths.SelectionStart = 0
            Me.dtpFromPayYearMonths.Size = New System.Drawing.Size(96, 20)
            Me.dtpFromPayYearMonths.TabIndex = 1
            Me.dtpFromPayYearMonths.TabStop = False
            Me.dtpFromPayYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpFromPayYearMonths.TextAlign = 0
            Me.dtpFromPayYearMonths.TextValue = ""
            Me.dtpFromPayYearMonths.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(311, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 17)
            Me.Label2.TabIndex = 1630
            Me.Label2.Text = "생성년월"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popDeptName
            '
            Me.popDeptName.BorderColor = System.Drawing.Color.Empty
            Me.popDeptName.BorderStyle = 2
            Me.popDeptName.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeptName.CaptionName = "권유자 코드"
            Me.popDeptName.CodeText = ""
            Me.popDeptName.CodeWidth = 60
            Me.popDeptName.Location = New System.Drawing.Point(371, 45)
            Me.popDeptName.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popDeptName.MaxLength = 6
            Me.popDeptName.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popDeptName.Name = "popDeptName"
            Me.popDeptName.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popDeptName.NameText = ""
            Me.popDeptName.ReadOnlys = False
            Me.popDeptName.SelectedText = ""
            Me.popDeptName.SelectionLength = 0
            Me.popDeptName.SelectionStart = 0
            Me.popDeptName.Size = New System.Drawing.Size(216, 20)
            Me.popDeptName.TabIndex = 4
            Me.popDeptName.Tag = "code(부서 명);rtnValue(popDeptCd);"
            Me.popDeptName.TextAlign = 0
            Me.popDeptName.TextValue = ""
            Me.popDeptName.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(312, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(53, 17)
            Me.Label3.TabIndex = 1633
            Me.Label3.Text = "부 서 명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(609, 21)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 17)
            Me.Label4.TabIndex = 1635
            Me.Label4.Text = "마감년월"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnApplyClose
            '
            Me.btnApplyClose.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApplyClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnApplyClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApplyClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnApplyClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnApplyClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnApplyClose.Location = New System.Drawing.Point(611, 45)
            Me.btnApplyClose.Name = "btnApplyClose"
            Me.btnApplyClose.Size = New System.Drawing.Size(74, 19)
            Me.btnApplyClose.TabIndex = 8
            Me.btnApplyClose.Text = "마감"
            Me.btnApplyClose.UseVisualStyleBackColor = True
            '
            'btnCancelClose
            '
            Me.btnCancelClose.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCancelClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCancelClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCancelClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCancelClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCancelClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCancelClose.Location = New System.Drawing.Point(691, 45)
            Me.btnCancelClose.Name = "btnCancelClose"
            Me.btnCancelClose.Size = New System.Drawing.Size(74, 19)
            Me.btnCancelClose.TabIndex = 9
            Me.btnCancelClose.Text = "마감취소"
            Me.btnCancelClose.UseVisualStyleBackColor = True
            '
            'dtpReversionYearMonth
            '
            Me.dtpReversionYearMonth.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReversionYearMonth.BorderColor = System.Drawing.Color.Empty
            Me.dtpReversionYearMonth.BorderStyle = 2
            Me.dtpReversionYearMonth.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReversionYearMonth.CaptionName = "지급년월"
            Me.dtpReversionYearMonth.DateTimeFormatText = "yyyy-MM"
            Me.dtpReversionYearMonth.Location = New System.Drawing.Point(669, 19)
            Me.dtpReversionYearMonth.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReversionYearMonth.MaxLength = 0
            Me.dtpReversionYearMonth.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReversionYearMonth.Name = "dtpReversionYearMonth"
            Me.dtpReversionYearMonth.ReadOnlys = False
            Me.dtpReversionYearMonth.SelectedText = ""
            Me.dtpReversionYearMonth.SelectionLength = 0
            Me.dtpReversionYearMonth.SelectionStart = 0
            Me.dtpReversionYearMonth.Size = New System.Drawing.Size(96, 20)
            Me.dtpReversionYearMonth.TabIndex = 7
            Me.dtpReversionYearMonth.TabStop = False
            Me.dtpReversionYearMonth.Tag = "format(&&&&-&&);"
            Me.dtpReversionYearMonth.TextAlign = 0
            Me.dtpReversionYearMonth.TextValue = ""
            Me.dtpReversionYearMonth.ToolTipText = ""
            '
            'PNE202
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpReversionYearMonth)
            Me.Controls.Add(Me.btnCancelClose)
            Me.Controls.Add(Me.btnApplyClose)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.popDeptName)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpFromPayYearMonths)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpToPayYearMonths)
            Me.Controls.Add(Me.popTrAdEmployeeNum)
            Me.Controls.Add(Me.btnCreateSale)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.dtpPayYearMonths)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblCollect)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNE202"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCollect, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.dtpPayYearMonths, 0)
            Me.Controls.SetChildIndex(Me.Label17, 0)
            Me.Controls.SetChildIndex(Me.btnCreateSale, 0)
            Me.Controls.SetChildIndex(Me.popTrAdEmployeeNum, 0)
            Me.Controls.SetChildIndex(Me.dtpToPayYearMonths, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.dtpFromPayYearMonths, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.popDeptName, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.btnApplyClose, 0)
            Me.Controls.SetChildIndex(Me.btnCancelClose, 0)
            Me.Controls.SetChildIndex(Me.dtpReversionYearMonth, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCreateSale As ubiLease.CommonControls.btn
        Friend WithEvents dtpPayYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents lblCollect As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents popTrAdEmployeeNum As ubiLease.CommonControls.pop
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents dtpToPayYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFromPayYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popDeptName As ubiLease.CommonControls.pop
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnApplyClose As ubiLease.CommonControls.btn
        Friend WithEvents btnCancelClose As ubiLease.CommonControls.btn
        Friend WithEvents dtpReversionYearMonth As ubiLease.CommonControls.dtp


    End Class

End Namespace
