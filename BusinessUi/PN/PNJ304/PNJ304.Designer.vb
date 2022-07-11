Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ304
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ304))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label20 = New System.Windows.Forms.Label
            Me.txtBranchNm = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.dtpBaseYearMonths = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.btnCreateSale = New ubiLease.CommonControls.btn
            Me.picCriteria2 = New System.Windows.Forms.PictureBox
            Me.dtpDeductDt = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnApprovalAll = New System.Windows.Forms.Button
            Me.popCouponCorpCd = New ubiLease.CommonControls.pop
            Me.lblBranchNm = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(6, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 66)
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
            Me.grd_1.Location = New System.Drawing.Point(6, 115)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 529)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 19
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label20.Location = New System.Drawing.Point(21, 39)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(74, 20)
            Me.Label20.TabIndex = 1284
            Me.Label20.Text = "영업담당자"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBranchNm
            '
            Me.txtBranchNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm.BorderStyle = 2
            Me.txtBranchNm.CaptionName = Nothing
            Me.txtBranchNm.Location = New System.Drawing.Point(446, 39)
            Me.txtBranchNm.MaxLength = 32767
            Me.txtBranchNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm.Multiline = False
            Me.txtBranchNm.Name = "txtBranchNm"
            Me.txtBranchNm.ReadOnlys = False
            Me.txtBranchNm.SelectedText = ""
            Me.txtBranchNm.SelectionLength = 0
            Me.txtBranchNm.SelectionStart = 0
            Me.txtBranchNm.Size = New System.Drawing.Size(224, 20)
            Me.txtBranchNm.TabIndex = 4
            Me.txtBranchNm.Tag = Nothing
            Me.txtBranchNm.TextAlign = 0
            Me.txtBranchNm.TextValue = ""
            Me.txtBranchNm.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(389, 39)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 20)
            Me.Label2.TabIndex = 1286
            Me.Label2.Text = "지국명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "영업사원 명"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 50
            Me.popEmployeeNumber.Location = New System.Drawing.Point(101, 39)
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
            Me.popEmployeeNumber.Size = New System.Drawing.Size(256, 20)
            Me.popEmployeeNumber.TabIndex = 3
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
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
            Me.dtpBaseYearMonths.Location = New System.Drawing.Point(101, 14)
            Me.dtpBaseYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYearMonths.MaxLength = 0
            Me.dtpBaseYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYearMonths.Name = "dtpBaseYearMonths"
            Me.dtpBaseYearMonths.ReadOnlys = False
            Me.dtpBaseYearMonths.SelectedText = ""
            Me.dtpBaseYearMonths.SelectionLength = 0
            Me.dtpBaseYearMonths.SelectionStart = 0
            Me.dtpBaseYearMonths.Size = New System.Drawing.Size(74, 20)
            Me.dtpBaseYearMonths.TabIndex = 0
            Me.dtpBaseYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpBaseYearMonths.TextAlign = 0
            Me.dtpBaseYearMonths.TextValue = ""
            Me.dtpBaseYearMonths.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(22, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(74, 15)
            Me.Label3.TabIndex = 1628
            Me.Label3.Text = "지급 년월"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'btnCreateSale
            '
            Me.btnCreateSale.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreateSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreateSale.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnCreateSale.Location = New System.Drawing.Point(697, 14)
            Me.btnCreateSale.Name = "btnCreateSale"
            Me.btnCreateSale.Size = New System.Drawing.Size(95, 43)
            Me.btnCreateSale.TabIndex = 7
            Me.btnCreateSale.Text = "배달확인증" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "구독료배분"
            Me.btnCreateSale.UseVisualStyleBackColor = True
            Me.btnCreateSale.Visible = False
            '
            'picCriteria2
            '
            Me.picCriteria2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria2.Location = New System.Drawing.Point(6, 73)
            Me.picCriteria2.Name = "picCriteria2"
            Me.picCriteria2.Size = New System.Drawing.Size(801, 38)
            Me.picCriteria2.TabIndex = 1633
            Me.picCriteria2.TabStop = False
            '
            'dtpDeductDt
            '
            Me.dtpDeductDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDeductDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpDeductDt.BorderStyle = 2
            Me.dtpDeductDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDeductDt.CaptionName = "접수 일자"
            Me.dtpDeductDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpDeductDt.Location = New System.Drawing.Point(106, 83)
            Me.dtpDeductDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDeductDt.MaxLength = 0
            Me.dtpDeductDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDeductDt.Name = "dtpDeductDt"
            Me.dtpDeductDt.ReadOnlys = False
            Me.dtpDeductDt.SelectedText = ""
            Me.dtpDeductDt.SelectionLength = 0
            Me.dtpDeductDt.SelectionStart = 0
            Me.dtpDeductDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpDeductDt.TabIndex = 5
            Me.dtpDeductDt.Tag = "format(####-##-##);"
            Me.dtpDeductDt.TextAlign = 0
            Me.dtpDeductDt.TextValue = ""
            Me.dtpDeductDt.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(37, 85)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 15)
            Me.Label4.TabIndex = 1685
            Me.Label4.Text = "대체일자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(234, 80)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(90, 26)
            Me.btnApprovalAll.TabIndex = 6
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'popCouponCorpCd
            '
            Me.popCouponCorpCd.BorderColor = System.Drawing.Color.Empty
            Me.popCouponCorpCd.BorderStyle = 2
            Me.popCouponCorpCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCouponCorpCd.CaptionName = "확장처 코드"
            Me.popCouponCorpCd.CodeText = ""
            Me.popCouponCorpCd.CodeWidth = 50
            Me.popCouponCorpCd.Location = New System.Drawing.Point(446, 14)
            Me.popCouponCorpCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCouponCorpCd.MaxLength = 4
            Me.popCouponCorpCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCouponCorpCd.Name = "popCouponCorpCd"
            Me.popCouponCorpCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCouponCorpCd.NameText = ""
            Me.popCouponCorpCd.ReadOnlys = False
            Me.popCouponCorpCd.SelectedText = ""
            Me.popCouponCorpCd.SelectionLength = 0
            Me.popCouponCorpCd.SelectionStart = 0
            Me.popCouponCorpCd.Size = New System.Drawing.Size(224, 20)
            Me.popCouponCorpCd.TabIndex = 2
            Me.popCouponCorpCd.Tag = "code(소속사 명);"
            Me.popCouponCorpCd.TextAlign = 0
            Me.popCouponCorpCd.TextValue = ""
            Me.popCouponCorpCd.ToolTipText = ""
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(389, 14)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(53, 20)
            Me.lblBranchNm.TabIndex = 1688
            Me.lblBranchNm.Text = "소속사"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNJ304
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popCouponCorpCd)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.dtpDeductDt)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.picCriteria2)
            Me.Controls.Add(Me.dtpBaseYearMonths)
            Me.Controls.Add(Me.btnCreateSale)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.txtBranchNm)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNJ304"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.Label20, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.txtBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.btnCreateSale, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYearMonths, 0)
            Me.Controls.SetChildIndex(Me.picCriteria2, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.dtpDeductDt, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents dtpBaseYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnCreateSale As ubiLease.CommonControls.btn
        Friend WithEvents picCriteria2 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpDeductDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button
        Friend WithEvents popCouponCorpCd As ubiLease.CommonControls.pop
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label


    End Class

End Namespace
