Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ101))
            Me.dtpPublishYearMonthFrom = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpPublishYearMonthTo = New ubiLease.CommonControls.dtp
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.popCouponCorpCd = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.btnNew = New ubiLease.CommonControls.btn
            Me.btn_Save = New ubiLease.CommonControls.btn
            Me.btnDelete = New ubiLease.CommonControls.btn
            Me.Label11 = New System.Windows.Forms.Label
            Me.btnApprovalAll = New ubiLease.CommonControls.btn
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.dtpProcDT = New ubiLease.CommonControls.dtp
            Me.lblMsg11 = New System.Windows.Forms.Label
            Me.lblMsg13 = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpPublishYearMonthFrom
            '
            Me.dtpPublishYearMonthFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPublishYearMonthFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpPublishYearMonthFrom.BorderStyle = 2
            Me.dtpPublishYearMonthFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPublishYearMonthFrom.CaptionName = "발행년월From"
            Me.dtpPublishYearMonthFrom.DateTimeFormatText = "yyyy-MM"
            Me.dtpPublishYearMonthFrom.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPublishYearMonthFrom.Location = New System.Drawing.Point(101, 20)
            Me.dtpPublishYearMonthFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPublishYearMonthFrom.MaxLength = 0
            Me.dtpPublishYearMonthFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPublishYearMonthFrom.Name = "dtpPublishYearMonthFrom"
            Me.dtpPublishYearMonthFrom.ReadOnlys = False
            Me.dtpPublishYearMonthFrom.SelectedText = ""
            Me.dtpPublishYearMonthFrom.SelectionLength = 0
            Me.dtpPublishYearMonthFrom.SelectionStart = 0
            Me.dtpPublishYearMonthFrom.Size = New System.Drawing.Size(100, 20)
            Me.dtpPublishYearMonthFrom.TabIndex = 0
            Me.dtpPublishYearMonthFrom.Tag = "need;format(&&&&-&&);"
            Me.dtpPublishYearMonthFrom.TextAlign = 0
            Me.dtpPublishYearMonthFrom.TextValue = ""
            Me.dtpPublishYearMonthFrom.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(31, 23)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(64, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 17
            Me.lblCodeDivisionHangulName.Text = "발행 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 50)
            Me.picCriteria_1.TabIndex = 18
            Me.picCriteria_1.TabStop = False
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 59)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 230)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 6
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(207, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(21, 16)
            Me.Label1.TabIndex = 21
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpPublishYearMonthTo
            '
            Me.dtpPublishYearMonthTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPublishYearMonthTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpPublishYearMonthTo.BorderStyle = 2
            Me.dtpPublishYearMonthTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPublishYearMonthTo.CaptionName = "발행년월To"
            Me.dtpPublishYearMonthTo.DateTimeFormatText = "yyyy-MM"
            Me.dtpPublishYearMonthTo.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpPublishYearMonthTo.Location = New System.Drawing.Point(234, 20)
            Me.dtpPublishYearMonthTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPublishYearMonthTo.MaxLength = 0
            Me.dtpPublishYearMonthTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPublishYearMonthTo.Name = "dtpPublishYearMonthTo"
            Me.dtpPublishYearMonthTo.ReadOnlys = False
            Me.dtpPublishYearMonthTo.SelectedText = ""
            Me.dtpPublishYearMonthTo.SelectionLength = 0
            Me.dtpPublishYearMonthTo.SelectionStart = 0
            Me.dtpPublishYearMonthTo.Size = New System.Drawing.Size(100, 20)
            Me.dtpPublishYearMonthTo.TabIndex = 1
            Me.dtpPublishYearMonthTo.Tag = "need;format(&&&&-&&);"
            Me.dtpPublishYearMonthTo.TextAlign = 0
            Me.dtpPublishYearMonthTo.TextValue = ""
            Me.dtpPublishYearMonthTo.ToolTipText = ""
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
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(5, 332)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(803, 305)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 7
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'popCouponCorpCd
            '
            Me.popCouponCorpCd.BorderColor = System.Drawing.Color.Empty
            Me.popCouponCorpCd.BorderStyle = 2
            Me.popCouponCorpCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCouponCorpCd.CaptionName = "소속사코드"
            Me.popCouponCorpCd.CodeText = ""
            Me.popCouponCorpCd.CodeWidth = 60
            Me.popCouponCorpCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCouponCorpCd.Location = New System.Drawing.Point(417, 20)
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
            Me.popCouponCorpCd.Size = New System.Drawing.Size(231, 20)
            Me.popCouponCorpCd.TabIndex = 2
            Me.popCouponCorpCd.Tag = "code(소속사 명);"
            Me.popCouponCorpCd.TextAlign = 0
            Me.popCouponCorpCd.TextValue = ""
            Me.popCouponCorpCd.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(340, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(71, 18)
            Me.Label2.TabIndex = 30
            Me.Label2.Text = "소속사코드"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnNew
            '
            Me.btnNew.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Location = New System.Drawing.Point(12, 298)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(62, 26)
            Me.btnNew.TabIndex = 3
            Me.btnNew.Text = "발행추가"
            Me.btnNew.UseVisualStyleBackColor = True
            '
            'btn_Save
            '
            Me.btn_Save.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btn_Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btn_Save.Location = New System.Drawing.Point(78, 298)
            Me.btn_Save.Name = "btn_Save"
            Me.btn_Save.Size = New System.Drawing.Size(62, 26)
            Me.btn_Save.TabIndex = 4
            Me.btn_Save.Text = "저장"
            Me.btn_Save.UseVisualStyleBackColor = True
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDelete.Location = New System.Drawing.Point(145, 298)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(62, 26)
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "삭제"
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(374, 304)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(90, 15)
            Me.Label11.TabIndex = 1769
            Me.Label11.Text = "조정 발행 일자"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnApprovalAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnApprovalAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnApprovalAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnApprovalAll.Location = New System.Drawing.Point(584, 298)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(91, 26)
            Me.btnApprovalAll.TabIndex = 1767
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(369, 293)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(437, 36)
            Me.PictureBox2.TabIndex = 1770
            Me.PictureBox2.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 293)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(361, 36)
            Me.PictureBox1.TabIndex = 1771
            Me.PictureBox1.TabStop = False
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
            Me.dtpProcDT.Location = New System.Drawing.Point(470, 301)
            Me.dtpProcDT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpProcDT.MaxLength = 0
            Me.dtpProcDT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpProcDT.Name = "dtpProcDT"
            Me.dtpProcDT.ReadOnlys = False
            Me.dtpProcDT.SelectedText = ""
            Me.dtpProcDT.SelectionLength = 0
            Me.dtpProcDT.SelectionStart = 0
            Me.dtpProcDT.Size = New System.Drawing.Size(108, 20)
            Me.dtpProcDT.TabIndex = 1772
            Me.dtpProcDT.Tag = "format(&&&&-&&-&&);"
            Me.dtpProcDT.TextAlign = 0
            Me.dtpProcDT.TextValue = ""
            Me.dtpProcDT.ToolTipText = ""
            '
            'lblMsg11
            '
            Me.lblMsg11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblMsg11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblMsg11.Location = New System.Drawing.Point(681, 298)
            Me.lblMsg11.Name = "lblMsg11"
            Me.lblMsg11.Size = New System.Drawing.Size(121, 24)
            Me.lblMsg11.TabIndex = 1774
            Me.lblMsg11.Text = "하단 그리드에서 조정을 원하는 행의 선택 부분을 체크 하시고 일괄 적용을 하세요."
            Me.lblMsg11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMsg13
            '
            Me.lblMsg13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblMsg13.Location = New System.Drawing.Point(212, 298)
            Me.lblMsg13.Name = "lblMsg13"
            Me.lblMsg13.Size = New System.Drawing.Size(143, 26)
            Me.lblMsg13.TabIndex = 1773
            Me.lblMsg13.Text = "툴바의 저장/삭제와 관계 없이 적용 됩니다."
            Me.lblMsg13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PNJ101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblMsg11)
            Me.Controls.Add(Me.lblMsg13)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.dtpProcDT)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.btn_Save)
            Me.Controls.Add(Me.btnNew)
            Me.Controls.Add(Me.popCouponCorpCd)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.dtpPublishYearMonthTo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpPublishYearMonthFrom)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Name = "PNJ101"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpPublishYearMonthFrom, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpPublishYearMonthTo, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd, 0)
            Me.Controls.SetChildIndex(Me.btnNew, 0)
            Me.Controls.SetChildIndex(Me.btn_Save, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            Me.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.Controls.SetChildIndex(Me.dtpProcDT, 0)
            Me.Controls.SetChildIndex(Me.Label11, 0)
            Me.Controls.SetChildIndex(Me.lblMsg13, 0)
            Me.Controls.SetChildIndex(Me.lblMsg11, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpPublishYearMonthFrom As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpPublishYearMonthTo As ubiLease.CommonControls.dtp
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents popCouponCorpCd As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnNew As ubiLease.CommonControls.btn
        Friend WithEvents btn_Save As ubiLease.CommonControls.btn
        Friend WithEvents btnDelete As ubiLease.CommonControls.btn
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As ubiLease.CommonControls.btn
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpProcDT As ubiLease.CommonControls.dtp
        Friend WithEvents lblMsg11 As System.Windows.Forms.Label
        Friend WithEvents lblMsg13 As System.Windows.Forms.Label


    End Class

End Namespace
