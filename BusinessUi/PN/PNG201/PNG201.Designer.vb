Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNG201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNG201))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpYYYYMM = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.popDivCd_R = New ubiLease.CommonControls.pop
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtChargeEmpNum_R = New ubiLease.CommonControls.txt
            Me.Label4 = New System.Windows.Forms.Label
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optExpAmt3 = New System.Windows.Forms.RadioButton
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.optExpAmt2 = New System.Windows.Forms.RadioButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.dtpDeductDt = New ubiLease.CommonControls.dtp
            Me.Label5 = New System.Windows.Forms.Label
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
            Me.picCriteria_1.Location = New System.Drawing.Point(4, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 66)
            Me.picCriteria_1.TabIndex = 2
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
            Me.grd_1.Location = New System.Drawing.Point(4, 152)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 490)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 6
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpYYYYMM
            '
            Me.dtpYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpYYYYMM.BorderStyle = 2
            Me.dtpYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpYYYYMM.CaptionName = "기준 년월"
            Me.dtpYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpYYYYMM.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpYYYYMM.Location = New System.Drawing.Point(106, 19)
            Me.dtpYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpYYYYMM.MaxLength = 0
            Me.dtpYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpYYYYMM.Name = "dtpYYYYMM"
            Me.dtpYYYYMM.ReadOnlys = False
            Me.dtpYYYYMM.SelectedText = ""
            Me.dtpYYYYMM.SelectionLength = 0
            Me.dtpYYYYMM.SelectionStart = 0
            Me.dtpYYYYMM.Size = New System.Drawing.Size(100, 20)
            Me.dtpYYYYMM.TabIndex = 0
            Me.dtpYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpYYYYMM.TextAlign = 0
            Me.dtpYYYYMM.TextValue = ""
            Me.dtpYYYYMM.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(36, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(64, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 23
            Me.lblCodeDivisionHangulName.Text = "기준 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(367, 46)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 15)
            Me.Label2.TabIndex = 27
            Me.Label2.Text = "지국 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
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
            Me.popBranchCd_R.Location = New System.Drawing.Point(436, 43)
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
            Me.popBranchCd_R.TabIndex = 3
            Me.popBranchCd_R.Tag = "code(지국코드);"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            '
            'popDivCd_R
            '
            Me.popDivCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popDivCd_R.BorderStyle = 2
            Me.popDivCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDivCd_R.CaptionName = "지원비항목"
            Me.popDivCd_R.CodeText = ""
            Me.popDivCd_R.CodeWidth = 60
            Me.popDivCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popDivCd_R.Location = New System.Drawing.Point(436, 19)
            Me.popDivCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popDivCd_R.MaxLength = 3
            Me.popDivCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popDivCd_R.Name = "popDivCd_R"
            Me.popDivCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popDivCd_R.NameText = ""
            Me.popDivCd_R.ReadOnlys = False
            Me.popDivCd_R.SelectedText = ""
            Me.popDivCd_R.SelectionLength = 0
            Me.popDivCd_R.SelectionStart = 0
            Me.popDivCd_R.Size = New System.Drawing.Size(231, 20)
            Me.popDivCd_R.TabIndex = 1
            Me.popDivCd_R.Tag = "code(지원항목 명);"
            Me.popDivCd_R.TextAlign = 0
            Me.popDivCd_R.TextValue = ""
            Me.popDivCd_R.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(365, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(66, 15)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "지원비항목"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtChargeEmpNum_R
            '
            Me.txtChargeEmpNum_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtChargeEmpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.txtChargeEmpNum_R.BorderStyle = 2
            Me.txtChargeEmpNum_R.CaptionName = Nothing
            Me.txtChargeEmpNum_R.Location = New System.Drawing.Point(106, 43)
            Me.txtChargeEmpNum_R.MaxLength = 32767
            Me.txtChargeEmpNum_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtChargeEmpNum_R.Multiline = False
            Me.txtChargeEmpNum_R.Name = "txtChargeEmpNum_R"
            Me.txtChargeEmpNum_R.ReadOnlys = False
            Me.txtChargeEmpNum_R.SelectedText = ""
            Me.txtChargeEmpNum_R.SelectionLength = 0
            Me.txtChargeEmpNum_R.SelectionStart = 0
            Me.txtChargeEmpNum_R.Size = New System.Drawing.Size(231, 20)
            Me.txtChargeEmpNum_R.TabIndex = 2
            Me.txtChargeEmpNum_R.Tag = Nothing
            Me.txtChargeEmpNum_R.TextAlign = 0
            Me.txtChargeEmpNum_R.TextValue = ""
            Me.txtChargeEmpNum_R.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(38, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(63, 20)
            Me.Label4.TabIndex = 1288
            Me.Label4.Text = "담당 명"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optExpAmt3)
            Me.Opt2.Controls.Add(Me.optExpAmt1)
            Me.Opt2.Controls.Add(Me.optExpAmt2)
            Me.Opt2.Location = New System.Drawing.Point(4, 73)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(440, 34)
            Me.Opt2.TabIndex = 1636
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optExpAmt3
            '
            Me.optExpAmt3.AutoSize = True
            Me.optExpAmt3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt3.Location = New System.Drawing.Point(296, 9)
            Me.optExpAmt3.Name = "optExpAmt3"
            Me.optExpAmt3.Size = New System.Drawing.Size(127, 16)
            Me.optExpAmt3.TabIndex = 2
            Me.optExpAmt3.Text = "목표 및 조직지원비"
            Me.optExpAmt3.UseVisualStyleBackColor = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Checked = True
            Me.optExpAmt1.Location = New System.Drawing.Point(15, 9)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(135, 16)
            Me.optExpAmt1.TabIndex = 0
            Me.optExpAmt1.TabStop = True
            Me.optExpAmt1.Text = "지국 판매지원비현황"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'optExpAmt2
            '
            Me.optExpAmt2.AutoSize = True
            Me.optExpAmt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt2.Location = New System.Drawing.Point(159, 9)
            Me.optExpAmt2.Name = "optExpAmt2"
            Me.optExpAmt2.Size = New System.Drawing.Size(127, 16)
            Me.optExpAmt2.TabIndex = 1
            Me.optExpAmt2.Text = "지국별 판매 지원비"
            Me.optExpAmt2.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label1.Location = New System.Drawing.Point(455, 78)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(343, 24)
            Me.Label1.TabIndex = 1671
            Me.Label1.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(446, 73)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(361, 34)
            Me.PictureBox1.TabIndex = 1672
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
            Me.dtpDeductDt.Location = New System.Drawing.Point(104, 120)
            Me.dtpDeductDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDeductDt.MaxLength = 0
            Me.dtpDeductDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDeductDt.Name = "dtpDeductDt"
            Me.dtpDeductDt.ReadOnlys = False
            Me.dtpDeductDt.SelectedText = ""
            Me.dtpDeductDt.SelectionLength = 0
            Me.dtpDeductDt.SelectionStart = 0
            Me.dtpDeductDt.Size = New System.Drawing.Size(102, 20)
            Me.dtpDeductDt.TabIndex = 4
            Me.dtpDeductDt.Tag = "format(####-##-##);"
            Me.dtpDeductDt.TextAlign = 0
            Me.dtpDeductDt.TextValue = ""
            Me.dtpDeductDt.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(35, 122)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(63, 15)
            Me.Label5.TabIndex = 1693
            Me.Label5.Text = "대체일자"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(232, 117)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(92, 26)
            Me.btnApprovalAll.TabIndex = 5
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'picCriteria2
            '
            Me.picCriteria2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria2.Location = New System.Drawing.Point(4, 110)
            Me.picCriteria2.Name = "picCriteria2"
            Me.picCriteria2.Size = New System.Drawing.Size(803, 38)
            Me.picCriteria2.TabIndex = 1691
            Me.picCriteria2.TabStop = False
            '
            'PNG201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpDeductDt)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.picCriteria2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.txtChargeEmpNum_R)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popDivCd_R)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpYYYYMM)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNG201"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents popDivCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtChargeEmpNum_R As ubiLease.CommonControls.txt
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optExpAmt3 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt2 As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpDeductDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button
        Friend WithEvents picCriteria2 As System.Windows.Forms.PictureBox

    End Class

End Namespace
