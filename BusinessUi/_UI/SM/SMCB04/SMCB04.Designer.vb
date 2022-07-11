Namespace ubiLease.UI.BusinessUi.AC

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMCB04
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMCB04))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.btnMove1 = New ubiLease.CommonControls.btn
            Me.btnMove2 = New ubiLease.CommonControls.btn
            Me.cboSystemDivision = New ubiLease.CommonControls.cbo
            Me.lblEmployeeNumber = New System.Windows.Forms.Label
            Me.lblOnesPositionDepartmentCode = New System.Windows.Forms.Label
            Me.popOnesPositionDepartmentCode = New ubiLease.CommonControls.pop
            Me.lblSeviceStatesCode2 = New System.Windows.Forms.Label
            Me.cboSeviceStatesCode = New ubiLease.CommonControls.cbo
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.grd_4 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtEmployeeNumber = New ubiLease.CommonControls.txt
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.lblSeviceDivisionCode = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 77)
            Me.picCriteria_1.TabIndex = 0
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 88)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 148)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 0
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_3.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(424, 254)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 15
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(381, 157)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 4
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnMove1
            '
            Me.btnMove1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnMove1.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnMove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnMove1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnMove1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnMove1.Location = New System.Drawing.Point(392, 288)
            Me.btnMove1.Name = "btnMove1"
            Me.btnMove1.Size = New System.Drawing.Size(26, 38)
            Me.btnMove1.TabIndex = 39
            Me.btnMove1.TabStop = False
            Me.btnMove1.Text = "▶"
            Me.btnMove1.UseVisualStyleBackColor = True
            '
            'btnMove2
            '
            Me.btnMove2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnMove2.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnMove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnMove2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnMove2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnMove2.Location = New System.Drawing.Point(392, 333)
            Me.btnMove2.Name = "btnMove2"
            Me.btnMove2.Size = New System.Drawing.Size(26, 38)
            Me.btnMove2.TabIndex = 40
            Me.btnMove2.TabStop = False
            Me.btnMove2.Text = "◀"
            Me.btnMove2.UseVisualStyleBackColor = True
            '
            'cboSystemDivision
            '
            Me.cboSystemDivision.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision.ListCount = 0
            Me.cboSystemDivision.Location = New System.Drawing.Point(88, 20)
            Me.cboSystemDivision.Name = "cboSystemDivision"
            Me.cboSystemDivision.ReadOnlys = False
            Me.cboSystemDivision.Size = New System.Drawing.Size(133, 20)
            Me.cboSystemDivision.TabIndex = 52
            Me.cboSystemDivision.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision.TextValue = ""
            '
            'lblEmployeeNumber
            '
            Me.lblEmployeeNumber.AutoSize = True
            Me.lblEmployeeNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblEmployeeNumber.Location = New System.Drawing.Point(13, 24)
            Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
            Me.lblEmployeeNumber.Size = New System.Drawing.Size(69, 12)
            Me.lblEmployeeNumber.TabIndex = 55
            Me.lblEmployeeNumber.Text = "시스템 구분"
            Me.lblEmployeeNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblOnesPositionDepartmentCode
            '
            Me.lblOnesPositionDepartmentCode.AutoSize = True
            Me.lblOnesPositionDepartmentCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblOnesPositionDepartmentCode.Location = New System.Drawing.Point(328, 24)
            Me.lblOnesPositionDepartmentCode.Name = "lblOnesPositionDepartmentCode"
            Me.lblOnesPositionDepartmentCode.Size = New System.Drawing.Size(57, 12)
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
            Me.popOnesPositionDepartmentCode.Location = New System.Drawing.Point(391, 20)
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
            Me.popOnesPositionDepartmentCode.Size = New System.Drawing.Size(301, 20)
            Me.popOnesPositionDepartmentCode.TabIndex = 101
            Me.popOnesPositionDepartmentCode.Tag = "code(파트 명);"
            Me.popOnesPositionDepartmentCode.TextAlign = 0
            Me.popOnesPositionDepartmentCode.TextValue = ""
            Me.popOnesPositionDepartmentCode.ToolTipText = ""
            '
            'lblSeviceStatesCode2
            '
            Me.lblSeviceStatesCode2.AutoSize = True
            Me.lblSeviceStatesCode2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblSeviceStatesCode2.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSeviceStatesCode2.Location = New System.Drawing.Point(332, 50)
            Me.lblSeviceStatesCode2.Name = "lblSeviceStatesCode2"
            Me.lblSeviceStatesCode2.Size = New System.Drawing.Size(53, 12)
            Me.lblSeviceStatesCode2.TabIndex = 795
            Me.lblSeviceStatesCode2.Text = "근무상태"
            Me.lblSeviceStatesCode2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboSeviceStatesCode
            '
            Me.cboSeviceStatesCode.CaptionName = "최종 발령 코드"
            Me.cboSeviceStatesCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSeviceStatesCode.ListCount = 0
            Me.cboSeviceStatesCode.Location = New System.Drawing.Point(391, 46)
            Me.cboSeviceStatesCode.Name = "cboSeviceStatesCode"
            Me.cboSeviceStatesCode.ReadOnlys = False
            Me.cboSeviceStatesCode.Size = New System.Drawing.Size(87, 20)
            Me.cboSeviceStatesCode.TabIndex = 794
            Me.cboSeviceStatesCode.Tag = "code(근무 상태 명);"
            Me.cboSeviceStatesCode.TextValue = ""
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
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
            Me.grd_2.Location = New System.Drawing.Point(4, 254)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 15
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(382, 157)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 796
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_4
            '
            Me.grd_4.AllowBigSelection = False
            Me.grd_4.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_4.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_4.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_4.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_4.Cols = 2
            Me.grd_4.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExtendLastCol = True
            Me.grd_4.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_4.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_4.FrozenCols = 1
            Me.grd_4.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_4.Location = New System.Drawing.Point(6, 417)
            Me.grd_4.Name = "grd_4"
            Me.grd_4.NodeClosedPicture = Nothing
            Me.grd_4.NodeOpenPicture = Nothing
            Me.grd_4.OutlineCol = -1
            Me.grd_4.RowHeightMax = 18
            Me.grd_4.RowHeightMin = 18
            Me.grd_4.Rows = 2
            Me.grd_4.Size = New System.Drawing.Size(799, 223)
            Me.grd_4.StyleInfo = resources.GetString("grd_4.StyleInfo")
            Me.grd_4.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_4.TabIndex = 797
            Me.grd_4.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(422, 239)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(119, 12)
            Me.Label1.TabIndex = 798
            Me.Label1.Text = "부여 되지 않은 역할"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(4, 239)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(71, 12)
            Me.Label2.TabIndex = 799
            Me.Label2.Text = "부여된 역할"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtEmployeeNumber
            '
            Me.txtEmployeeNumber.BackColor = System.Drawing.SystemColors.Window
            Me.txtEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.txtEmployeeNumber.BorderStyle = 2
            Me.txtEmployeeNumber.CaptionName = ""
            Me.txtEmployeeNumber.Location = New System.Drawing.Point(396, 242)
            Me.txtEmployeeNumber.MaxLength = 100
            Me.txtEmployeeNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtEmployeeNumber.Multiline = False
            Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
            Me.txtEmployeeNumber.ReadOnlys = False
            Me.txtEmployeeNumber.SelectedText = ""
            Me.txtEmployeeNumber.SelectionLength = 0
            Me.txtEmployeeNumber.SelectionStart = 0
            Me.txtEmployeeNumber.Size = New System.Drawing.Size(20, 20)
            Me.txtEmployeeNumber.TabIndex = 800
            Me.txtEmployeeNumber.Tag = "read;"
            Me.txtEmployeeNumber.TextAlign = 0
            Me.txtEmployeeNumber.TextValue = ""
            Me.txtEmployeeNumber.ToolTipText = ""
            Me.txtEmployeeNumber.Visible = False
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "사원 번호"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(88, 46)
            Me.popEmployeeNumber.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popEmployeeNumber.MaxLength = 6
            Me.popEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeNumber.Name = "popEmployeeNumber"
            Me.popEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeNumber.NameText = ""
            Me.popEmployeeNumber.ReadOnlys = False
            Me.popEmployeeNumber.SelectedText = ""
            Me.popEmployeeNumber.SelectionLength = 0
            Me.popEmployeeNumber.SelectionStart = 0
            Me.popEmployeeNumber.Size = New System.Drawing.Size(198, 20)
            Me.popEmployeeNumber.TabIndex = 802
            Me.popEmployeeNumber.Tag = "code(사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'lblSeviceDivisionCode
            '
            Me.lblSeviceDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSeviceDivisionCode.Location = New System.Drawing.Point(22, 49)
            Me.lblSeviceDivisionCode.Name = "lblSeviceDivisionCode"
            Me.lblSeviceDivisionCode.Size = New System.Drawing.Size(60, 15)
            Me.lblSeviceDivisionCode.TabIndex = 801
            Me.lblSeviceDivisionCode.Text = "사원 번호"
            '
            'SMCB04
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.lblSeviceDivisionCode)
            Me.Controls.Add(Me.txtEmployeeNumber)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_4)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.lblSeviceStatesCode2)
            Me.Controls.Add(Me.cboSeviceStatesCode)
            Me.Controls.Add(Me.popOnesPositionDepartmentCode)
            Me.Controls.Add(Me.lblOnesPositionDepartmentCode)
            Me.Controls.Add(Me.lblEmployeeNumber)
            Me.Controls.Add(Me.cboSystemDivision)
            Me.Controls.Add(Me.btnMove2)
            Me.Controls.Add(Me.btnMove1)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMCB04"
            Me.Size = New System.Drawing.Size(810, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents btnMove1 As ubiLease.CommonControls.btn
        Friend WithEvents btnMove2 As ubiLease.CommonControls.btn
        Friend WithEvents cboSystemDivision As ubiLease.CommonControls.cbo
        Friend WithEvents lblEmployeeNumber As System.Windows.Forms.Label
        Friend WithEvents lblOnesPositionDepartmentCode As System.Windows.Forms.Label
        Friend WithEvents popOnesPositionDepartmentCode As ubiLease.CommonControls.pop
        Friend WithEvents lblSeviceStatesCode2 As System.Windows.Forms.Label
        Friend WithEvents cboSeviceStatesCode As ubiLease.CommonControls.cbo
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents grd_4 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtEmployeeNumber As ubiLease.CommonControls.txt
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents lblSeviceDivisionCode As System.Windows.Forms.Label

    End Class

End Namespace
