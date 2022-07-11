Namespace ubiLease.UI.BusinessUi.AC

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMCB01
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMCB01))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.btnMove1 = New ubiLease.CommonControls.btn
            Me.btnMove2 = New ubiLease.CommonControls.btn
            Me.cboEmployeeNumber = New ubiLease.CommonControls.cbo
            Me.cboRoleCode = New ubiLease.CommonControls.cbo
            Me.lblRoleCode = New System.Windows.Forms.Label
            Me.lblEmployeeNumber = New System.Windows.Forms.Label
            Me.lblOnesPositionDepartmentCode = New System.Windows.Forms.Label
            Me.popOnesPositionDepartmentCode = New ubiLease.CommonControls.pop
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 50)
            Me.picCriteria_1.TabIndex = 0
            Me.picCriteria_1.TabStop = False
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.grd_1.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_1.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 61)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(328, 580)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 0
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
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
            Me.grd_2.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(372, 61)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 15
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(433, 579)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 4
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnMove1
            '
            Me.btnMove1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnMove1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnMove1.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnMove1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnMove1.Location = New System.Drawing.Point(340, 251)
            Me.btnMove1.Name = "btnMove1"
            Me.btnMove1.Size = New System.Drawing.Size(26, 38)
            Me.btnMove1.TabIndex = 39
            Me.btnMove1.TabStop = False
            Me.btnMove1.Text = "▶"
            Me.btnMove1.UseVisualStyleBackColor = True
            '
            'btnMove2
            '
            Me.btnMove2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnMove2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnMove2.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnMove2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnMove2.Location = New System.Drawing.Point(340, 313)
            Me.btnMove2.Name = "btnMove2"
            Me.btnMove2.Size = New System.Drawing.Size(26, 38)
            Me.btnMove2.TabIndex = 40
            Me.btnMove2.TabStop = False
            Me.btnMove2.Text = "◀"
            Me.btnMove2.UseVisualStyleBackColor = True
            '
            'cboEmployeeNumber
            '
            Me.cboEmployeeNumber.CaptionName = "시스템 구분 명"
            Me.cboEmployeeNumber.ListCount = 0
            Me.cboEmployeeNumber.Location = New System.Drawing.Point(102, 21)
            Me.cboEmployeeNumber.Name = "cboEmployeeNumber"
            Me.cboEmployeeNumber.ReadOnlys = False
            Me.cboEmployeeNumber.Size = New System.Drawing.Size(153, 20)
            Me.cboEmployeeNumber.TabIndex = 52
            Me.cboEmployeeNumber.Tag = "need;code(시스템 구분 명|선택하세요);"
            Me.cboEmployeeNumber.TextValue = ""
            '
            'cboRoleCode
            '
            Me.cboRoleCode.CaptionName = "롤 코드 명"
            Me.cboRoleCode.ListCount = 0
            Me.cboRoleCode.Location = New System.Drawing.Point(338, 21)
            Me.cboRoleCode.Name = "cboRoleCode"
            Me.cboRoleCode.ReadOnlys = False
            Me.cboRoleCode.Size = New System.Drawing.Size(170, 20)
            Me.cboRoleCode.TabIndex = 53
            Me.cboRoleCode.Tag = "need;code(롤 코드 명, 시스템 구분 명|선택 하세요);"
            Me.cboRoleCode.TextValue = ""
            '
            'lblRoleCode
            '
            Me.lblRoleCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRoleCode.Location = New System.Drawing.Point(271, 24)
            Me.lblRoleCode.Name = "lblRoleCode"
            Me.lblRoleCode.Size = New System.Drawing.Size(61, 15)
            Me.lblRoleCode.TabIndex = 54
            Me.lblRoleCode.Text = "역할 코드"
            Me.lblRoleCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblEmployeeNumber
            '
            Me.lblEmployeeNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblEmployeeNumber.Location = New System.Drawing.Point(13, 24)
            Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
            Me.lblEmployeeNumber.Size = New System.Drawing.Size(83, 15)
            Me.lblEmployeeNumber.TabIndex = 55
            Me.lblEmployeeNumber.Text = "시스템 구분"
            Me.lblEmployeeNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblOnesPositionDepartmentCode
            '
            Me.lblOnesPositionDepartmentCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblOnesPositionDepartmentCode.Location = New System.Drawing.Point(527, 24)
            Me.lblOnesPositionDepartmentCode.Name = "lblOnesPositionDepartmentCode"
            Me.lblOnesPositionDepartmentCode.Size = New System.Drawing.Size(61, 15)
            Me.lblOnesPositionDepartmentCode.TabIndex = 57
            Me.lblOnesPositionDepartmentCode.Text = "조직 코드"
            Me.lblOnesPositionDepartmentCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popOnesPositionDepartmentCode
            '
            Me.popOnesPositionDepartmentCode.BorderColor = System.Drawing.Color.Empty
            Me.popOnesPositionDepartmentCode.BorderStyle = 2
            Me.popOnesPositionDepartmentCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popOnesPositionDepartmentCode.CaptionName = "파트 코드"
            Me.popOnesPositionDepartmentCode.CodeText = ""
            Me.popOnesPositionDepartmentCode.CodeWidth = 60
            Me.popOnesPositionDepartmentCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popOnesPositionDepartmentCode.Location = New System.Drawing.Point(594, 21)
            Me.popOnesPositionDepartmentCode.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popOnesPositionDepartmentCode.MaxLength = 8
            Me.popOnesPositionDepartmentCode.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popOnesPositionDepartmentCode.Name = "popOnesPositionDepartmentCode"
            Me.popOnesPositionDepartmentCode.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popOnesPositionDepartmentCode.NameText = ""
            Me.popOnesPositionDepartmentCode.ReadOnlys = False
            Me.popOnesPositionDepartmentCode.SelectedText = ""
            Me.popOnesPositionDepartmentCode.SelectionLength = 0
            Me.popOnesPositionDepartmentCode.SelectionStart = 0
            Me.popOnesPositionDepartmentCode.Size = New System.Drawing.Size(188, 20)
            Me.popOnesPositionDepartmentCode.TabIndex = 101
            Me.popOnesPositionDepartmentCode.Tag = "code(파트 명);"
            Me.popOnesPositionDepartmentCode.TextAlign = 0
            Me.popOnesPositionDepartmentCode.TextValue = ""
            Me.popOnesPositionDepartmentCode.ToolTipText = ""
            '
            'SMCB01
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popOnesPositionDepartmentCode)
            Me.Controls.Add(Me.lblOnesPositionDepartmentCode)
            Me.Controls.Add(Me.lblEmployeeNumber)
            Me.Controls.Add(Me.lblRoleCode)
            Me.Controls.Add(Me.cboRoleCode)
            Me.Controls.Add(Me.cboEmployeeNumber)
            Me.Controls.Add(Me.btnMove2)
            Me.Controls.Add(Me.btnMove1)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMCB01"
            Me.Size = New System.Drawing.Size(810, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents btnMove1 As ubiLease.CommonControls.btn
        Friend WithEvents btnMove2 As ubiLease.CommonControls.btn
        Friend WithEvents cboEmployeeNumber As ubiLease.CommonControls.cbo
        Friend WithEvents cboRoleCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblRoleCode As System.Windows.Forms.Label
        Friend WithEvents lblEmployeeNumber As System.Windows.Forms.Label
        Friend WithEvents lblOnesPositionDepartmentCode As System.Windows.Forms.Label
        Friend WithEvents popOnesPositionDepartmentCode As ubiLease.CommonControls.pop

    End Class

End Namespace
