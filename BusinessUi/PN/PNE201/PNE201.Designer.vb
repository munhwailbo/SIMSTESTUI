Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE201))
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpToExpand = New ubiLease.CommonControls.dtp
            Me.lblExpandDt = New System.Windows.Forms.Label
            Me.dtpFromExpand = New ubiLease.CommonControls.dtp
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            Me.popTrAdEmployeeNum = New ubiLease.CommonControls.pop
            Me.Label17 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.popTrAdEmployeeDeptCd = New ubiLease.CommonControls.pop
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optReceipt = New System.Windows.Forms.RadioButton
            Me.optMonitor = New System.Windows.Forms.RadioButton
            Me.Label2 = New System.Windows.Forms.Label
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(805, 64)
            Me.PictureBox1.TabIndex = 963
            Me.PictureBox1.TabStop = False
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_1.BackColorBkg = System.Drawing.Color.White
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 110)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.SheetBorder = System.Drawing.Color.DarkGray
            Me.grd_1.Size = New System.Drawing.Size(805, 533)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 6
            Me.grd_1.Tree.LineColor = System.Drawing.Color.DimGray
            Me.grd_1.TreeColor = System.Drawing.Color.DimGray
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(220, 15)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(18, 20)
            Me.Label5.TabIndex = 9
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
            Me.dtpToExpand.Location = New System.Drawing.Point(244, 15)
            Me.dtpToExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToExpand.MaxLength = 0
            Me.dtpToExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToExpand.Name = "dtpToExpand"
            Me.dtpToExpand.ReadOnlys = False
            Me.dtpToExpand.SelectedText = ""
            Me.dtpToExpand.SelectionLength = 0
            Me.dtpToExpand.SelectionStart = 0
            Me.dtpToExpand.Size = New System.Drawing.Size(100, 20)
            Me.dtpToExpand.TabIndex = 1
            Me.dtpToExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpToExpand.TextAlign = 0
            Me.dtpToExpand.TextValue = ""
            Me.dtpToExpand.ToolTipText = ""
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(39, 18)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(73, 15)
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
            Me.dtpFromExpand.Location = New System.Drawing.Point(118, 15)
            Me.dtpFromExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromExpand.MaxLength = 0
            Me.dtpFromExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromExpand.Name = "dtpFromExpand"
            Me.dtpFromExpand.ReadOnlys = False
            Me.dtpFromExpand.SelectedText = ""
            Me.dtpFromExpand.SelectionLength = 0
            Me.dtpFromExpand.SelectionStart = 0
            Me.dtpFromExpand.Size = New System.Drawing.Size(100, 20)
            Me.dtpFromExpand.TabIndex = 0
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
            Me.popCompanyCd.Location = New System.Drawing.Point(489, 15)
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
            Me.popCompanyCd.Size = New System.Drawing.Size(244, 20)
            Me.popCompanyCd.TabIndex = 2
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(418, 18)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(65, 15)
            Me.lblFormDivisionCode.TabIndex = 10
            Me.lblFormDivisionCode.Text = "확장처"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popTrAdEmployeeNum
            '
            Me.popTrAdEmployeeNum.BorderColor = System.Drawing.Color.Empty
            Me.popTrAdEmployeeNum.BorderStyle = 2
            Me.popTrAdEmployeeNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTrAdEmployeeNum.CaptionName = "권유자 코드"
            Me.popTrAdEmployeeNum.CodeText = ""
            Me.popTrAdEmployeeNum.CodeWidth = 60
            Me.popTrAdEmployeeNum.Location = New System.Drawing.Point(118, 38)
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
            Me.popTrAdEmployeeNum.Size = New System.Drawing.Size(226, 20)
            Me.popTrAdEmployeeNum.TabIndex = 3
            Me.popTrAdEmployeeNum.Tag = "code(사원 명);rtnValue(popTrAdEmployeeDeptCd);"
            Me.popTrAdEmployeeNum.TextAlign = 0
            Me.popTrAdEmployeeNum.TextValue = ""
            Me.popTrAdEmployeeNum.ToolTipText = ""
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label17.Location = New System.Drawing.Point(39, 39)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(73, 18)
            Me.Label17.TabIndex = 8
            Me.Label17.Text = "권유자명"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(418, 39)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(65, 18)
            Me.Label1.TabIndex = 11
            Me.Label1.Text = "권유자부서"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popTrAdEmployeeDeptCd
            '
            Me.popTrAdEmployeeDeptCd.BorderColor = System.Drawing.Color.Empty
            Me.popTrAdEmployeeDeptCd.BorderStyle = 2
            Me.popTrAdEmployeeDeptCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTrAdEmployeeDeptCd.CaptionName = "부서 명"
            Me.popTrAdEmployeeDeptCd.CodeText = ""
            Me.popTrAdEmployeeDeptCd.CodeWidth = 50
            Me.popTrAdEmployeeDeptCd.Location = New System.Drawing.Point(489, 38)
            Me.popTrAdEmployeeDeptCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popTrAdEmployeeDeptCd.MaxLength = 5
            Me.popTrAdEmployeeDeptCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popTrAdEmployeeDeptCd.Name = "popTrAdEmployeeDeptCd"
            Me.popTrAdEmployeeDeptCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popTrAdEmployeeDeptCd.NameText = ""
            Me.popTrAdEmployeeDeptCd.ReadOnlys = False
            Me.popTrAdEmployeeDeptCd.SelectedText = ""
            Me.popTrAdEmployeeDeptCd.SelectionLength = 0
            Me.popTrAdEmployeeDeptCd.SelectionStart = 0
            Me.popTrAdEmployeeDeptCd.Size = New System.Drawing.Size(244, 20)
            Me.popTrAdEmployeeDeptCd.TabIndex = 4
            Me.popTrAdEmployeeDeptCd.Tag = "code(부서 명);"
            Me.popTrAdEmployeeDeptCd.TextAlign = 0
            Me.popTrAdEmployeeDeptCd.TextValue = ""
            Me.popTrAdEmployeeDeptCd.ToolTipText = ""
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optReceipt)
            Me.Opt2.Controls.Add(Me.optMonitor)
            Me.Opt2.Location = New System.Drawing.Point(3, 70)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 200)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(306, 36)
            Me.Opt2.TabIndex = 12
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optReceipt
            '
            Me.optReceipt.AutoSize = True
            Me.optReceipt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optReceipt.Checked = True
            Me.optReceipt.Location = New System.Drawing.Point(33, 10)
            Me.optReceipt.Name = "optReceipt"
            Me.optReceipt.Size = New System.Drawing.Size(95, 16)
            Me.optReceipt.TabIndex = 0
            Me.optReceipt.TabStop = True
            Me.optReceipt.Text = "발행자보관용"
            Me.optReceipt.UseVisualStyleBackColor = False
            '
            'optMonitor
            '
            Me.optMonitor.AutoSize = True
            Me.optMonitor.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMonitor.Location = New System.Drawing.Point(167, 10)
            Me.optMonitor.Name = "optMonitor"
            Me.optMonitor.Size = New System.Drawing.Size(95, 16)
            Me.optMonitor.TabIndex = 1
            Me.optMonitor.Text = "소득자보관용"
            Me.optMonitor.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label2.Location = New System.Drawing.Point(343, 76)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(452, 25)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(312, 70)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(496, 36)
            Me.PictureBox2.TabIndex = 1643
            Me.PictureBox2.TabStop = False
            '
            'PNE201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.popTrAdEmployeeDeptCd)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popTrAdEmployeeNum)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.lblFormDivisionCode)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dtpToExpand)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.dtpFromExpand)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNE201"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpToExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpFromExpand As ubiLease.CommonControls.dtp
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label
        Friend WithEvents popTrAdEmployeeNum As ubiLease.CommonControls.pop
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popTrAdEmployeeDeptCd As ubiLease.CommonControls.pop
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optReceipt As System.Windows.Forms.RadioButton
        Friend WithEvents optMonitor As System.Windows.Forms.RadioButton
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox


    End Class

End Namespace
