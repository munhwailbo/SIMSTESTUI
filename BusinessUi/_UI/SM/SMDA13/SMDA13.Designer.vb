Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDA13
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDA13))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.popEarningsOrganizationCode = New ubiLease.CommonControls.pop
            Me.lblPrivateUseBeginningDate = New System.Windows.Forms.Label
            Me.dtpStDate = New ubiLease.CommonControls.dtp
            Me.lblRoleCode = New System.Windows.Forms.Label
            Me.cboRoleCode = New ubiLease.CommonControls.cbo
            Me.cboSystemDivision = New ubiLease.CommonControls.cbo
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpEdDate = New ubiLease.CommonControls.dtp
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.lblSeviceDivisionCode = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.grd_1.Size = New System.Drawing.Size(801, 556)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 22
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
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
            Me.picCriteria_1.TabIndex = 424
            Me.picCriteria_1.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(451, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(57, 12)
            Me.Label4.TabIndex = 452
            Me.Label4.Text = "조직 코드"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popEarningsOrganizationCode
            '
            Me.popEarningsOrganizationCode.BorderColor = System.Drawing.Color.Empty
            Me.popEarningsOrganizationCode.BorderStyle = 2
            Me.popEarningsOrganizationCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEarningsOrganizationCode.CaptionName = "파트 명"
            Me.popEarningsOrganizationCode.CodeText = ""
            Me.popEarningsOrganizationCode.CodeWidth = 60
            Me.popEarningsOrganizationCode.Location = New System.Drawing.Point(514, 18)
            Me.popEarningsOrganizationCode.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEarningsOrganizationCode.MaxLength = 8
            Me.popEarningsOrganizationCode.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEarningsOrganizationCode.Name = "popEarningsOrganizationCode"
            Me.popEarningsOrganizationCode.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEarningsOrganizationCode.NameText = ""
            Me.popEarningsOrganizationCode.ReadOnlys = False
            Me.popEarningsOrganizationCode.SelectedText = ""
            Me.popEarningsOrganizationCode.SelectionLength = 0
            Me.popEarningsOrganizationCode.SelectionStart = 0
            Me.popEarningsOrganizationCode.Size = New System.Drawing.Size(271, 20)
            Me.popEarningsOrganizationCode.TabIndex = 453
            Me.popEarningsOrganizationCode.Tag = "code(파트 명);"
            Me.popEarningsOrganizationCode.TextAlign = 0
            Me.popEarningsOrganizationCode.TextValue = ""
            Me.popEarningsOrganizationCode.ToolTipText = ""
            '
            'lblPrivateUseBeginningDate
            '
            Me.lblPrivateUseBeginningDate.AutoSize = True
            Me.lblPrivateUseBeginningDate.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPrivateUseBeginningDate.Location = New System.Drawing.Point(34, 48)
            Me.lblPrivateUseBeginningDate.Name = "lblPrivateUseBeginningDate"
            Me.lblPrivateUseBeginningDate.Size = New System.Drawing.Size(57, 12)
            Me.lblPrivateUseBeginningDate.TabIndex = 461
            Me.lblPrivateUseBeginningDate.Text = "기준 일자"
            Me.lblPrivateUseBeginningDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpStDate
            '
            Me.dtpStDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpStDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpStDate.BorderStyle = 2
            Me.dtpStDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpStDate.CaptionName = "기준 일자"
            Me.dtpStDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpStDate.Location = New System.Drawing.Point(96, 44)
            Me.dtpStDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpStDate.MaxLength = 0
            Me.dtpStDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpStDate.Name = "dtpStDate"
            Me.dtpStDate.ReadOnlys = False
            Me.dtpStDate.SelectedText = ""
            Me.dtpStDate.SelectionLength = 0
            Me.dtpStDate.SelectionStart = 0
            Me.dtpStDate.Size = New System.Drawing.Size(116, 20)
            Me.dtpStDate.TabIndex = 460
            Me.dtpStDate.Tag = "format(####-##-##);"
            Me.dtpStDate.TextAlign = 0
            Me.dtpStDate.TextValue = Nothing
            Me.dtpStDate.ToolTipText = ""
            '
            'lblRoleCode
            '
            Me.lblRoleCode.AutoSize = True
            Me.lblRoleCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRoleCode.Location = New System.Drawing.Point(218, 22)
            Me.lblRoleCode.Name = "lblRoleCode"
            Me.lblRoleCode.Size = New System.Drawing.Size(57, 12)
            Me.lblRoleCode.TabIndex = 459
            Me.lblRoleCode.Text = "역할 코드"
            Me.lblRoleCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboRoleCode
            '
            Me.cboRoleCode.CaptionName = "롤 코드 명"
            Me.cboRoleCode.ListCount = 0
            Me.cboRoleCode.Location = New System.Drawing.Point(281, 18)
            Me.cboRoleCode.Name = "cboRoleCode"
            Me.cboRoleCode.ReadOnlys = False
            Me.cboRoleCode.Size = New System.Drawing.Size(160, 20)
            Me.cboRoleCode.TabIndex = 458
            Me.cboRoleCode.Tag = "code(롤 코드 명, 시스템 구분 명|전체);"
            Me.cboRoleCode.TextValue = ""
            '
            'cboSystemDivision
            '
            Me.cboSystemDivision.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision.ListCount = 0
            Me.cboSystemDivision.Location = New System.Drawing.Point(96, 18)
            Me.cboSystemDivision.Name = "cboSystemDivision"
            Me.cboSystemDivision.ReadOnlys = False
            Me.cboSystemDivision.Size = New System.Drawing.Size(116, 20)
            Me.cboSystemDivision.TabIndex = 457
            Me.cboSystemDivision.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision.TextValue = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.AutoSize = True
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(25, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(69, 12)
            Me.lblCodeDivisionHangulName.TabIndex = 456
            Me.lblCodeDivisionHangulName.Text = "시스템 구분"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(234, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(18, 13)
            Me.Label1.TabIndex = 462
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpEdDate
            '
            Me.dtpEdDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpEdDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpEdDate.BorderStyle = 2
            Me.dtpEdDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpEdDate.CaptionName = "기준 일자"
            Me.dtpEdDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpEdDate.Location = New System.Drawing.Point(281, 44)
            Me.dtpEdDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpEdDate.MaxLength = 0
            Me.dtpEdDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpEdDate.Name = "dtpEdDate"
            Me.dtpEdDate.ReadOnlys = False
            Me.dtpEdDate.SelectedText = ""
            Me.dtpEdDate.SelectionLength = 0
            Me.dtpEdDate.SelectionStart = 0
            Me.dtpEdDate.Size = New System.Drawing.Size(116, 20)
            Me.dtpEdDate.TabIndex = 463
            Me.dtpEdDate.Tag = "format(####-##-##);"
            Me.dtpEdDate.TextAlign = 0
            Me.dtpEdDate.TextValue = Nothing
            Me.dtpEdDate.ToolTipText = ""
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "사원 번호"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(514, 44)
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
            Me.popEmployeeNumber.TabIndex = 804
            Me.popEmployeeNumber.Tag = "code(사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'lblSeviceDivisionCode
            '
            Me.lblSeviceDivisionCode.AutoSize = True
            Me.lblSeviceDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSeviceDivisionCode.Location = New System.Drawing.Point(451, 47)
            Me.lblSeviceDivisionCode.Name = "lblSeviceDivisionCode"
            Me.lblSeviceDivisionCode.Size = New System.Drawing.Size(57, 12)
            Me.lblSeviceDivisionCode.TabIndex = 803
            Me.lblSeviceDivisionCode.Text = "사원 번호"
            '
            'SMDA13
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.lblSeviceDivisionCode)
            Me.Controls.Add(Me.dtpEdDate)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblPrivateUseBeginningDate)
            Me.Controls.Add(Me.dtpStDate)
            Me.Controls.Add(Me.lblRoleCode)
            Me.Controls.Add(Me.cboRoleCode)
            Me.Controls.Add(Me.cboSystemDivision)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.popEarningsOrganizationCode)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMDA13"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents popEarningsOrganizationCode As ubiLease.CommonControls.pop
        Friend WithEvents lblPrivateUseBeginningDate As System.Windows.Forms.Label
        Friend WithEvents dtpStDate As ubiLease.CommonControls.dtp
        Friend WithEvents lblRoleCode As System.Windows.Forms.Label
        Friend WithEvents cboRoleCode As ubiLease.CommonControls.cbo
        Friend WithEvents cboSystemDivision As ubiLease.CommonControls.cbo
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpEdDate As ubiLease.CommonControls.dtp
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents lblSeviceDivisionCode As System.Windows.Forms.Label

    End Class

End Namespace
