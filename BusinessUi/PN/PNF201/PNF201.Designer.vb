Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNF201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNF201))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label20 = New System.Windows.Forms.Label
            Me.txtBranchNm = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.btnCreateSale = New ubiLease.CommonControls.btn
            Me.dtpBaseYearMonths = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label23 = New System.Windows.Forms.Label
            Me.numWeekNum = New ubiLease.CommonControls.num
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optStop1 = New System.Windows.Forms.RadioButton
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.optStop = New System.Windows.Forms.RadioButton
            Me.optExpAmt2 = New System.Windows.Forms.RadioButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.dtpDeductDt = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnApprovalAll = New System.Windows.Forms.Button
            Me.picCriteria2 = New System.Windows.Forms.PictureBox
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria_1.Size = New System.Drawing.Size(800, 66)
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
            Me.grd_1.Location = New System.Drawing.Point(6, 150)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(802, 494)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 5
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label20.Location = New System.Drawing.Point(19, 39)
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
            Me.txtBranchNm.Location = New System.Drawing.Point(413, 39)
            Me.txtBranchNm.MaxLength = 32767
            Me.txtBranchNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm.Multiline = False
            Me.txtBranchNm.Name = "txtBranchNm"
            Me.txtBranchNm.ReadOnlys = False
            Me.txtBranchNm.SelectedText = ""
            Me.txtBranchNm.SelectionLength = 0
            Me.txtBranchNm.SelectionStart = 0
            Me.txtBranchNm.Size = New System.Drawing.Size(189, 20)
            Me.txtBranchNm.TabIndex = 3
            Me.txtBranchNm.Tag = Nothing
            Me.txtBranchNm.TextAlign = 0
            Me.txtBranchNm.TextValue = ""
            Me.txtBranchNm.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(352, 39)
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
            Me.popEmployeeNumber.Location = New System.Drawing.Point(100, 39)
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
            Me.popEmployeeNumber.TabIndex = 2
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'btnCreateSale
            '
            Me.btnCreateSale.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreateSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreateSale.Location = New System.Drawing.Point(703, 18)
            Me.btnCreateSale.Name = "btnCreateSale"
            Me.btnCreateSale.Size = New System.Drawing.Size(92, 42)
            Me.btnCreateSale.TabIndex = 4
            Me.btnCreateSale.Text = "확장비생성"
            Me.btnCreateSale.UseVisualStyleBackColor = True
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
            Me.dtpBaseYearMonths.Location = New System.Drawing.Point(100, 15)
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
            Me.Label3.Location = New System.Drawing.Point(20, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(74, 15)
            Me.Label3.TabIndex = 1628
            Me.Label3.Text = "확장 년월"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label23.Location = New System.Drawing.Point(220, 20)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(29, 12)
            Me.Label23.TabIndex = 1631
            Me.Label23.Text = "주차"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numWeekNum
            '
            Me.numWeekNum.BackColor = System.Drawing.SystemColors.Window
            Me.numWeekNum.BorderColor = System.Drawing.Color.Empty
            Me.numWeekNum.BorderStyle = 2
            Me.numWeekNum.CaptionName = "확장 주차"
            Me.numWeekNum.LengthPrecision = 15
            Me.numWeekNum.LengthScale = 0
            Me.numWeekNum.Location = New System.Drawing.Point(176, 15)
            Me.numWeekNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numWeekNum.MaxLength = 32767
            Me.numWeekNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numWeekNum.Name = "numWeekNum"
            Me.numWeekNum.ReadOnlys = False
            Me.numWeekNum.SelectedText = ""
            Me.numWeekNum.SelectionLength = 0
            Me.numWeekNum.SelectionStart = 1
            Me.numWeekNum.Size = New System.Drawing.Size(42, 20)
            Me.numWeekNum.TabIndex = 1
            Me.numWeekNum.Tag = Nothing
            Me.numWeekNum.TextValue = "0"
            Me.numWeekNum.ToolTipText = ""
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optStop1)
            Me.Opt2.Controls.Add(Me.optExpAmt1)
            Me.Opt2.Controls.Add(Me.optStop)
            Me.Opt2.Controls.Add(Me.optExpAmt2)
            Me.Opt2.Location = New System.Drawing.Point(6, 73)
            Me.Opt2.MaximumSize = New System.Drawing.Size(1000, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(645, 32)
            Me.Opt2.TabIndex = 1632
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optStop1
            '
            Me.optStop1.AutoSize = True
            Me.optStop1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optStop1.Location = New System.Drawing.Point(469, 7)
            Me.optStop1.Name = "optStop1"
            Me.optStop1.Size = New System.Drawing.Size(163, 16)
            Me.optStop1.TabIndex = 3
            Me.optStop1.Text = "지국별 확장실적 현황보고"
            Me.optStop1.UseVisualStyleBackColor = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Checked = True
            Me.optExpAmt1.Location = New System.Drawing.Point(17, 7)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(139, 16)
            Me.optExpAmt1.TabIndex = 0
            Me.optExpAmt1.TabStop = True
            Me.optExpAmt1.Text = "확장비 은행 이체내역"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'optStop
            '
            Me.optStop.AutoSize = True
            Me.optStop.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optStop.Location = New System.Drawing.Point(293, 7)
            Me.optStop.Name = "optStop"
            Me.optStop.Size = New System.Drawing.Size(163, 16)
            Me.optStop.TabIndex = 2
            Me.optStop.Text = "지국별 확장독자 명단내역"
            Me.optStop.UseVisualStyleBackColor = False
            '
            'optExpAmt2
            '
            Me.optExpAmt2.AutoSize = True
            Me.optExpAmt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt2.Location = New System.Drawing.Point(169, 7)
            Me.optExpAmt2.Name = "optExpAmt2"
            Me.optExpAmt2.Size = New System.Drawing.Size(111, 16)
            Me.optExpAmt2.TabIndex = 1
            Me.optExpAmt2.Text = "확장비 지급내역"
            Me.optExpAmt2.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label1.Location = New System.Drawing.Point(662, 78)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(138, 24)
            Me.Label1.TabIndex = 1669
            Me.Label1.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(653, 73)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(153, 32)
            Me.PictureBox1.TabIndex = 1670
            Me.PictureBox1.TabStop = False
            '
            'dtpDeductDt
            '
            Me.dtpDeductDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDeductDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpDeductDt.BorderStyle = 2
            Me.dtpDeductDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDeductDt.CaptionName = "접수 일자"
            Me.dtpDeductDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpDeductDt.Location = New System.Drawing.Point(106, 118)
            Me.dtpDeductDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDeductDt.MaxLength = 0
            Me.dtpDeductDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDeductDt.Name = "dtpDeductDt"
            Me.dtpDeductDt.ReadOnlys = False
            Me.dtpDeductDt.SelectedText = ""
            Me.dtpDeductDt.SelectionLength = 0
            Me.dtpDeductDt.SelectionStart = 0
            Me.dtpDeductDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpDeductDt.TabIndex = 1690
            Me.dtpDeductDt.Tag = "format(####-##-##);"
            Me.dtpDeductDt.TextAlign = 0
            Me.dtpDeductDt.TextValue = ""
            Me.dtpDeductDt.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(37, 120)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 15)
            Me.Label4.TabIndex = 1689
            Me.Label4.Text = "대체일자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(234, 115)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(90, 26)
            Me.btnApprovalAll.TabIndex = 1688
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'picCriteria2
            '
            Me.picCriteria2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria2.Location = New System.Drawing.Point(6, 108)
            Me.picCriteria2.Name = "picCriteria2"
            Me.picCriteria2.Size = New System.Drawing.Size(801, 38)
            Me.picCriteria2.TabIndex = 1687
            Me.picCriteria2.TabStop = False
            '
            'PNF201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpDeductDt)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.picCriteria2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.numWeekNum)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.dtpBaseYearMonths)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnCreateSale)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.txtBranchNm)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNF201"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents btnCreateSale As ubiLease.CommonControls.btn
        Friend WithEvents dtpBaseYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents numWeekNum As ubiLease.CommonControls.num
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt2 As System.Windows.Forms.RadioButton
        Friend WithEvents optStop As System.Windows.Forms.RadioButton
        Friend WithEvents optStop1 As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpDeductDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button
        Friend WithEvents picCriteria2 As System.Windows.Forms.PictureBox


    End Class

End Namespace
