Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE103
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE103))
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpToExpand = New ubiLease.CommonControls.dtp
            Me.lblExpandDt = New System.Windows.Forms.Label
            Me.dtpFromExpand = New ubiLease.CommonControls.dtp
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optExpAmt3 = New System.Windows.Forms.RadioButton
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.optExpAmt2 = New System.Windows.Forms.RadioButton
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.Opt1 = New ubiLease.CommonControls.opt
            Me.optGrd2 = New System.Windows.Forms.RadioButton
            Me.optGrd3 = New System.Windows.Forms.RadioButton
            Me.picCriteria2 = New System.Windows.Forms.PictureBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.dtpApprovalDt = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnApprovalAll = New System.Windows.Forms.Button
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt1.SuspendLayout()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(224, 14)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(10, 20)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "~"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpToExpand
            '
            Me.dtpToExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpToExpand.BorderStyle = 2
            Me.dtpToExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToExpand.CaptionName = "회계 일자"
            Me.dtpToExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToExpand.Location = New System.Drawing.Point(247, 14)
            Me.dtpToExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToExpand.MaxLength = 0
            Me.dtpToExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToExpand.Name = "dtpToExpand"
            Me.dtpToExpand.ReadOnlys = False
            Me.dtpToExpand.SelectedText = ""
            Me.dtpToExpand.SelectionLength = 0
            Me.dtpToExpand.SelectionStart = 0
            Me.dtpToExpand.Size = New System.Drawing.Size(104, 20)
            Me.dtpToExpand.TabIndex = 1
            Me.dtpToExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpToExpand.TextAlign = 0
            Me.dtpToExpand.TextValue = ""
            Me.dtpToExpand.ToolTipText = ""
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(43, 17)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(59, 15)
            Me.lblExpandDt.TabIndex = 7
            Me.lblExpandDt.Text = "확장일자"
            Me.lblExpandDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFromExpand
            '
            Me.dtpFromExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromExpand.BorderStyle = 2
            Me.dtpFromExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromExpand.CaptionName = "회계 일자"
            Me.dtpFromExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromExpand.Location = New System.Drawing.Point(105, 14)
            Me.dtpFromExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromExpand.MaxLength = 0
            Me.dtpFromExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromExpand.Name = "dtpFromExpand"
            Me.dtpFromExpand.ReadOnlys = False
            Me.dtpFromExpand.SelectedText = ""
            Me.dtpFromExpand.SelectionLength = 0
            Me.dtpFromExpand.SelectionStart = 0
            Me.dtpFromExpand.Size = New System.Drawing.Size(104, 20)
            Me.dtpFromExpand.TabIndex = 0
            Me.dtpFromExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpFromExpand.TextAlign = 0
            Me.dtpFromExpand.TextValue = ""
            Me.dtpFromExpand.ToolTipText = ""
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
            Me.grd_1.Location = New System.Drawing.Point(3, 88)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 279)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 5
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(498, 41)
            Me.picCriteria.TabIndex = 925
            Me.picCriteria.TabStop = False
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
            Me.grd_2.Location = New System.Drawing.Point(3, 400)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(806, 244)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 6
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optExpAmt3)
            Me.Opt2.Controls.Add(Me.optExpAmt1)
            Me.Opt2.Controls.Add(Me.optExpAmt2)
            Me.Opt2.Location = New System.Drawing.Point(3, 48)
            Me.Opt2.MaximumSize = New System.Drawing.Size(1000, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(615, 36)
            Me.Opt2.TabIndex = 4
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optExpAmt3
            '
            Me.optExpAmt3.AutoSize = True
            Me.optExpAmt3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt3.Location = New System.Drawing.Point(408, 9)
            Me.optExpAmt3.Name = "optExpAmt3"
            Me.optExpAmt3.Size = New System.Drawing.Size(175, 16)
            Me.optExpAmt3.TabIndex = 2
            Me.optExpAmt3.Text = "사원확장대회 국별 확장실적"
            Me.optExpAmt3.UseVisualStyleBackColor = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Checked = True
            Me.optExpAmt1.Location = New System.Drawing.Point(22, 9)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(187, 16)
            Me.optExpAmt1.TabIndex = 0
            Me.optExpAmt1.TabStop = True
            Me.optExpAmt1.Text = "사원확장대회 확장실적 총괄표"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'optExpAmt2
            '
            Me.optExpAmt2.AutoSize = True
            Me.optExpAmt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt2.Location = New System.Drawing.Point(215, 9)
            Me.optExpAmt2.Name = "optExpAmt2"
            Me.optExpAmt2.Size = New System.Drawing.Size(187, 16)
            Me.optExpAmt2.TabIndex = 1
            Me.optExpAmt2.Text = "사원확장대회 개인별 확장실적"
            Me.optExpAmt2.UseVisualStyleBackColor = False
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(3, 400)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(805, 244)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 10
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'Opt1
            '
            Me.Opt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt1.CaptionName = Nothing
            Me.Opt1.Controls.Add(Me.optGrd2)
            Me.Opt1.Controls.Add(Me.optGrd3)
            Me.Opt1.Location = New System.Drawing.Point(3, 371)
            Me.Opt1.MaximumSize = New System.Drawing.Size(500, 100)
            Me.Opt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt1.Name = "Opt1"
            Me.Opt1.ReadOnlys = False
            Me.Opt1.Size = New System.Drawing.Size(206, 28)
            Me.Opt1.TabIndex = 8
            Me.Opt1.Tag = Nothing
            Me.Opt1.TextValue = ""
            '
            'optGrd2
            '
            Me.optGrd2.AutoSize = True
            Me.optGrd2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGrd2.Checked = True
            Me.optGrd2.Location = New System.Drawing.Point(25, 5)
            Me.optGrd2.Name = "optGrd2"
            Me.optGrd2.Size = New System.Drawing.Size(59, 16)
            Me.optGrd2.TabIndex = 0
            Me.optGrd2.TabStop = True
            Me.optGrd2.Text = "투입처"
            Me.optGrd2.UseVisualStyleBackColor = False
            '
            'optGrd3
            '
            Me.optGrd3.AutoSize = True
            Me.optGrd3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optGrd3.Location = New System.Drawing.Point(115, 5)
            Me.optGrd3.Name = "optGrd3"
            Me.optGrd3.Size = New System.Drawing.Size(59, 16)
            Me.optGrd3.TabIndex = 1
            Me.optGrd3.Text = "권유자"
            Me.optGrd3.UseVisualStyleBackColor = False
            '
            'picCriteria2
            '
            Me.picCriteria2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria2.Location = New System.Drawing.Point(505, 3)
            Me.picCriteria2.Name = "picCriteria2"
            Me.picCriteria2.Size = New System.Drawing.Size(302, 41)
            Me.picCriteria2.TabIndex = 1639
            Me.picCriteria2.TabStop = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label1.Location = New System.Drawing.Point(624, 54)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(177, 25)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(621, 48)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(186, 36)
            Me.PictureBox1.TabIndex = 1641
            Me.PictureBox1.TabStop = False
            '
            'dtpApprovalDt
            '
            Me.dtpApprovalDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpApprovalDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpApprovalDt.BorderStyle = 2
            Me.dtpApprovalDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpApprovalDt.CaptionName = "접수 일자"
            Me.dtpApprovalDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpApprovalDt.Location = New System.Drawing.Point(584, 14)
            Me.dtpApprovalDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpApprovalDt.MaxLength = 0
            Me.dtpApprovalDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpApprovalDt.Name = "dtpApprovalDt"
            Me.dtpApprovalDt.ReadOnlys = False
            Me.dtpApprovalDt.SelectedText = ""
            Me.dtpApprovalDt.SelectionLength = 0
            Me.dtpApprovalDt.SelectionStart = 0
            Me.dtpApprovalDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpApprovalDt.TabIndex = 2
            Me.dtpApprovalDt.Tag = "format(####-##-##);"
            Me.dtpApprovalDt.TextAlign = 0
            Me.dtpApprovalDt.TextValue = ""
            Me.dtpApprovalDt.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(522, 17)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(59, 15)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "승인일자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(707, 9)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(90, 31)
            Me.btnApprovalAll.TabIndex = 3
            Me.btnApprovalAll.Text = "일괄 승인"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'PNE103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpApprovalDt)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.picCriteria2)
            Me.Controls.Add(Me.Opt1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dtpToExpand)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.dtpFromExpand)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_3)
            Me.Name = "PNE103"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.dtpFromExpand, 0)
            Me.Controls.SetChildIndex(Me.lblExpandDt, 0)
            Me.Controls.SetChildIndex(Me.dtpToExpand, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.Opt2, 0)
            Me.Controls.SetChildIndex(Me.Opt1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.dtpApprovalDt, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt1.ResumeLayout(False)
            Me.Opt1.PerformLayout()
            CType(Me.picCriteria2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpToExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpFromExpand As ubiLease.CommonControls.dtp
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optExpAmt3 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt2 As System.Windows.Forms.RadioButton
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents Opt1 As ubiLease.CommonControls.opt
        Friend WithEvents optGrd2 As System.Windows.Forms.RadioButton
        Friend WithEvents optGrd3 As System.Windows.Forms.RadioButton
        Friend WithEvents picCriteria2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpApprovalDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button


    End Class

End Namespace
