Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA301))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblRepresentativeName = New System.Windows.Forms.Label
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.btn_Down = New System.Windows.Forms.Button
            Me.btn_up = New System.Windows.Forms.Button
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.cboChargeTypeCd = New ubiLease.CommonControls.cbo
            Me.picio = New System.Windows.Forms.PictureBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.cboChargeTypeCd_1 = New ubiLease.CommonControls.cbo
            Me.popChargeEmpNum_1 = New ubiLease.CommonControls.pop
            Me.Label7 = New System.Windows.Forms.Label
            Me.PopBranchCd = New ubiLease.CommonControls.pop
            Me.Label8 = New System.Windows.Forms.Label
            Me.popDeptCd = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picio, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(3, 93)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 155)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
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
            Me.picCriteria.Size = New System.Drawing.Size(805, 70)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
            '
            'lblRepresentativeName
            '
            Me.lblRepresentativeName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRepresentativeName.Location = New System.Drawing.Point(30, 20)
            Me.lblRepresentativeName.Name = "lblRepresentativeName"
            Me.lblRepresentativeName.Size = New System.Drawing.Size(51, 14)
            Me.lblRepresentativeName.TabIndex = 764
            Me.lblRepresentativeName.Text = "담당자"
            Me.lblRepresentativeName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "담당자"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 50
            Me.popChargeEmpNum.Location = New System.Drawing.Point(87, 15)
            Me.popChargeEmpNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum.MaxLength = 6
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum.NameText = ""
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(180, 20)
            Me.popChargeEmpNum.TabIndex = 769
            Me.popChargeEmpNum.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
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
            Me.grd_2.Location = New System.Drawing.Point(442, 309)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(366, 335)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 773
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
            Me.grd_3.Location = New System.Drawing.Point(3, 309)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(397, 335)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 774
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'btn_Down
            '
            Me.btn_Down.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btn_Down.Location = New System.Drawing.Point(406, 369)
            Me.btn_Down.Name = "btn_Down"
            Me.btn_Down.Size = New System.Drawing.Size(30, 41)
            Me.btn_Down.TabIndex = 775
            Me.btn_Down.Text = "◀"
            Me.btn_Down.UseVisualStyleBackColor = True
            '
            'btn_up
            '
            Me.btn_up.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btn_up.Location = New System.Drawing.Point(406, 430)
            Me.btn_up.Name = "btn_up"
            Me.btn_up.Size = New System.Drawing.Size(30, 41)
            Me.btn_up.TabIndex = 776
            Me.btn_up.Text = "▶"
            Me.btn_up.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Red
            Me.Label2.Location = New System.Drawing.Point(442, 292)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(369, 14)
            Me.Label2.TabIndex = 777
            Me.Label2.Text = "담당 미지정 지국"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Blue
            Me.Label3.Location = New System.Drawing.Point(3, 292)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(356, 14)
            Me.Label3.TabIndex = 778
            Me.Label3.Text = "담당 지정 지국"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(3, 76)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(805, 14)
            Me.Label4.TabIndex = 779
            Me.Label4.Text = "담당자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label5.Location = New System.Drawing.Point(296, 18)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(63, 17)
            Me.Label5.TabIndex = 821
            Me.Label5.Text = "담당유형"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboChargeTypeCd
            '
            Me.cboChargeTypeCd.CaptionName = "담당 유형"
            Me.cboChargeTypeCd.ListCount = 0
            Me.cboChargeTypeCd.Location = New System.Drawing.Point(365, 14)
            Me.cboChargeTypeCd.Name = "cboChargeTypeCd"
            Me.cboChargeTypeCd.ReadOnlys = False
            Me.cboChargeTypeCd.Size = New System.Drawing.Size(200, 20)
            Me.cboChargeTypeCd.TabIndex = 820
            Me.cboChargeTypeCd.Tag = "code(담당자유형코드);"
            Me.cboChargeTypeCd.TextValue = ""
            '
            'picio
            '
            Me.picio.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picio.Location = New System.Drawing.Point(3, 256)
            Me.picio.Name = "picio"
            Me.picio.Size = New System.Drawing.Size(406, 33)
            Me.picio.TabIndex = 822
            Me.picio.TabStop = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label6.Location = New System.Drawing.Point(226, 265)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(63, 17)
            Me.Label6.TabIndex = 824
            Me.Label6.Text = "담당유형"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboChargeTypeCd_1
            '
            Me.cboChargeTypeCd_1.CaptionName = "담당 유형"
            Me.cboChargeTypeCd_1.ListCount = 0
            Me.cboChargeTypeCd_1.Location = New System.Drawing.Point(295, 262)
            Me.cboChargeTypeCd_1.Name = "cboChargeTypeCd_1"
            Me.cboChargeTypeCd_1.ReadOnlys = False
            Me.cboChargeTypeCd_1.Size = New System.Drawing.Size(100, 20)
            Me.cboChargeTypeCd_1.TabIndex = 823
            Me.cboChargeTypeCd_1.Tag = "code(담당자유형코드);"
            Me.cboChargeTypeCd_1.TextValue = ""
            '
            'popChargeEmpNum_1
            '
            Me.popChargeEmpNum_1.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_1.BorderStyle = 2
            Me.popChargeEmpNum_1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_1.CaptionName = "담당자"
            Me.popChargeEmpNum_1.CodeText = ""
            Me.popChargeEmpNum_1.CodeWidth = 50
            Me.popChargeEmpNum_1.Location = New System.Drawing.Point(70, 262)
            Me.popChargeEmpNum_1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum_1.MaxLength = 6
            Me.popChargeEmpNum_1.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum_1.Name = "popChargeEmpNum_1"
            Me.popChargeEmpNum_1.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_1.NameText = ""
            Me.popChargeEmpNum_1.ReadOnlys = False
            Me.popChargeEmpNum_1.SelectedText = ""
            Me.popChargeEmpNum_1.SelectionLength = 0
            Me.popChargeEmpNum_1.SelectionStart = 0
            Me.popChargeEmpNum_1.Size = New System.Drawing.Size(150, 20)
            Me.popChargeEmpNum_1.TabIndex = 826
            Me.popChargeEmpNum_1.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_1.TextAlign = 0
            Me.popChargeEmpNum_1.TextValue = ""
            Me.popChargeEmpNum_1.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(13, 267)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(51, 14)
            Me.Label7.TabIndex = 825
            Me.Label7.Text = "담당자"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PopBranchCd
            '
            Me.PopBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.PopBranchCd.BorderStyle = 2
            Me.PopBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopBranchCd.CaptionName = "지국코드"
            Me.PopBranchCd.CodeText = ""
            Me.PopBranchCd.CodeWidth = 70
            Me.PopBranchCd.Location = New System.Drawing.Point(365, 40)
            Me.PopBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopBranchCd.MaxLength = 7
            Me.PopBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopBranchCd.Name = "PopBranchCd"
            Me.PopBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopBranchCd.NameText = ""
            Me.PopBranchCd.ReadOnlys = False
            Me.PopBranchCd.SelectedText = ""
            Me.PopBranchCd.SelectionLength = 0
            Me.PopBranchCd.SelectionStart = 0
            Me.PopBranchCd.Size = New System.Drawing.Size(229, 20)
            Me.PopBranchCd.TabIndex = 1095
            Me.PopBranchCd.Tag = "code(지국코드);"
            Me.PopBranchCd.TextAlign = 0
            Me.PopBranchCd.TextValue = ""
            Me.PopBranchCd.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label8.Location = New System.Drawing.Point(296, 44)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(63, 17)
            Me.Label8.TabIndex = 1094
            Me.Label8.Text = "지국코드"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popDeptCd
            '
            Me.popDeptCd.BorderColor = System.Drawing.Color.Empty
            Me.popDeptCd.BorderStyle = 2
            Me.popDeptCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeptCd.CaptionName = "부서 명"
            Me.popDeptCd.CodeText = ""
            Me.popDeptCd.CodeWidth = 50
            Me.popDeptCd.Location = New System.Drawing.Point(87, 41)
            Me.popDeptCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popDeptCd.MaxLength = 5
            Me.popDeptCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popDeptCd.Name = "popDeptCd"
            Me.popDeptCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popDeptCd.NameText = ""
            Me.popDeptCd.ReadOnlys = False
            Me.popDeptCd.SelectedText = ""
            Me.popDeptCd.SelectionLength = 0
            Me.popDeptCd.SelectionStart = 0
            Me.popDeptCd.Size = New System.Drawing.Size(180, 20)
            Me.popDeptCd.TabIndex = 770
            Me.popDeptCd.Tag = "code(부서 명);"
            Me.popDeptCd.TextAlign = 0
            Me.popDeptCd.TextValue = ""
            Me.popDeptCd.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(46, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 768
            Me.Label1.Text = "부서"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNA301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.PopBranchCd)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.popChargeEmpNum_1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboChargeTypeCd_1)
            Me.Controls.Add(Me.picio)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboChargeTypeCd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btn_up)
            Me.Controls.Add(Me.btn_Down)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.popDeptCd)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblRepresentativeName)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNA301"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblRepresentativeName As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents btn_Down As System.Windows.Forms.Button
        Friend WithEvents btn_up As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboChargeTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents picio As System.Windows.Forms.PictureBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboChargeTypeCd_1 As ubiLease.CommonControls.cbo
        Friend WithEvents popChargeEmpNum_1 As ubiLease.CommonControls.pop
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents PopBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents popDeptCd As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class

End Namespace
