Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB301))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtBranchNm = New ubiLease.CommonControls.txt
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            Me.lblJoinCompanyDate = New System.Windows.Forms.Label
            Me.dtpBaseDt = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.popBranchCd = New ubiLease.CommonControls.pop
            Me.chkCloseCheck = New ubiLease.CommonControls.chk
            Me.chkOpenCheck = New ubiLease.CommonControls.chk
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 75)
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
            Me.grd_1.Location = New System.Drawing.Point(6, 85)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 558)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 19
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(34, 19)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(57, 20)
            Me.lblBranchNm.TabIndex = 1090
            Me.lblBranchNm.Text = "지국코드"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(279, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 20)
            Me.Label1.TabIndex = 1092
            Me.Label1.Text = "지국 명"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtBranchNm
            '
            Me.txtBranchNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm.BorderStyle = 2
            Me.txtBranchNm.CaptionName = "지국 명"
            Me.txtBranchNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtBranchNm.Location = New System.Drawing.Point(337, 19)
            Me.txtBranchNm.MaxLength = 50
            Me.txtBranchNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm.Multiline = False
            Me.txtBranchNm.Name = "txtBranchNm"
            Me.txtBranchNm.ReadOnlys = False
            Me.txtBranchNm.SelectedText = ""
            Me.txtBranchNm.SelectionLength = 0
            Me.txtBranchNm.SelectionStart = 0
            Me.txtBranchNm.Size = New System.Drawing.Size(159, 20)
            Me.txtBranchNm.TabIndex = 1091
            Me.txtBranchNm.Tag = ""
            Me.txtBranchNm.TextAlign = 0
            Me.txtBranchNm.TextValue = ""
            Me.txtBranchNm.ToolTipText = ""
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "담당자"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 60
            Me.popChargeEmpNum.Location = New System.Drawing.Point(337, 45)
            Me.popChargeEmpNum.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popChargeEmpNum.MaxLength = 6
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum.NameText = ""
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(159, 20)
            Me.popChargeEmpNum.TabIndex = 1153
            Me.popChargeEmpNum.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            '
            'lblJoinCompanyDate
            '
            Me.lblJoinCompanyDate.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblJoinCompanyDate.Location = New System.Drawing.Point(34, 45)
            Me.lblJoinCompanyDate.Name = "lblJoinCompanyDate"
            Me.lblJoinCompanyDate.Size = New System.Drawing.Size(57, 20)
            Me.lblJoinCompanyDate.TabIndex = 1155
            Me.lblJoinCompanyDate.Text = "기준일자"
            Me.lblJoinCompanyDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBaseDt
            '
            Me.dtpBaseDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseDt.BorderStyle = 2
            Me.dtpBaseDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseDt.CaptionName = "계약일자"
            Me.dtpBaseDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseDt.Location = New System.Drawing.Point(97, 45)
            Me.dtpBaseDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseDt.MaxLength = 0
            Me.dtpBaseDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseDt.Name = "dtpBaseDt"
            Me.dtpBaseDt.ReadOnlys = True
            Me.dtpBaseDt.SelectedText = ""
            Me.dtpBaseDt.SelectionLength = 0
            Me.dtpBaseDt.SelectionStart = 0
            Me.dtpBaseDt.Size = New System.Drawing.Size(118, 20)
            Me.dtpBaseDt.TabIndex = 1154
            Me.dtpBaseDt.Tag = "need;format(####-##-##);"
            Me.dtpBaseDt.TextAlign = 0
            Me.dtpBaseDt.TextValue = ""
            Me.dtpBaseDt.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(279, 45)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 20)
            Me.Label2.TabIndex = 1156
            Me.Label2.Text = "담당자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popBranchCd
            '
            Me.popBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd.BorderStyle = 2
            Me.popBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd.CaptionName = "지국코드"
            Me.popBranchCd.CodeText = ""
            Me.popBranchCd.CodeWidth = 60
            Me.popBranchCd.Location = New System.Drawing.Point(97, 19)
            Me.popBranchCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBranchCd.MaxLength = 7
            Me.popBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd.Name = "popBranchCd"
            Me.popBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd.NameText = ""
            Me.popBranchCd.ReadOnlys = False
            Me.popBranchCd.SelectedText = ""
            Me.popBranchCd.SelectionLength = 0
            Me.popBranchCd.SelectionStart = 0
            Me.popBranchCd.Size = New System.Drawing.Size(84, 20)
            Me.popBranchCd.TabIndex = 1157
            Me.popBranchCd.Tag = "code(지국코드);"
            Me.popBranchCd.TextAlign = 0
            Me.popBranchCd.TextValue = ""
            Me.popBranchCd.ToolTipText = ""
            '
            'chkCloseCheck
            '
            Me.chkCloseCheck.AutoSize = True
            Me.chkCloseCheck.CaptionName = Nothing
            Me.chkCloseCheck.Location = New System.Drawing.Point(675, 19)
            Me.chkCloseCheck.Name = "chkCloseCheck"
            Me.chkCloseCheck.ReadOnlys = False
            Me.chkCloseCheck.Size = New System.Drawing.Size(60, 16)
            Me.chkCloseCheck.TabIndex = 1158
            Me.chkCloseCheck.Tag = Nothing
            Me.chkCloseCheck.Text = "폐지국"
            Me.chkCloseCheck.TextValue = "0"
            Me.chkCloseCheck.UseVisualStyleBackColor = True
            '
            'chkOpenCheck
            '
            Me.chkOpenCheck.AutoSize = True
            Me.chkOpenCheck.CaptionName = Nothing
            Me.chkOpenCheck.Location = New System.Drawing.Point(675, 47)
            Me.chkOpenCheck.Name = "chkOpenCheck"
            Me.chkOpenCheck.ReadOnlys = False
            Me.chkOpenCheck.Size = New System.Drawing.Size(72, 16)
            Me.chkOpenCheck.TabIndex = 1159
            Me.chkOpenCheck.Tag = Nothing
            Me.chkOpenCheck.Text = "전체지국"
            Me.chkOpenCheck.TextValue = "0"
            Me.chkOpenCheck.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(648, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(139, 60)
            Me.PictureBox1.TabIndex = 1160
            Me.PictureBox1.TabStop = False
            '
            'PNB301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkOpenCheck)
            Me.Controls.Add(Me.chkCloseCheck)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.popBranchCd)
            Me.Controls.Add(Me.lblJoinCompanyDate)
            Me.Controls.Add(Me.dtpBaseDt)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtBranchNm)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNB301"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.txtBranchNm, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseDt, 0)
            Me.Controls.SetChildIndex(Me.lblJoinCompanyDate, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.chkCloseCheck, 0)
            Me.Controls.SetChildIndex(Me.chkOpenCheck, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm As ubiLease.CommonControls.txt
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents lblJoinCompanyDate As System.Windows.Forms.Label
        Friend WithEvents dtpBaseDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents chkCloseCheck As ubiLease.CommonControls.chk
        Friend WithEvents chkOpenCheck As ubiLease.CommonControls.chk
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox


    End Class

End Namespace
