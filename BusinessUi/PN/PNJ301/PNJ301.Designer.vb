Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ301))
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popBranchNum_R = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.popCouponCorpCd_R = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.btnExec = New ubiLease.CommonControls.btn
            Me.btnApprovalAll = New ubiLease.CommonControls.btn
            Me.dtpProcDT = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "회수 년 월"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(105, 17)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear.TabIndex = 0
            Me.dtpBaseYear.Tag = "need;format(&&&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = ""
            Me.dtpBaseYear.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(32, 20)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(68, 14)
            Me.lblCodeDivisionHangulName.TabIndex = 1
            Me.lblCodeDivisionHangulName.Text = "회수 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 42)
            Me.picCriteria_1.TabIndex = 18
            Me.picCriteria_1.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(6, 94)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(802, 550)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 3
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popBranchNum_R
            '
            Me.popBranchNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchNum_R.BorderStyle = 2
            Me.popBranchNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchNum_R.CaptionName = "지국코드"
            Me.popBranchNum_R.CodeText = ""
            Me.popBranchNum_R.CodeWidth = 60
            Me.popBranchNum_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popBranchNum_R.Location = New System.Drawing.Point(679, 14)
            Me.popBranchNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchNum_R.MaxLength = 7
            Me.popBranchNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchNum_R.Name = "popBranchNum_R"
            Me.popBranchNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchNum_R.NameText = ""
            Me.popBranchNum_R.ReadOnlys = False
            Me.popBranchNum_R.SelectedText = ""
            Me.popBranchNum_R.SelectionLength = 0
            Me.popBranchNum_R.SelectionStart = 0
            Me.popBranchNum_R.Size = New System.Drawing.Size(87, 20)
            Me.popBranchNum_R.TabIndex = 2
            Me.popBranchNum_R.Tag = "code(지국코드);"
            Me.popBranchNum_R.TextAlign = 0
            Me.popBranchNum_R.TextValue = ""
            Me.popBranchNum_R.ToolTipText = ""
            Me.popBranchNum_R.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(605, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(68, 14)
            Me.Label2.TabIndex = 34
            Me.Label2.Text = "회수 지국"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Visible = False
            '
            'popCouponCorpCd_R
            '
            Me.popCouponCorpCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popCouponCorpCd_R.BorderStyle = 2
            Me.popCouponCorpCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCouponCorpCd_R.CaptionName = "소속사코드"
            Me.popCouponCorpCd_R.CodeText = ""
            Me.popCouponCorpCd_R.CodeWidth = 60
            Me.popCouponCorpCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCouponCorpCd_R.Location = New System.Drawing.Point(310, 17)
            Me.popCouponCorpCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCouponCorpCd_R.MaxLength = 4
            Me.popCouponCorpCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCouponCorpCd_R.Name = "popCouponCorpCd_R"
            Me.popCouponCorpCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCouponCorpCd_R.NameText = ""
            Me.popCouponCorpCd_R.ReadOnlys = False
            Me.popCouponCorpCd_R.SelectedText = ""
            Me.popCouponCorpCd_R.SelectionLength = 0
            Me.popCouponCorpCd_R.SelectionStart = 0
            Me.popCouponCorpCd_R.Size = New System.Drawing.Size(273, 20)
            Me.popCouponCorpCd_R.TabIndex = 1
            Me.popCouponCorpCd_R.Tag = "code(소속사 명);"
            Me.popCouponCorpCd_R.TextAlign = 0
            Me.popCouponCorpCd_R.TextValue = ""
            Me.popCouponCorpCd_R.ToolTipText = ""
            Me.popCouponCorpCd_R.Visible = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(237, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(68, 18)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "소속사"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label1.Visible = False
            '
            'btnExec
            '
            Me.btnExec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnExec.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExec.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnExec.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnExec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnExec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnExec.Location = New System.Drawing.Point(781, 14)
            Me.btnExec.Name = "btnExec"
            Me.btnExec.Size = New System.Drawing.Size(26, 20)
            Me.btnExec.TabIndex = 35
            Me.btnExec.Text = "일괄 적용"
            Me.btnExec.UseVisualStyleBackColor = True
            Me.btnExec.Visible = False
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnApprovalAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnApprovalAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnApprovalAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnApprovalAll.Location = New System.Drawing.Point(260, 55)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(149, 28)
            Me.btnApprovalAll.TabIndex = 1768
            Me.btnApprovalAll.Text = "처리일자 일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = True
            '
            'dtpProcDT
            '
            Me.dtpProcDT.BackColor = System.Drawing.SystemColors.Window
            Me.dtpProcDT.BorderColor = System.Drawing.Color.Empty
            Me.dtpProcDT.BorderStyle = 2
            Me.dtpProcDT.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpProcDT.CaptionName = "작업 일자"
            Me.dtpProcDT.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpProcDT.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpProcDT.Location = New System.Drawing.Point(113, 59)
            Me.dtpProcDT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpProcDT.MaxLength = 0
            Me.dtpProcDT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpProcDT.Name = "dtpProcDT"
            Me.dtpProcDT.ReadOnlys = False
            Me.dtpProcDT.SelectedText = ""
            Me.dtpProcDT.SelectionLength = 0
            Me.dtpProcDT.SelectionStart = 0
            Me.dtpProcDT.Size = New System.Drawing.Size(117, 20)
            Me.dtpProcDT.TabIndex = 1769
            Me.dtpProcDT.Tag = "format(&&&&-&&-&&);"
            Me.dtpProcDT.TextAlign = 0
            Me.dtpProcDT.TextValue = ""
            Me.dtpProcDT.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(31, 62)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 15)
            Me.Label3.TabIndex = 1770
            Me.Label3.Text = "처리 일자"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox2
            '
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(5, 50)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(418, 38)
            Me.PictureBox2.TabIndex = 1767
            Me.PictureBox2.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(426, 50)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(381, 38)
            Me.PictureBox1.TabIndex = 1766
            Me.PictureBox1.TabStop = False
            '
            'PNJ301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.dtpProcDT)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.btnExec)
            Me.Controls.Add(Me.popCouponCorpCd_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popBranchNum_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNJ301"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYear, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popBranchNum_R, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd_R, 0)
            Me.Controls.SetChildIndex(Me.btnExec, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.dtpProcDT, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popBranchNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popCouponCorpCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnExec As ubiLease.CommonControls.btn
        Friend WithEvents btnApprovalAll As ubiLease.CommonControls.btn
        Friend WithEvents dtpProcDT As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox


    End Class

End Namespace
