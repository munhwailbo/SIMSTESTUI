Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE421
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE421))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblA = New System.Windows.Forms.Label
            Me.lblB = New System.Windows.Forms.Label
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpToExpand = New ubiLease.CommonControls.dtp
            Me.lblExpandDt = New System.Windows.Forms.Label
            Me.dtpFromExpand = New ubiLease.CommonControls.dtp
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            Me.popEmployeeExpNum_R = New ubiLease.CommonControls.pop
            Me.Label4 = New System.Windows.Forms.Label
            Me.BtnNewLine = New ubiLease.CommonControls.btn
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.btnInsRow = New ubiLease.CommonControls.btn
            Me.picBar = New System.Windows.Forms.PictureBox
            Me.picBar2 = New System.Windows.Forms.PictureBox
            Me.lblBillType_R = New System.Windows.Forms.Label
            Me.cboBillType_R = New ubiLease.CommonControls.cbo
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 74)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 223)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 852
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 65)
            Me.picCriteria.TabIndex = 851
            Me.picCriteria.TabStop = False
            '
            'lblA
            '
            Me.lblA.BackColor = System.Drawing.SystemColors.Control
            Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblA.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblA.ForeColor = System.Drawing.Color.Black
            Me.lblA.Location = New System.Drawing.Point(5, 303)
            Me.lblA.Name = "lblA"
            Me.lblA.Size = New System.Drawing.Size(188, 28)
            Me.lblA.TabIndex = 853
            Me.lblA.Text = " 본사수금구독료 청구액 확정 "
            Me.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblB
            '
            Me.lblB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblB.BackColor = System.Drawing.SystemColors.Control
            Me.lblB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblB.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblB.ForeColor = System.Drawing.Color.Black
            Me.lblB.Location = New System.Drawing.Point(466, 303)
            Me.lblB.Name = "lblB"
            Me.lblB.Size = New System.Drawing.Size(203, 28)
            Me.lblB.TabIndex = 920
            Me.lblB.Text = " 본사수금구독료 상세 청구 계획 "
            Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(466, 333)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(340, 311)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 931
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(205, 15)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(18, 20)
            Me.Label5.TabIndex = 935
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
            Me.dtpToExpand.Location = New System.Drawing.Point(229, 15)
            Me.dtpToExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToExpand.MaxLength = 0
            Me.dtpToExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToExpand.Name = "dtpToExpand"
            Me.dtpToExpand.ReadOnlys = False
            Me.dtpToExpand.SelectedText = ""
            Me.dtpToExpand.SelectionLength = 0
            Me.dtpToExpand.SelectionStart = 0
            Me.dtpToExpand.Size = New System.Drawing.Size(100, 20)
            Me.dtpToExpand.TabIndex = 934
            Me.dtpToExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpToExpand.TextAlign = 0
            Me.dtpToExpand.TextValue = ""
            Me.dtpToExpand.ToolTipText = ""
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(26, 18)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(73, 15)
            Me.lblExpandDt.TabIndex = 933
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
            Me.dtpFromExpand.Location = New System.Drawing.Point(103, 15)
            Me.dtpFromExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromExpand.MaxLength = 0
            Me.dtpFromExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromExpand.Name = "dtpFromExpand"
            Me.dtpFromExpand.ReadOnlys = False
            Me.dtpFromExpand.SelectedText = ""
            Me.dtpFromExpand.SelectionLength = 0
            Me.dtpFromExpand.SelectionStart = 0
            Me.dtpFromExpand.Size = New System.Drawing.Size(100, 20)
            Me.dtpFromExpand.TabIndex = 932
            Me.dtpFromExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpFromExpand.TextAlign = 0
            Me.dtpFromExpand.TextValue = ""
            Me.dtpFromExpand.ToolTipText = ""
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(103, 39)
            Me.popCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCompanyCd.MaxLength = 32767
            Me.popCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd.Name = "popCompanyCd"
            Me.popCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd.NameText = ""
            Me.popCompanyCd.ReadOnlys = False
            Me.popCompanyCd.SelectedText = ""
            Me.popCompanyCd.SelectionLength = 0
            Me.popCompanyCd.SelectionStart = 0
            Me.popCompanyCd.Size = New System.Drawing.Size(290, 20)
            Me.popCompanyCd.TabIndex = 1207
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(26, 42)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(73, 15)
            Me.lblFormDivisionCode.TabIndex = 1208
            Me.lblFormDivisionCode.Text = "확장처"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popEmployeeExpNum_R
            '
            Me.popEmployeeExpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeExpNum_R.BorderStyle = 2
            Me.popEmployeeExpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeExpNum_R.CaptionName = "사원확장 명"
            Me.popEmployeeExpNum_R.CodeText = ""
            Me.popEmployeeExpNum_R.CodeWidth = 90
            Me.popEmployeeExpNum_R.Location = New System.Drawing.Point(497, 39)
            Me.popEmployeeExpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeExpNum_R.MaxLength = 12
            Me.popEmployeeExpNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeExpNum_R.Name = "popEmployeeExpNum_R"
            Me.popEmployeeExpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeExpNum_R.NameText = ""
            Me.popEmployeeExpNum_R.ReadOnlys = False
            Me.popEmployeeExpNum_R.SelectedText = ""
            Me.popEmployeeExpNum_R.SelectionLength = 0
            Me.popEmployeeExpNum_R.SelectionStart = 0
            Me.popEmployeeExpNum_R.Size = New System.Drawing.Size(287, 20)
            Me.popEmployeeExpNum_R.TabIndex = 1758
            Me.popEmployeeExpNum_R.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum_R.TextAlign = 0
            Me.popEmployeeExpNum_R.TextValue = ""
            Me.popEmployeeExpNum_R.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(420, 40)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 18)
            Me.Label4.TabIndex = 1759
            Me.Label4.Text = "확  장  명"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'BtnNewLine
            '
            Me.BtnNewLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnNewLine.BackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnNewLine.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.BtnNewLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnNewLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.BtnNewLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.BtnNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.BtnNewLine.Location = New System.Drawing.Point(739, 303)
            Me.BtnNewLine.Name = "BtnNewLine"
            Me.BtnNewLine.Size = New System.Drawing.Size(67, 28)
            Me.BtnNewLine.TabIndex = 1760
            Me.BtnNewLine.Text = "기초자료"
            Me.BtnNewLine.UseVisualStyleBackColor = True
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
            Me.grd_2.Location = New System.Drawing.Point(5, 333)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(455, 311)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1761
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnInsRow
            '
            Me.btnInsRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnInsRow.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnInsRow.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnInsRow.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnInsRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnInsRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnInsRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnInsRow.Location = New System.Drawing.Point(720, 303)
            Me.btnInsRow.Name = "btnInsRow"
            Me.btnInsRow.Size = New System.Drawing.Size(17, 28)
            Me.btnInsRow.TabIndex = 1762
            Me.btnInsRow.Text = "▼"
            Me.btnInsRow.UseVisualStyleBackColor = True
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.VSplit
            Me.picBar.Location = New System.Drawing.Point(461, 333)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(4, 312)
            Me.picBar.TabIndex = 1763
            Me.picBar.TabStop = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(471, 333)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(2, 312)
            Me.picBar2.TabIndex = 1764
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'lblBillType_R
            '
            Me.lblBillType_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBillType_R.Location = New System.Drawing.Point(420, 18)
            Me.lblBillType_R.Name = "lblBillType_R"
            Me.lblBillType_R.Size = New System.Drawing.Size(73, 12)
            Me.lblBillType_R.TabIndex = 1793
            Me.lblBillType_R.Text = "청구유형"
            Me.lblBillType_R.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboBillType_R
            '
            Me.cboBillType_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboBillType_R.CaptionName = "청구유형명"
            Me.cboBillType_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboBillType_R.ListCount = 0
            Me.cboBillType_R.Location = New System.Drawing.Point(497, 13)
            Me.cboBillType_R.MaxLength = 5
            Me.cboBillType_R.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboBillType_R.Name = "cboBillType_R"
            Me.cboBillType_R.ReadOnlys = False
            Me.cboBillType_R.Size = New System.Drawing.Size(287, 20)
            Me.cboBillType_R.TabIndex = 1794
            Me.cboBillType_R.Tag = "code(청구유형명|전체);"
            Me.cboBillType_R.TextValue = ""
            '
            'PNE421
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblBillType_R)
            Me.Controls.Add(Me.cboBillType_R)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.btnInsRow)
            Me.Controls.Add(Me.BtnNewLine)
            Me.Controls.Add(Me.popEmployeeExpNum_R)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.lblFormDivisionCode)
            Me.Controls.Add(Me.dtpToExpand)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.dtpFromExpand)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.lblB)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblA)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_2)
            Me.Name = "PNE421"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.lblA, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblB, 0)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.dtpFromExpand, 0)
            Me.Controls.SetChildIndex(Me.lblExpandDt, 0)
            Me.Controls.SetChildIndex(Me.dtpToExpand, 0)
            Me.Controls.SetChildIndex(Me.lblFormDivisionCode, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeExpNum_R, 0)
            Me.Controls.SetChildIndex(Me.BtnNewLine, 0)
            Me.Controls.SetChildIndex(Me.btnInsRow, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.cboBillType_R, 0)
            Me.Controls.SetChildIndex(Me.lblBillType_R, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblA As System.Windows.Forms.Label
        Friend WithEvents lblB As System.Windows.Forms.Label
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpToExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpFromExpand As ubiLease.CommonControls.dtp
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label
        Friend WithEvents popEmployeeExpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents BtnNewLine As ubiLease.CommonControls.btn
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents btnInsRow As ubiLease.CommonControls.btn
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents lblBillType_R As System.Windows.Forms.Label
        Friend WithEvents cboBillType_R As ubiLease.CommonControls.cbo


    End Class

End Namespace
