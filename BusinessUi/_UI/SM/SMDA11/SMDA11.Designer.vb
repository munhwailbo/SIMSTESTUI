Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDA11
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDA11))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.cboSystemDivision = New ubiLease.CommonControls.cbo
            Me.lblRoleCode = New System.Windows.Forms.Label
            Me.cboRoleCode = New ubiLease.CommonControls.cbo
            Me.lblPrivateUseBeginningDate = New System.Windows.Forms.Label
            Me.dtpStandardDate = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.cboProcessState = New ubiLease.CommonControls.cbo
            Me.grd_1 = New ubiLease.GridControl.grd
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.AutoSize = True
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(25, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(69, 12)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "시스템 구분"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 72)
            Me.picCriteria_1.TabIndex = 2
            Me.picCriteria_1.TabStop = False
            '
            'cboSystemDivision
            '
            Me.cboSystemDivision.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision.ListCount = 0
            Me.cboSystemDivision.Location = New System.Drawing.Point(100, 18)
            Me.cboSystemDivision.Name = "cboSystemDivision"
            Me.cboSystemDivision.ReadOnlys = False
            Me.cboSystemDivision.Size = New System.Drawing.Size(116, 20)
            Me.cboSystemDivision.TabIndex = 3
            Me.cboSystemDivision.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision.TextValue = ""
            '
            'lblRoleCode
            '
            Me.lblRoleCode.AutoSize = True
            Me.lblRoleCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRoleCode.Location = New System.Drawing.Point(222, 22)
            Me.lblRoleCode.Name = "lblRoleCode"
            Me.lblRoleCode.Size = New System.Drawing.Size(57, 12)
            Me.lblRoleCode.TabIndex = 56
            Me.lblRoleCode.Text = "역할 코드"
            Me.lblRoleCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboRoleCode
            '
            Me.cboRoleCode.CaptionName = "롤 코드 명"
            Me.cboRoleCode.ListCount = 0
            Me.cboRoleCode.Location = New System.Drawing.Point(289, 18)
            Me.cboRoleCode.Name = "cboRoleCode"
            Me.cboRoleCode.ReadOnlys = False
            Me.cboRoleCode.Size = New System.Drawing.Size(160, 20)
            Me.cboRoleCode.TabIndex = 55
            Me.cboRoleCode.Tag = "code(롤 코드 명, 시스템 구분 명|전체);"
            Me.cboRoleCode.TextValue = ""
            '
            'lblPrivateUseBeginningDate
            '
            Me.lblPrivateUseBeginningDate.AutoSize = True
            Me.lblPrivateUseBeginningDate.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPrivateUseBeginningDate.Location = New System.Drawing.Point(34, 48)
            Me.lblPrivateUseBeginningDate.Name = "lblPrivateUseBeginningDate"
            Me.lblPrivateUseBeginningDate.Size = New System.Drawing.Size(57, 12)
            Me.lblPrivateUseBeginningDate.TabIndex = 428
            Me.lblPrivateUseBeginningDate.Text = "기준 일자"
            Me.lblPrivateUseBeginningDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpStandardDate
            '
            Me.dtpStandardDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpStandardDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpStandardDate.BorderStyle = 2
            Me.dtpStandardDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpStandardDate.CaptionName = "기준 일자"
            Me.dtpStandardDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpStandardDate.Location = New System.Drawing.Point(100, 44)
            Me.dtpStandardDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpStandardDate.MaxLength = 0
            Me.dtpStandardDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpStandardDate.Name = "dtpStandardDate"
            Me.dtpStandardDate.ReadOnlys = False
            Me.dtpStandardDate.SelectedText = ""
            Me.dtpStandardDate.SelectionLength = 0
            Me.dtpStandardDate.SelectionStart = 0
            Me.dtpStandardDate.Size = New System.Drawing.Size(116, 20)
            Me.dtpStandardDate.TabIndex = 427
            Me.dtpStandardDate.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpStandardDate.TextAlign = 0
            Me.dtpStandardDate.TextValue = Nothing
            Me.dtpStandardDate.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(222, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 12)
            Me.Label1.TabIndex = 430
            Me.Label1.Text = "처리 구분"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboProcessState
            '
            Me.cboProcessState.CaptionName = ""
            Me.cboProcessState.ListCount = 0
            Me.cboProcessState.Location = New System.Drawing.Point(289, 44)
            Me.cboProcessState.Name = "cboProcessState"
            Me.cboProcessState.ReadOnlys = False
            Me.cboProcessState.Size = New System.Drawing.Size(160, 20)
            Me.cboProcessState.TabIndex = 429
            Me.cboProcessState.Tag = "code(처리 상태 명|전체);"
            Me.cboProcessState.TextValue = ""
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
            Me.grd_1.Location = New System.Drawing.Point(3, 83)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 556)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 431
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'SMDA11
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboProcessState)
            Me.Controls.Add(Me.lblPrivateUseBeginningDate)
            Me.Controls.Add(Me.dtpStandardDate)
            Me.Controls.Add(Me.lblRoleCode)
            Me.Controls.Add(Me.cboRoleCode)
            Me.Controls.Add(Me.cboSystemDivision)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "SMDA11"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents cboSystemDivision As ubiLease.CommonControls.cbo
        Friend WithEvents lblRoleCode As System.Windows.Forms.Label
        Friend WithEvents cboRoleCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblPrivateUseBeginningDate As System.Windows.Forms.Label
        Friend WithEvents dtpStandardDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboProcessState As ubiLease.CommonControls.cbo
        Friend WithEvents grd_1 As ubiLease.GridControl.grd

    End Class

End Namespace
