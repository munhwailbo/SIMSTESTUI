Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDB02
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDB02))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.dtpReceiptDateFrom = New ubiLease.CommonControls.dtp
            Me.lblDongCode = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo = New ubiLease.CommonControls.dtp
            Me.Label16 = New System.Windows.Forms.Label
            Me.popSystemID = New ubiLease.CommonControls.pop
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.picCriteria5 = New System.Windows.Forms.PictureBox
            Me.optDivision1 = New System.Windows.Forms.RadioButton
            Me.optDivision2 = New System.Windows.Forms.RadioButton
            Me.Label23 = New System.Windows.Forms.Label
            Me.popProjectID = New ubiLease.CommonControls.pop
            Me.optTotal = New System.Windows.Forms.RadioButton
            Me.OptYear = New System.Windows.Forms.RadioButton
            Me.OptMonth = New System.Windows.Forms.RadioButton
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.optleft = New System.Windows.Forms.RadioButton
            Me.opting = New System.Windows.Forms.RadioButton
            Me.optreceipt = New System.Windows.Forms.RadioButton
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label1 = New System.Windows.Forms.Label
            Me.cboWorkDivision = New ubiLease.CommonControls.cbo
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_1.GridColor = System.Drawing.SystemColors.MenuBar
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 69)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 250)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 100
            Me.grd_1.Tree.LineColor = System.Drawing.Color.DarkCyan
            Me.grd_1.TreeColor = System.Drawing.Color.DarkCyan
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(799, 57)
            Me.picCriteria.TabIndex = 70
            Me.picCriteria.TabStop = False
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(335, 16)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(53, 11)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "시스템"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpReceiptDateFrom
            '
            Me.dtpReceiptDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateFrom.BorderStyle = 2
            Me.dtpReceiptDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateFrom.CaptionName = "접수일자"
            Me.dtpReceiptDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateFrom.Location = New System.Drawing.Point(94, 38)
            Me.dtpReceiptDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFrom.MaxLength = 0
            Me.dtpReceiptDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFrom.Name = "dtpReceiptDateFrom"
            Me.dtpReceiptDateFrom.ReadOnlys = False
            Me.dtpReceiptDateFrom.SelectedText = ""
            Me.dtpReceiptDateFrom.SelectionLength = 0
            Me.dtpReceiptDateFrom.SelectionStart = 0
            Me.dtpReceiptDateFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDateFrom.TabIndex = 3
            Me.dtpReceiptDateFrom.TabStop = False
            Me.dtpReceiptDateFrom.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateFrom.TextAlign = 0
            Me.dtpReceiptDateFrom.TextValue = ""
            Me.dtpReceiptDateFrom.ToolTipText = ""
            '
            'lblDongCode
            '
            Me.lblDongCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDongCode.Location = New System.Drawing.Point(22, 40)
            Me.lblDongCode.Name = "lblDongCode"
            Me.lblDongCode.Size = New System.Drawing.Size(66, 13)
            Me.lblDongCode.TabIndex = 469
            Me.lblDongCode.Text = "기준 일자"
            Me.lblDongCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpReceiptDateTo
            '
            Me.dtpReceiptDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateTo.BorderStyle = 2
            Me.dtpReceiptDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateTo.CaptionName = "접수일"
            Me.dtpReceiptDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateTo.Location = New System.Drawing.Point(208, 38)
            Me.dtpReceiptDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo.MaxLength = 0
            Me.dtpReceiptDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo.Name = "dtpReceiptDateTo"
            Me.dtpReceiptDateTo.ReadOnlys = False
            Me.dtpReceiptDateTo.SelectedText = ""
            Me.dtpReceiptDateTo.SelectionLength = 0
            Me.dtpReceiptDateTo.SelectionStart = 0
            Me.dtpReceiptDateTo.Size = New System.Drawing.Size(94, 20)
            Me.dtpReceiptDateTo.TabIndex = 4
            Me.dtpReceiptDateTo.TabStop = False
            Me.dtpReceiptDateTo.Tag = "format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo.TextAlign = 0
            Me.dtpReceiptDateTo.TextValue = ""
            Me.dtpReceiptDateTo.ToolTipText = ""
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label16.Location = New System.Drawing.Point(191, 40)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(12, 14)
            Me.Label16.TabIndex = 469
            Me.Label16.Text = "~"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popSystemID
            '
            Me.popSystemID.BorderColor = System.Drawing.Color.Empty
            Me.popSystemID.BorderStyle = 2
            Me.popSystemID.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popSystemID.CaptionName = "시스템 ID"
            Me.popSystemID.CodeText = ""
            Me.popSystemID.CodeWidth = 60
            Me.popSystemID.Location = New System.Drawing.Point(389, 12)
            Me.popSystemID.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popSystemID.MaxLength = 5
            Me.popSystemID.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popSystemID.Name = "popSystemID"
            Me.popSystemID.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popSystemID.NameText = ""
            Me.popSystemID.ReadOnlys = False
            Me.popSystemID.SelectedText = ""
            Me.popSystemID.SelectionLength = 0
            Me.popSystemID.SelectionStart = 0
            Me.popSystemID.Size = New System.Drawing.Size(206, 20)
            Me.popSystemID.TabIndex = 606
            Me.popSystemID.Tag = "code(시스템 명);"
            Me.popSystemID.TextAlign = 0
            Me.popSystemID.TextValue = ""
            Me.popSystemID.ToolTipText = ""
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(5, 356)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(799, 288)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 607
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria5
            '
            Me.picCriteria5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria5.Location = New System.Drawing.Point(5, 323)
            Me.picCriteria5.Name = "picCriteria5"
            Me.picCriteria5.Size = New System.Drawing.Size(799, 29)
            Me.picCriteria5.TabIndex = 608
            Me.picCriteria5.TabStop = False
            '
            'optDivision1
            '
            Me.optDivision1.AutoSize = True
            Me.optDivision1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optDivision1.Checked = True
            Me.optDivision1.Location = New System.Drawing.Point(25, 331)
            Me.optDivision1.Name = "optDivision1"
            Me.optDivision1.Size = New System.Drawing.Size(47, 16)
            Me.optDivision1.TabIndex = 705
            Me.optDivision1.TabStop = True
            Me.optDivision1.Text = "접수"
            Me.optDivision1.UseVisualStyleBackColor = False
            '
            'optDivision2
            '
            Me.optDivision2.AutoSize = True
            Me.optDivision2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optDivision2.Location = New System.Drawing.Point(78, 331)
            Me.optDivision2.Name = "optDivision2"
            Me.optDivision2.Size = New System.Drawing.Size(47, 16)
            Me.optDivision2.TabIndex = 706
            Me.optDivision2.Text = "처리"
            Me.optDivision2.UseVisualStyleBackColor = False
            '
            'Label23
            '
            Me.Label23.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label23.Location = New System.Drawing.Point(23, 16)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(69, 13)
            Me.Label23.TabIndex = 708
            Me.Label23.Text = "프로젝트"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popProjectID
            '
            Me.popProjectID.BorderColor = System.Drawing.Color.Empty
            Me.popProjectID.BorderStyle = 2
            Me.popProjectID.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popProjectID.CaptionName = "프로젝트ID"
            Me.popProjectID.CodeText = ""
            Me.popProjectID.CodeWidth = 60
            Me.popProjectID.Location = New System.Drawing.Point(94, 12)
            Me.popProjectID.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popProjectID.MaxLength = 4
            Me.popProjectID.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popProjectID.Name = "popProjectID"
            Me.popProjectID.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popProjectID.NameText = ""
            Me.popProjectID.ReadOnlys = False
            Me.popProjectID.SelectedText = ""
            Me.popProjectID.SelectionLength = 0
            Me.popProjectID.SelectionStart = 0
            Me.popProjectID.Size = New System.Drawing.Size(207, 20)
            Me.popProjectID.TabIndex = 707
            Me.popProjectID.Tag = "code(MH프로젝트 명);"
            Me.popProjectID.TextAlign = 0
            Me.popProjectID.TextValue = ""
            Me.popProjectID.ToolTipText = ""
            '
            'optTotal
            '
            Me.optTotal.AutoSize = True
            Me.optTotal.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optTotal.Location = New System.Drawing.Point(16, 8)
            Me.optTotal.Name = "optTotal"
            Me.optTotal.Size = New System.Drawing.Size(47, 16)
            Me.optTotal.TabIndex = 709
            Me.optTotal.Text = "전체"
            Me.optTotal.UseVisualStyleBackColor = False
            '
            'OptYear
            '
            Me.OptYear.AutoSize = True
            Me.OptYear.BackColor = System.Drawing.Color.WhiteSmoke
            Me.OptYear.Location = New System.Drawing.Point(82, 8)
            Me.OptYear.Name = "OptYear"
            Me.OptYear.Size = New System.Drawing.Size(47, 16)
            Me.OptYear.TabIndex = 710
            Me.OptYear.Text = "년간"
            Me.OptYear.UseVisualStyleBackColor = False
            '
            'OptMonth
            '
            Me.OptMonth.AutoSize = True
            Me.OptMonth.BackColor = System.Drawing.Color.WhiteSmoke
            Me.OptMonth.Checked = True
            Me.OptMonth.Location = New System.Drawing.Point(148, 8)
            Me.OptMonth.Name = "OptMonth"
            Me.OptMonth.Size = New System.Drawing.Size(47, 16)
            Me.OptMonth.TabIndex = 712
            Me.OptMonth.TabStop = True
            Me.OptMonth.Text = "월간"
            Me.OptMonth.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.GroupBox1.Controls.Add(Me.optTotal)
            Me.GroupBox1.Controls.Add(Me.OptMonth)
            Me.GroupBox1.Controls.Add(Me.OptYear)
            Me.GroupBox1.Location = New System.Drawing.Point(389, 30)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(217, 28)
            Me.GroupBox1.TabIndex = 713
            Me.GroupBox1.TabStop = False
            '
            'optleft
            '
            Me.optleft.AutoSize = True
            Me.optleft.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optleft.Location = New System.Drawing.Point(261, 331)
            Me.optleft.Name = "optleft"
            Me.optleft.Size = New System.Drawing.Size(47, 16)
            Me.optleft.TabIndex = 714
            Me.optleft.Text = "보류"
            Me.optleft.UseVisualStyleBackColor = False
            '
            'opting
            '
            Me.opting.AutoSize = True
            Me.opting.BackColor = System.Drawing.Color.WhiteSmoke
            Me.opting.Location = New System.Drawing.Point(196, 331)
            Me.opting.Name = "opting"
            Me.opting.Size = New System.Drawing.Size(59, 16)
            Me.opting.TabIndex = 715
            Me.opting.Text = "진행중"
            Me.opting.UseVisualStyleBackColor = False
            '
            'optreceipt
            '
            Me.optreceipt.AutoSize = True
            Me.optreceipt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optreceipt.Location = New System.Drawing.Point(131, 331)
            Me.optreceipt.Name = "optreceipt"
            Me.optreceipt.Size = New System.Drawing.Size(59, 16)
            Me.optreceipt.TabIndex = 716
            Me.optreceipt.Text = "접수중"
            Me.optreceipt.UseVisualStyleBackColor = False
            '
            'ToolTip1
            '
            Me.ToolTip1.AutoPopDelay = 20000
            Me.ToolTip1.InitialDelay = 100
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ReshowDelay = 50
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(570, 328)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 18)
            Me.Label1.TabIndex = 717
            Me.Label1.Text = "작업 구분"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboWorkDivision
            '
            Me.cboWorkDivision.CaptionName = "작업구분"
            Me.cboWorkDivision.ListCount = 0
            Me.cboWorkDivision.Location = New System.Drawing.Point(636, 327)
            Me.cboWorkDivision.Name = "cboWorkDivision"
            Me.cboWorkDivision.ReadOnlys = False
            Me.cboWorkDivision.Size = New System.Drawing.Size(157, 20)
            Me.cboWorkDivision.TabIndex = 718
            Me.cboWorkDivision.Tag = "code(작업 구분 명|전체);"
            Me.cboWorkDivision.TextValue = ""
            '
            'SMDB02
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.cboWorkDivision)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.optreceipt)
            Me.Controls.Add(Me.opting)
            Me.Controls.Add(Me.optleft)
            Me.Controls.Add(Me.optDivision1)
            Me.Controls.Add(Me.optDivision2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.popProjectID)
            Me.Controls.Add(Me.popSystemID)
            Me.Controls.Add(Me.dtpReceiptDateTo)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.dtpReceiptDateFrom)
            Me.Controls.Add(Me.lblDongCode)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria5)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "SMDB02"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.picCriteria5, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.lblDongCode, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateFrom, 0)
            Me.Controls.SetChildIndex(Me.Label16, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDateTo, 0)
            Me.Controls.SetChildIndex(Me.popSystemID, 0)
            Me.Controls.SetChildIndex(Me.popProjectID, 0)
            Me.Controls.SetChildIndex(Me.Label23, 0)
            Me.Controls.SetChildIndex(Me.GroupBox1, 0)
            Me.Controls.SetChildIndex(Me.optDivision2, 0)
            Me.Controls.SetChildIndex(Me.optDivision1, 0)
            Me.Controls.SetChildIndex(Me.optleft, 0)
            Me.Controls.SetChildIndex(Me.opting, 0)
            Me.Controls.SetChildIndex(Me.optreceipt, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.cboWorkDivision, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents lblDongCode As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents popSystemID As ubiLease.CommonControls.pop
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria5 As System.Windows.Forms.PictureBox
        Friend WithEvents optDivision1 As System.Windows.Forms.RadioButton
        Friend WithEvents optDivision2 As System.Windows.Forms.RadioButton
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents popProjectID As ubiLease.CommonControls.pop
        Friend WithEvents optTotal As System.Windows.Forms.RadioButton
        Friend WithEvents OptYear As System.Windows.Forms.RadioButton
        Friend WithEvents OptMonth As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents optleft As System.Windows.Forms.RadioButton
        Friend WithEvents opting As System.Windows.Forms.RadioButton
        Friend WithEvents optreceipt As System.Windows.Forms.RadioButton
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboWorkDivision As ubiLease.CommonControls.cbo

    End Class

End Namespace
