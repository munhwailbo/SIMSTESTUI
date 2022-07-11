Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMCB03
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMCB03))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblBusinessPlaceCode = New System.Windows.Forms.Label
            Me.cboBizGubun = New ubiLease.CommonControls.cbo
            Me.cboRoleCode = New ubiLease.CommonControls.cbo
            Me.lblRolCode = New System.Windows.Forms.Label
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.btn3 = New System.Windows.Forms.Button
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 48)
            Me.picCriteria_1.TabIndex = 8
            Me.picCriteria_1.TabStop = False
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_1.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
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
            Me.grd_1.Size = New System.Drawing.Size(282, 577)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 8
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblBusinessPlaceCode
            '
            Me.lblBusinessPlaceCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBusinessPlaceCode.Location = New System.Drawing.Point(22, 25)
            Me.lblBusinessPlaceCode.Name = "lblBusinessPlaceCode"
            Me.lblBusinessPlaceCode.Size = New System.Drawing.Size(99, 17)
            Me.lblBusinessPlaceCode.TabIndex = 10
            Me.lblBusinessPlaceCode.Text = "시스템 구분 명"
            Me.lblBusinessPlaceCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboBizGubun
            '
            Me.cboBizGubun.CaptionName = "시스템 구분 명"
            Me.cboBizGubun.ListCount = 0
            Me.cboBizGubun.Location = New System.Drawing.Point(127, 19)
            Me.cboBizGubun.Name = "cboBizGubun"
            Me.cboBizGubun.ReadOnlys = False
            Me.cboBizGubun.Size = New System.Drawing.Size(140, 20)
            Me.cboBizGubun.TabIndex = 9
            Me.cboBizGubun.Tag = "need;code(시스템 구분 명|선택 하세요)"
            Me.cboBizGubun.TextValue = ""
            '
            'cboRoleCode
            '
            Me.cboRoleCode.CaptionName = "역할 코드"
            Me.cboRoleCode.ListCount = 0
            Me.cboRoleCode.Location = New System.Drawing.Point(356, 19)
            Me.cboRoleCode.Name = "cboRoleCode"
            Me.cboRoleCode.ReadOnlys = False
            Me.cboRoleCode.Size = New System.Drawing.Size(140, 20)
            Me.cboRoleCode.TabIndex = 9
            Me.cboRoleCode.Tag = "need;code(롤 코드 명, 시스템 구분 명|선택 하세요)"
            Me.cboRoleCode.TextValue = ""
            '
            'lblRolCode
            '
            Me.lblRolCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRolCode.Location = New System.Drawing.Point(273, 25)
            Me.lblRolCode.Name = "lblRolCode"
            Me.lblRolCode.Size = New System.Drawing.Size(77, 14)
            Me.lblRolCode.TabIndex = 10
            Me.lblRolCode.Text = "역할 코드"
            Me.lblRolCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_2.Location = New System.Drawing.Point(293, 59)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(511, 577)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 11
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'btn3
            '
            Me.btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btn3.Location = New System.Drawing.Point(594, 16)
            Me.btn3.Name = "btn3"
            Me.btn3.Size = New System.Drawing.Size(115, 25)
            Me.btn3.TabIndex = 1690
            Me.btn3.Text = "전사 권한 부여"
            Me.btn3.UseVisualStyleBackColor = True
            '
            'SMCB03
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btn3)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.lblRolCode)
            Me.Controls.Add(Me.lblBusinessPlaceCode)
            Me.Controls.Add(Me.cboRoleCode)
            Me.Controls.Add(Me.cboBizGubun)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMCB03"
            Me.Size = New System.Drawing.Size(809, 640)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.cboBizGubun, 0)
            Me.Controls.SetChildIndex(Me.cboRoleCode, 0)
            Me.Controls.SetChildIndex(Me.lblBusinessPlaceCode, 0)
            Me.Controls.SetChildIndex(Me.lblRolCode, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.btn3, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblBusinessPlaceCode As System.Windows.Forms.Label
        Friend WithEvents cboBizGubun As ubiLease.CommonControls.cbo
        Friend WithEvents cboRoleCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblRolCode As System.Windows.Forms.Label
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents btn3 As System.Windows.Forms.Button

    End Class

End Namespace
