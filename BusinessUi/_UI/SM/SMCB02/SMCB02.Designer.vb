Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMCB02
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMCB02))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblBusinessPlaceCode = New System.Windows.Forms.Label
            Me.cboProgramID = New ubiLease.CommonControls.cbo
            Me.cboRoleCode = New ubiLease.CommonControls.cbo
            Me.lblRolCode = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 49)
            Me.picCriteria_1.TabIndex = 8
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 60)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 576)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 8
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblBusinessPlaceCode
            '
            Me.lblBusinessPlaceCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBusinessPlaceCode.Location = New System.Drawing.Point(22, 22)
            Me.lblBusinessPlaceCode.Name = "lblBusinessPlaceCode"
            Me.lblBusinessPlaceCode.Size = New System.Drawing.Size(99, 17)
            Me.lblBusinessPlaceCode.TabIndex = 10
            Me.lblBusinessPlaceCode.Text = "시스템 구분 명"
            Me.lblBusinessPlaceCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboProgramID
            '
            Me.cboProgramID.CaptionName = "시스템 구분 명"
            Me.cboProgramID.ListCount = 0
            Me.cboProgramID.Location = New System.Drawing.Point(127, 19)
            Me.cboProgramID.Name = "cboProgramID"
            Me.cboProgramID.ReadOnlys = False
            Me.cboProgramID.Size = New System.Drawing.Size(140, 20)
            Me.cboProgramID.TabIndex = 9
            Me.cboProgramID.Tag = "code(시스템 구분 명);"
            Me.cboProgramID.TextValue = ""
            '
            'cboRoleCode
            '
            Me.cboRoleCode.CaptionName = "본부"
            Me.cboRoleCode.ListCount = 0
            Me.cboRoleCode.Location = New System.Drawing.Point(360, 19)
            Me.cboRoleCode.Name = "cboRoleCode"
            Me.cboRoleCode.ReadOnlys = False
            Me.cboRoleCode.Size = New System.Drawing.Size(180, 20)
            Me.cboRoleCode.TabIndex = 9
            Me.cboRoleCode.Tag = "need;code(롤 코드 명, 시스템 구분 명|선택 하세요);"
            Me.cboRoleCode.TextValue = ""
            '
            'lblRolCode
            '
            Me.lblRolCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRolCode.Location = New System.Drawing.Point(291, 22)
            Me.lblRolCode.Name = "lblRolCode"
            Me.lblRolCode.Size = New System.Drawing.Size(63, 17)
            Me.lblRolCode.TabIndex = 10
            Me.lblRolCode.Text = "역할 코드"
            Me.lblRolCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'SMCB02
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblRolCode)
            Me.Controls.Add(Me.lblBusinessPlaceCode)
            Me.Controls.Add(Me.cboRoleCode)
            Me.Controls.Add(Me.cboProgramID)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMCB02"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblBusinessPlaceCode As System.Windows.Forms.Label
        Friend WithEvents cboProgramID As ubiLease.CommonControls.cbo
        Friend WithEvents cboRoleCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblRolCode As System.Windows.Forms.Label

    End Class

End Namespace
